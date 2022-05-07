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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public virtual Account Account { get; set; }
        public virtual Specification Specification { get; set; }
    }
}