using System.Threading.Tasks;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MarinaHR.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace MarinaHR.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext context;
        public DepartmentController(ApplicationDbContext _context)
        {
            context = _context;
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
            var data = context.Departments.ToList();
            return View(data);
        }
    }
}