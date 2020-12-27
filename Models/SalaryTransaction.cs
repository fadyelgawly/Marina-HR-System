using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MarinaHR.Models
{
    public class SalaryTransaction
    {

        [Key]
        public int ID { get; set; }

        public TransactionType transactionType { get; set; }
        
        public double Amount { get; set; }

        public DateTime dateTime { get; set; }

        public string Description { get; set; }
        
        
        public string UserID { get; set; }
        
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        
    }

    public enum TransactionType {
        Credit,
        Deposit
    }
}