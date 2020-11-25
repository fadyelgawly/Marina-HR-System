using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MarinaHR.ViewModels;

namespace MarinaHR.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        private readonly SignInManager<IdentityUser> signinManager;

        public AccountController(UserManager<IdentityUser> userManager, 
                                 SignInManager<IdentityUser> signinManager)
        {
            this.userManager = userManager;
            this.signinManager = signinManager;

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
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
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
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await signinManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
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
    }
}