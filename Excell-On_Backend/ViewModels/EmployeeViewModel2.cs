using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class EmployeeViewModel2
    {
        [Required]
        public string AccountID { get; set; }
    }
    public class EmployeeSpecifications
    {
        [Required]
        public int SpecificationsID { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
    }
}