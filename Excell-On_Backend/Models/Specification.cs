﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public virtual ICollection<Specification_Employee> Specification_Employees { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}