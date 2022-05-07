using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class EmployeeViewModel
    {
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string CitizenID { get; set; }
        [Required]
        public string Birthday { get; set; }
        [Required]
        public int SpecificationID { get; set; }
    }
}