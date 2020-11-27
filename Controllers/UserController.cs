
using System.Threading.Tasks;
using System.Collections.Generic;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MarinaHR.Controllers
{
    [Authorize]
   public class UserController : Controller
    {
        private readonly ApplicationDbContext context;

        private readonly UserManager<User> userManager;

        public UserController(ApplicationDbContext context,
        UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public ActionResult Create()
        {
            ViewData["PlaID"] = new SelectList(context.Places.AsEnumerable(), "ID", "Name");
            ViewData["DepID"] = new SelectList(context.Departments.AsEnumerable(), "ID", "Name");
            return View();
        }

        // [HttpPost]
        // public Task<IActionResult> Create(User user)
        // {


        //     ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
        //     ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");

        //     user.PasswordHash= PasswordGenerator(user, "1234");
        //     user.NormalizedUserName = user.UserName.ToUpper();
            
            

        //     var result = await userManager.CreateAsync(user, "1234");
        //         if (result.Succeeded)
        //         {
        //            // await userManager.AddToRoleAsync(user, role.Name);
        //         }
        //         foreach (var error in result.Errors)
        //         {
        //             ModelState.AddModelError("", error.Description);
        //         }

        //     return View();
        // }

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