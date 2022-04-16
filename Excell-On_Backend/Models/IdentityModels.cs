
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace Excell_On_Backend.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationDbContext : IdentityDbContext<Account>
    {
        public ApplicationDbContext()
            : base("ExcellOnDBContext", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Specification_Employee> Specification_Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderDetails_Employee> OrderDetails_Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}