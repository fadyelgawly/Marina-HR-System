using System;
using System.ComponentModel.DataAnnotations;

namespace MarinaHR.ViewModels
{
    public class VacationViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }  
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public int VacationDays { get; set; }
        public int VacationDaysLeft  { get; set; }
        
    }
}

