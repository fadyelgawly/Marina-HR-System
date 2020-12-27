using System;
using System.Linq;
using MarinaHR.Data;
using MarinaHR.Models;
using System.Data.Common;
using MarinaHR.ViewModels;
using System.Transactions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;



namespace MarinaHR.Controllers
{
    public class SalaryController : Controller
    {
        private readonly UserManager<User> userManager;
        
        private readonly ApplicationDbContext context;

        public SalaryController(ApplicationDbContext _context, UserManager<User> userManager)
        {
            context = _context;
            this.userManager = userManager;

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Create(SalaryTransaction transaction)
        {
            var user = await userManager.GetUserAsync(User); 

            transaction.UserID = user.Id;
            transaction.dateTime = DateTime.Now.Date;
            context.Transaction.Add(transaction);
            context.SaveChanges();
             return View("Index", context.Transaction.ToList());
        }

        public ActionResult Index()
        {

          //  SalaryManager.Shared.ReleaseRecurrentSalaries();

            var data = context.Transaction
                .Include(transaction => transaction.User)
                .Select(a => new SalaryViewModel
                {
                    ID = a.ID,
                    Name = a.User.Name,
                    Amount = a.Amount,
                    dateTime = a.dateTime,
                    transactionType = a.transactionType
                })
                .ToList();    

            return View(data);
        }

        private string GetCurrentUserId()
        {
            return userManager.GetUserId(User);
        }

        

    }
}