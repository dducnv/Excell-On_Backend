using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int ServiceID { get; set; }
        public int SpecificationID { get; set; }
        public int Qty { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal UnitPrice { get; set; }
    }
}