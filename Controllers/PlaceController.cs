using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;
using MarinaHR.ViewModels;

namespace MarinaHR.Controllers
{
    [Authorize]
    public class PlaceController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlaceController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Place place)
        {
            context.Places.Add(place);
            context.SaveChanges();
            return View("Index", context.Places.ToList());
        }

        public ActionResult Index()
        {
            var data = context.Places.Select(a => new PlaceDetailsViewModel
                {
                    Name = a.Name,
                    UsersCount = a.Users.Count()
                })
                .ToList();

            return View(data);
        }
    }
}