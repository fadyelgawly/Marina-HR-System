using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MarinaHR.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarinaHR.Controllers
{
    public class AccountController : Controller
    {

        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signinManager;
        private readonly RoleManager<UserRole> roleManager;

        public AccountController(ApplicationDbContext context,
                                 UserManager<User> userManager, 
                                 SignInManager<User> signinManager,
                                 RoleManager<UserRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.signinManager = signinManager;
            this.roleManager = roleManager;

        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid){

                var user = new User { UserName = model.UserName };
                var result = await userManager.CreateAsync(user, model.Password);
                if(result.Succeeded){
                    await signinManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }  
        public IActionResult Login()
        {
             if (!signinManager.IsSignedIn(User))
            {
                return View();
            } 
            else 
            {
                return RedirectToAction("Index", "Home");   
            }
        }

         [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await signinManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                } else {
                    ModelState.AddModelError(string.Empty, "اسم المستخدم او كلمة المرور غير صحيحة");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            System.Diagnostics.Debug.WriteLine("GET");
            ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
            ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");
            ViewData["RoleID"] = new SelectList(await roleManager.Roles.ToListAsync(), "Id", "NameInArabic");
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var role = await roleManager.FindByIdAsync(model.RoleID);
                var user = new User 
                {
                    Name = model.Name,
                    UserName = model.UserName,
                    PhoneNumber = model.PhoneNumber,
                    Birthdate = model.Birthdate,
                    DepartmentID = model.DepartmentID,
                    PlaceID = model.PlaceID,

                };
                    
                var result = await userManager.CreateAsync(user, "1234");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role.Name);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            

            ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
            ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");
            ViewData["RoleID"] = new SelectList(await roleManager.Roles.ToListAsync(), "Id", "NameInArabic");

            return View();
        }
        
         public ActionResult Index()
        {
            return View(userManager.Users);
        }
        private string PasswordGenerator(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }







    }
}