using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public string UpdateAt { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}