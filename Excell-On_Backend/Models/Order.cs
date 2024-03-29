﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


namespace Excell_On_Backend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string AccountID { get; set; }
        public int Status { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Deposit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails{ get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}