using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MarinaHR.Controllers
{
    [Authorize]
    public class VacationController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;

        public VacationController(ApplicationDbContext context, UserManager<User> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public ActionResult RequestVacation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  RequestVacation(Vacation vacation)
        {
            var user = await userManager.GetUserAsync(User); 

            System.Diagnostics.Debug.WriteLine(user.Id);

            vacation.UserID = user.Id;
            context.Vacations.Add(vacation);
            context.SaveChanges();

            var data = context.Vacations
                    .Include(vacation => vacation.User).ToList();

            return View("Index", data);
        }


        public ActionResult Index()
        {
                var data = context.Vacations
                    .Include(vacation => vacation.User).ToList();
                return View(data);
        }

        private string GetCurrentUserId()
        {
            return userManager.GetUserId(User);
        }
    }
}