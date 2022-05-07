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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}