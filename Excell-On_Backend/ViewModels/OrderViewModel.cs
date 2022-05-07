using Excell_On_Backend.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class OrderViewModel
    {
        [Required]
        public string AccountID { get; set; }
        [Required]
        public decimal Deposit { get; set; }
        public IEnumerable<OrderDetailsViewModel> OrderDetails { get; set; }
    }
}