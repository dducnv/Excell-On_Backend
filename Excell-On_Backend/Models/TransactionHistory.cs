using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class TransactionHistory
    {
        public int Id { get; set; }
        public int ContractID { get; set; }
        public decimal PriceSent { get; set; }
        public decimal InDebt { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public virtual Contract Contract { get; set; }
    }
}