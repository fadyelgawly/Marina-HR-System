using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Vacation vacation)
        {
            context.Vacations.Add(vacation);
            context.SaveChanges();
            return View("Index", context.Vacations.ToList());
        }

        public ActionResult Index()
        {
           // if (User.IsInRole("Administrator"))
            // get all vacations

               // var data = context.Vacations.Where(i => i.UserID == GetCurrentUserId).ToList();

                var data = context.Vacations.ToList();
                return View(data);
                //else get user's vacations only
          
        }

        private string GetCurrentUserId()
        {
            return userManager.GetUserId(User);
        }
    }
}