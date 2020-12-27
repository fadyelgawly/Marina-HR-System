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

using System.Collections.Generic;

namespace MarinaHR.Services 
{

    public interface ISalaryManager{
        int ReleaseWeeklySalaries();
        int ReleaseMonthlySalaries();
    }

    public class SalaryManager : ISalaryManager
    {

        private readonly UserManager<User> userManager;
        
        private readonly ApplicationDbContext context;

        public SalaryManager(ApplicationDbContext context, UserManager<User> userManager)
        {
           this.context = context;
           this.userManager = userManager;
        } 

        public int ReleaseWeeklySalaries(){
            var users = userManager.Users.Where(x => x.SalaryType == SalaryFrequency.Weekly);
            foreach (var user in users)
            {   
                var transaction = new SalaryTransaction {
                    UserID = user.Id,
                    dateTime = DateTime.Now.Date,
                    Amount = user.SalaryAmount,
                    Description = "Weekly Salary",
                    transactionType = TransactionType.Deposit
                };
                context.Transaction.Add(transaction);
                context.SaveChanges();
            }
            return 0;
        }

        public int ReleaseMonthlySalaries(){
            var users = userManager.Users.Where(x => x.SalaryType == SalaryFrequency.Monthly);
            foreach (var user in users)
            {   
                var transaction = new SalaryTransaction {
                    UserID = user.Id,
                    dateTime = DateTime.Now.Date,
                    Amount = user.SalaryAmount,
                    Description = "Monthly Salary",
                    transactionType = TransactionType.Deposit
                };
                context.Transaction.Add(transaction);
                context.SaveChanges();
            }
            return 0;
        }
    }

}