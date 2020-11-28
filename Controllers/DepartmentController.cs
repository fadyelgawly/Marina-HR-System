using System.Threading.Tasks;
using MarinaHR.Models;
using MarinaHR.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace MarinaHR.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        
        public DepartmentController(ApplicationDbContext _context, UserManager<User> userManager)
        {
            context = _context;
            this.userManager = userManager;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return View("Index", context.Departments.ToList());
        }

        public ActionResult Index()
        {
            var data = context.Departments.Select(a => new DepartmentDetailsViewModel
                {
                    Name = a.Name,
                    UsersCount = a.Users.Count()
                })
                .ToList();


           // var data = context.Departments.ToList();
            return View(data);
        }
    }
}