using System;
using System.Threading.Tasks;
using MarinaHR.Models;
using MarinaHR.ViewModels;
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

            vacation.UserID = user.Id;
            context.Add(vacation);
            context.SaveChanges();

            return RedirectToAction("Index");
        }


        public async Task<ActionResult> IndexAsync()
        {

            
            var data = context.Vacations
                .Include(vacation => vacation.User)
                .Select(a => new VacationViewModel
                {
                    ID = a.ID,
                    Name = a.User.Name,
                    StartDate = a.StartDate,
                    EndDate = a.EndDate,
                    Reason = a.Reason,
                    VacationDays = (a.EndDate.Date - a.StartDate.Date).Days + 1,
                    VacationDaysLeft = 0,
                    vacationStatus = a.vacationStatus
                })
                .ToList();

            var user = await userManager.GetUserAsync(User);

            int TotalBalance = user.VacationBalance;

            var vacationBalance = context.Vacations
                .Include(vacation => vacation.User)
                .Where(x => x.UserID == GetCurrentUserId() && x.vacationStatus == VacationStatus.Accepted)
                .Select(a => new VacationBalance
                {
                    vacationBalance = (a.EndDate.Date - a.StartDate.Date).Days + 1,
                })
                .ToList();

            int usedVacations = vacationBalance.Sum(x => x.vacationBalance);

            ViewData["TotalBalance"] = TotalBalance;
            ViewData["UsedBalance"] = usedVacations;
            ViewData["BalanceLeft"] = TotalBalance - usedVacations;


            return View(data);
        }

       public ActionResult AcceptVacationRequest(int VacationID)
        {

            var vacation = context.Vacations.Find(VacationID);

            vacation.vacationStatus = VacationStatus.Accepted;

            //vacation.StartDate = DateTime.Now.Date;

            context.Update(vacation);
            context.SaveChanges();

            
            return RedirectToAction("Index");
        }
        public ActionResult RefuseVacationRequest(int VacationID)
        {


            var vacation = context.Vacations.Find(VacationID);

            vacation.vacationStatus = VacationStatus.Declined;

            //vacation.StartDate = DateTime.Now.Date;

            context.Update(vacation);
            context.SaveChanges();


            return RedirectToAction("Index");
        }


        

        private string GetCurrentUserId()
        {
            return userManager.GetUserId(User);
        }
    }

    public class VacationBalance
    {
        public int vacationBalance { get; set; }
    };
}