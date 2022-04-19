using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public decimal PriceTotal { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public Order Order { get; set; }
        public ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}