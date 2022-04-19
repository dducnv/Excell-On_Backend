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
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public Contract Contract { get; set; }
    }
}