using Excell_On_Backend.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Excell_On_Backend.Controllers
{
    public class UserController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private RoleManager<Role> _roleManager;
        private UserManager<Account> _userManager;
       
        public UserController()
        {
            RoleStore<Role> roleStore = new RoleStore<Role>(db);
            _roleManager = new RoleManager<Role>(roleStore);
            UserStore<Account> userStore = new UserStore<Account>(db);
            _userManager = new UserManager<Account>(userStore);
        }
        [Route("api/User/Users")]
        [HttpGet]
        public IEnumerable<IdentityUser>GetAllUser()
        {
            return _userManager.Users.ToList();
        }
        [Route("api/User/Employee")]
        [HttpGet]
        public IEnumerable<Account> Employee()
        {
            var roleResult = _roleManager.FindByName("EMPLOYEE");
            return db.Users.Where(x => x.Roles.Any(role => role.RoleId == roleResult.Id)).ToList();
        }
        [DisableCors]
        [Route("api/User/AddEmployee")]
        [HttpPost]
        
        public async Task<IHttpActionResult> AddEmployee(EmployeeViewModel employeeViewModel)
        {
          
                try
                {
                    var dateNow = DateTime.Now;
                    Account account = new Account()
                    {
                        Avatar = employeeViewModel.Avatar,
                        FullName = employeeViewModel.FullName,
                        Gender = employeeViewModel.Gender,
                        CitizenID = employeeViewModel.CitizenID,
                        Birthday = employeeViewModel.Birthday,
                        UserName = employeeViewModel.UserName,
                        PhoneNumber = employeeViewModel.PhoneNumber,
                        Email = employeeViewModel.Email
                    };
                    var result = await _userManager.CreateAsync(account, employeeViewModel.PhoneNumber);
                    db.SaveChanges();
                    await _userManager.AddToRoleAsync(account.Id, "EMPLOYEE");
                    Specification_Employee specification_Employee = new Specification_Employee()
                    {
                        AccountID = account.Id,
                        SpecificationID = employeeViewModel.SpecificationID,
                        CreatedAt = dateNow,
                        UpdateAt = dateNow,
                    };
                    db.Specification_Employees.Add(specification_Employee);
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
        }
    }
}
