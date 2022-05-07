namespace Excell_On_Backend.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Excell_On_Backend.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            ClearData(context);
            ResetAutoIncrement(context);
            AddRoles(context);
            AddUser(context);
            AddRoleUser(context);
            AddService(context);
            AddSpecifications(context);
            AddOrder(context);
            AddOderDetails(context);
            addOrderDetailsEmployee(context);
            addContract(context);
            AddSpecificationsEmployee(context);
            context.SaveChanges();
        }

        private void AddSpecificationsEmployee(ApplicationDbContext context)
        {
            var date = DateTime.Now;
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 1,
                SpecificationID = 3,
                AccountID = "EP001",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 2,
                SpecificationID = 3,
                AccountID = "EP002",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 3,
                SpecificationID = 3,
                AccountID = "EP003",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 4,
                SpecificationID = 3,
                AccountID = "EP004",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 5,
                SpecificationID = 3,
                AccountID = "EP005",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 6,
                SpecificationID = 3,
                AccountID = "EP006",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 7,
                SpecificationID = 3,
                AccountID = "EP007",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 8,
                SpecificationID = 3,
                AccountID = "EP008",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 9,
                SpecificationID = 3,
                AccountID = "EP009",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 10,
                SpecificationID = 3,
                AccountID = "EP0010",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 11,
                SpecificationID = 3,
                AccountID = "EP0011",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 12,
                SpecificationID = 3,
                AccountID = "EP0012",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 13,
                SpecificationID = 3,
                AccountID = "EP0012",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 14,
                SpecificationID = 3,
                AccountID = "EP0014",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 15,
                SpecificationID = 3,
                AccountID = "EP0015",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 16,
                SpecificationID = 3,
                AccountID = "EP0016",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 17,
                SpecificationID = 3,
                AccountID = "EP0017",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 18,
                SpecificationID = 3,
                AccountID = "EP0018",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 19,
                SpecificationID = 3,
                AccountID = "EP0019",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 20,
                SpecificationID = 3,
                AccountID = "EP0020",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 21,
                SpecificationID = 3,
                AccountID = "EP0021",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 22,
                SpecificationID = 3,
                AccountID = "EP0022",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 23,
                SpecificationID = 3,
                AccountID = "EP0023",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 24,
                SpecificationID = 3,
                AccountID = "EP0024",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 25,
                SpecificationID = 3,
                AccountID = "EP0025",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 26,
                SpecificationID = 3,
                AccountID = "EP0026",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 27,
                SpecificationID = 3,
                AccountID = "EP0027",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 28,
                SpecificationID = 3,
                AccountID = "EP0028",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 29,
                SpecificationID = 3,
                AccountID = "EP0029",
                CreatedAt = date,
                UpdateAt = date
            });
            context.Specification_Employees.Add(new Specification_Employee()
            {
                Id = 30,
                SpecificationID = 3,
                AccountID = "EP0030",
                CreatedAt = date,
                UpdateAt = date
            });
        }

        private void addContract(ApplicationDbContext context)
        {
            var date = DateTime.Now;

            context.Contracts.Add(new Contract()
            {
                Id = 1,
                OrderID = 1,
                PriceTotal = 6000 * 10,
                StartDate = Convert.ToDateTime("04/18/2022"),
                EndDate = Convert.ToDateTime("05/18/2022"),
                CreatedAt = date,
                UpdateAt = date
            });
            context.Contracts.Add(new Contract()
            {
                Id = 2,
                OrderID = 2,
                PriceTotal = 4500 * 11,
                StartDate = Convert.ToDateTime("04/18/2022"),
                EndDate = Convert.ToDateTime("04/18/2022"),
                CreatedAt = date,
                UpdateAt = date
            });
        }

        private void addOrderDetailsEmployee(ApplicationDbContext context)
        {
            var date = DateTime.Now;
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 1,
                AccountID = "EP001",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 2,
                AccountID = "EP002",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 3,
                AccountID = "EP003",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 4,
                AccountID = "EP004",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 5,
                AccountID = "EP005",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 6,
                AccountID = "EP006",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 7,
                AccountID = "EP007",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 8,
                AccountID = "EP008",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 9,
                AccountID = "EP009",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 10,
                AccountID = "EP0010",
                OrderDetailsID = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 11,
                AccountID = "EP0011",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 12,
                AccountID = "EP0012",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 13,
                AccountID = "EP0013",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 14,
                AccountID = "EP0014",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 15,
                AccountID = "EP0015",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 16,
                AccountID = "EP0016",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails_Employees.Add(new OrderDetails_Employee()
            {
                Id = 17,
                AccountID = "EP0017",
                OrderDetailsID = 2,
                CreatedAt = date,
                UpdateAt = date
            });
            context.SaveChanges();
        }
        private void AddOderDetails(ApplicationDbContext context)
        {
            var date = DateTime.Now;

            context.OrderDetails.Add(new OrderDetails()
            {
                Id = 1,
                OrderID = 2,
                ServiceID = 1,
                SpecificationID = 3,
                StartDate = Convert.ToDateTime("04/18/2022"),
                EndDate = Convert.ToDateTime("06/10/2022"),
                Status =0,
                Qty = 11,
                UnitPrice = 4500 * 11,
                CreatedAt = date,
                UpdateAt = date
            });
            context.OrderDetails.Add(new OrderDetails()
            {
                Id = 2,
                OrderID = 2,
                ServiceID = 2,
                SpecificationID = 3,
                StartDate = Convert.ToDateTime("06/20/2022"),
                EndDate = Convert.ToDateTime("07/18/2022"),
                Status = 0,
                Qty = 11,
                UnitPrice = 4500 * 11,
                CreatedAt = date,
                UpdateAt = date
            });
        }
      
        private void AddOrder(ApplicationDbContext context)
        {
            var date = DateTime.Now;
            context.Orders.Add(new Order()
            {
                Id = 1,
                AccountID = "US0001",
                Status = 0,
                CreatedAt = date,
                UpdateAt = date
            });
            context.Orders.Add(new Order()
            {
                Id = 2,
                AccountID = "US0002",
                Status = 1,
                CreatedAt = date,
                UpdateAt = date
            });
            context.SaveChanges();
        }
        private void AddRoleUser(ApplicationDbContext context)
        {
            var userStore = new UserStore<Account>(context);
            var userManager = new UserManager<Account>(userStore);
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                userManager.AddToRole("EP00" + i, "EMPLOYEE");
            }
            context.SaveChanges();
        }
        private void AddUser(ApplicationDbContext context)
        {
            var userStore = new UserStore<Account>(context);
            var userManager = new UserManager<Account>(userStore);
            Random rnd = new Random();
            DateTime datetoday = DateTime.Now;
            int rndYear = rnd.Next(1978, datetoday.Year);
            int rndMonth = rnd.Next(1, 12);
            int rndDay = rnd.Next(1, 31);
            DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
            context.Users.Add(new Account()
            {
                Id = "US0001",
                FullName = "Nguyễn Hồng Quang",
                UserName = "hongquang",
                Email = "hongquang@gmail.com",
                PhoneNumber = "0383557844",
                Gender = 0,
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            context.Users.Add(new Account()
            {
                Id = "US0002",
                FullName = "Nguyễn Văn Đức",
                UserName = "ducnv",
                Email = "ducnv@gmail.com",
                PhoneNumber = "0383557845",
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Gender = 0,
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });

            context.Users.Add(new Account()
            {
                Id = "US0003",
                FullName = "Dương Quỳnh Anh",
                UserName = "quynhanh",
                Email = "quynhanh@gmail.com",
                PhoneNumber = "0383557846",
                Gender = 1,
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            context.Users.Add(new Account()
            {
                Id = "US0004",
                FullName = "Đinh Việt Hoàng",
                UserName = "viethoang",
                Email = "viethoang@gmail.com",
                PhoneNumber = "0383557847",
                Gender = 0,
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            context.Users.Add(new Account()
            {
                Id = "US0005",
                FullName = "Trần Duy Quân",
                UserName = "duyquan",
                Email = "duyquan@gmail.com",
                PhoneNumber = "0383557848",
                Gender = 0,
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            context.Users.Add(new Account()
            {
                Id = "US0006",
                FullName = "Nguyễn Thanh Tùng",
                UserName = "thanhtung",
                Email = "thanhtung@gmail.com",
                PhoneNumber = "0383557849",
                Gender = 0,
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            context.Users.Add(new Account()
            {
                Id = "US0007",
                FullName = "Vương Văn Hiếu",
                UserName = "vuonghieu",
                Email = "vuonghieu@gmail.com",
                PhoneNumber = "0383557810",
                Address = "Số 8, Tôn Thất Thuyết, Mỹ Đình",
                Gender = 0,
                Birthday = generateDate.ToString("MM/dd/yyyy"),
                PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
            });
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                context.Users.Add(new Account()
                {
                    Id = "EP00" + i,
                    FullName = "Employee " + i,
                    UserName = "employee" + i,
                    Email = "employee" + i + "@gmail.com",
                    PhoneNumber = "03835578" + i,
                    Gender = 0,
                    Birthday = generateDate.ToString("MM/dd/yyyy"),
                    PasswordHash = userManager.PasswordHasher.HashPassword("User@123")
                });
            }
            context.SaveChanges();

        }
        private void AddSpecifications(ApplicationDbContext context)
        {
            var date = DateTime.Now;
            context.Specifications.Add(new Specification()
            {
                Id = 1,
                Name = "Admissions",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 2,
                Name = "Construct",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 3,
                Name = "Information Technology",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 4,
                Name = "Commerce",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 5,
                Name = "Transport",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 6,
                Name = "Transport",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 7,
                Name = "Medical",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 8,
                Name = "Bank",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 9,
                Name = "Insurance",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 10,
                Name = "Real estate business",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 11,
                Name = "Hotel",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 12,
                Name = "Travel",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 13,
                Name = "Air",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Specifications.Add(new Specification()
            {
                Id = 14,
                Name = "Post and Telecommunication",
                CreatedAt = date,
                UpdateAt = date,
            });
        }
        private void AddService(ApplicationDbContext context)
        {
            var date = DateTime.Now;
            context.Services.Add(new Service()
            {
                Id = 1,
                Image = "https://res.cloudinary.com/blogcuaduc/image/upload/v1650257236/cua-toi/dpsjbxx9nmng5kumde5x.png",
                Name = "In-bound",
                Price = 4500,
                Description = "The In-bound service is a service in which one can only receive" +
                " the calls from the customers.These call centers provide 24 hours service" +
                " to all customers.The primary goal of these call centers are to receive" +
                " product orders, help customers both technically and non - technically," +
                " to find dealer location.",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Services.Add(new Service()
            {
                Id = 2,
                Image = "https://res.cloudinary.com/blogcuaduc/image/upload/v1650257236/cua-toi/gpmim7pc8nfdqha2cdwo.jpg",
                Name = "Out-bound",
                Price = 6000,
                Description = "The Out-bound service is a service in which the " +
                "employees of Excell - on call the customers for product promotions, for " +
                "checking with the customer satisfaction on the services they provide, and for " +
                "the telemarketing. Outbound Call Centers depends on the technological " +
                "solutions, extensive experience, quality assurance programs and commitment " +
                "to customer service excellence that further ensures maximum results from " +
                "the direct marketing efforts for its success.",
                CreatedAt = date,
                UpdateAt = date,
            });
            context.Services.Add(new Service()
            {
                Id = 3,
                Image = "https://res.cloudinary.com/blogcuaduc/image/upload/v1650257236/cua-toi/gwgxtvfecujbmlmcjzet.jpg",
                Name = "Tele Marketing",
                Price = 5500,
                Description = "The Tele Marketing service is a service which is " +
                "purely for the promotion of marketing or sales of the products and services.",
                CreatedAt = date,
                UpdateAt = date,
            });
        }
        private void AddRoles(ApplicationDbContext context)
        {
            context.Roles.Add(new Role()
            {
                Id = "R00001",
                Name = "ADMIN"
            });
            context.Roles.Add(new Role()
            {
                Id = "R00002",
                Name = "EMPLOYEE"
            });
            context.SaveChanges();
        }
        private void ResetAutoIncrement(ApplicationDbContext context)
        {
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Orders', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Specifications', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Services', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Contracts', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.TransactionHistories', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.OrderDetails_Employee', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.OrderDetails', RESEED, 0);");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Specification_Employee', RESEED, 0);");
        }
        private void ClearData(ApplicationDbContext context)
        {
            var transaction = context.TransactionHistories.ToList();
            foreach (var item in transaction)
            {
                context.TransactionHistories.Remove(item);
            }

            var contract = context.Contracts.ToList();
            foreach (var item in contract)
            {
                context.Contracts.Remove(item);
            }

            var spe = context.Specification_Employees.ToList();
            foreach (var item in spe)
            {
                context.Specification_Employees.Remove(item);
            }
            var OrderdetailsE = context.OrderDetails_Employees.ToList();
            foreach (var item in OrderdetailsE)
            {
                context.OrderDetails_Employees.Remove(item);
            }

            var Orderdetails = context.OrderDetails.ToList();
            foreach (var item in Orderdetails)
            {
                context.OrderDetails.Remove(item);
            }
            var Order = context.Orders.ToList();
            foreach (var item in Order)
            {
                context.Orders.Remove(item);
            }
            var Spec = context.Specifications.ToList();
            foreach (var item in Spec)
            {
                context.Specifications.Remove(item);
            }
            var Service = context.Services.ToList();
            foreach (var item in Service)
            {
                context.Services.Remove(item);
            }
            // Clear users.
            var users = context.Users.ToList();
            foreach (var item in users)
            {
                context.Users.Remove(item);
            }
            // Clear roles.
            var roles = context.Roles.ToList();
            foreach (var item in roles)
            {
                context.Roles.Remove(item);
            }
            Debug.WriteLine(roles.Count);
            context.SaveChanges();
        }
    }
}
