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
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

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

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await context.User
                .Include(u => u.Department)
                .Include(u => u.Place)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        // GET: Accounts/SMS/5
        public async Task<IActionResult> SMS(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await context.User
                .Include(u => u.Department)
                .Include(u => u.Place)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Accounts/SMS/5
        [HttpPost]
        public async Task<IActionResult> SMS(string id, SMSBody model)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await context.User
                .Include(u => u.Department)
                .Include(u => u.Place)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            //var body = model.Body;
            //var phone = user.PhoneNumber;

            //TwilioClient.Init("ACa7aeb5e7e2bb26fd1f5554417a0052d6", "bac8411cc083d37caab1bcdf7592ac72");

            //var message = MessageResource.Create(
            //    body: body,
            //    from: new Twilio.Types.PhoneNumber(body),
            //    to: new Twilio.Types.PhoneNumber(body)
            //);


            return RedirectToAction("Index", "Account");
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
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {

            ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
            ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");
            ViewData["RoleID"] = new SelectList(await roleManager.Roles.ToListAsync(), "Id", "NameInArabic");
            
            return View();
        }

        [Authorize]
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
                    DepartmentID = model.DepartmentID,
                    PlaceID = model.PlaceID,
                    SalaryType = model.SalaryType,
                    SalaryAmount = model.SalaryAmount,
                    VacationBalance = model.VacationBalance
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

        [Authorize]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            } 
                var userVM = new CreateUserViewModel
                {
                    Name = user.Name,
                    UserName = user.UserName,
                    PlaceID = user.PlaceID,
                    DepartmentID = user.DepartmentID,
                    SalaryType = user.SalaryType,
                    SalaryAmount = user.SalaryAmount,
                    VacationBalance = user.VacationBalance,
                    PhoneNumber = user.PhoneNumber
                };
            
            ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
            ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");

            return View(userVM);
        }


        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, CreateUserViewModel userVM)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await context.User.FindAsync(id);

            if (ModelState.IsValid)
            {
                try
                {
                    user.Name = userVM.Name;
                    user.UserName = userVM.UserName;
                    user.PlaceID = userVM.PlaceID;
                    user.DepartmentID = userVM.DepartmentID;
                    user.SalaryType = userVM.SalaryType;
                    user.SalaryAmount = userVM.SalaryAmount;
                    user.VacationBalance = userVM.VacationBalance;
                    user.PhoneNumber = userVM.PhoneNumber;

                    context.Update(user);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentID"] = new SelectList(context.Departments, "ID", "ID", user.DepartmentID);
            ViewData["PlaceID"] = new SelectList(context.Places, "ID", "Name", user.PlaceID);

            return View(userVM);
        }

        // GET: Accounts/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await context.User
                .Include(u => u.Department)
                .Include(u => u.Place)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Accounts/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await context.User.FindAsync(id);
            context.User.Remove(user);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return context.User.Any(e => e.Id == id);
        }

        [Authorize]
        public ActionResult Index()
        {
            var users = userManager.Users
                .Include(user => user.Department)
                .Include(user => user.Place);
            return View(users);
        }
        private string PasswordGenerator(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}