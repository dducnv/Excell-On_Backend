using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ServiceID { get; set; }
        public int SpecificationID { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
        public virtual Specification Specification { get; set; }
        public virtual ICollection<OrderDetails_Employee> OrderDetails_Employees { get; set; }
    }
}