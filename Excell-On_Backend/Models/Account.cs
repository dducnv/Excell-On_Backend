using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
namespace Excell_On_Backend.Models
{
    public class Account : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Account> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
        public string Avatar { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public string CitizenID { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Specification_Employee> Specification_Employees { get; set; }
        public virtual ICollection<OrderDetails_Employee> OrderDetails_Employees { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
   
    }
}