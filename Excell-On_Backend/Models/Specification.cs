using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public ICollection<Specification_Employee> Specification_Employees { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}