using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class EmployeeODViewModel
    {
   
        public int OrderDetailsID { get; set; }
        public IEnumerable<EmployeeViewModel2> Employee { get; set; }
    }
}