using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Excell_On_Backend.Models
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
    public class RoleForUserModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string AccountId { get; set; }
    }
}