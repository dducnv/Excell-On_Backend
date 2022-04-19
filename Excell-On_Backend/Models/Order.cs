using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Excell_On_Backend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string AccountID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Status { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public Account Account { get; set; }
        public ICollection<OrderDetails> OrderDetails{ get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}