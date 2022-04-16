using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class OrderDetails_Employee
    {
        public int Id { get; set; }
        public string AccountID { get; set; }
        public int OrderDetailsID { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public virtual Account Account { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }

    }
}