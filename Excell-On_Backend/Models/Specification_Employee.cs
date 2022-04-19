using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class Specification_Employee
    {
        public int Id { get; set; }
        public int SpecificationID { get; set; }
        public string AccountID { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public Account Account { get; set; }
        public Specification Specification { get; set; }
    }
}