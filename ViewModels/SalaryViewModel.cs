using System;
using System.ComponentModel.DataAnnotations;
using MarinaHR.Models;

namespace MarinaHR.ViewModels
{
    public class SalaryViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }  

        public TransactionType transactionType { get; set; }
        
        public double Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime dateTime { get; set; }

        public string Description { get; set; }
        
        
        
        
    }
}

