using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;

namespace MarinaHR.Controllers
{
    //[Authorize]
    public class VacationController : Controller
    {
        private readonly ApplicationDbContext context;

        public VacationController(ApplicationDbContext _context)
        {
            context = _context;
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
            var data = context.Vacations.ToList();
            return View(data);
        }
    }
}