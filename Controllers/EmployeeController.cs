using System.Threading.Tasks;
using System.Collections.Generic;
using MarinaHR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using MarinaHR.Data;

namespace MarinaHR.Controllers
{
    //[Authorize]
   public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext _context)
        {
            context = _context;
        }

        public ActionResult Create()
        {
            ViewData["PlaID"] = new SelectList(context.Places.AsEnumerable(), "ID", "Name");
            ViewData["DepID"] = new SelectList(context.Departments.AsEnumerable(), "ID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {


            ViewData["PlacesID"] = new SelectList(context.Places.ToList(), "ID", "Name");
            ViewData["DepartmentID"] = new SelectList(context.Departments.ToList(), "ID", "Name");

            context.Employees.Add(employee);
            context.SaveChanges();
            return View("Index", context.Employees.ToList());
        }

        public ActionResult Index()
        {
            var data = context.Employees.ToList();
            return View(data);
        }
    }
}