
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

            employee.PasswordHash= PasswordGenerator(employee, "1234");
            employee.NormalizedUserName = employee.UserName.ToUpper();
            context.Employees.Add(employee);
            context.SaveChanges();
            return View("Index", context.Employees.ToList());
        }

        public ActionResult Index()
        {
            var data = context.Employees.ToList();
            return View(data);
        }
        private string PasswordGenerator(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}