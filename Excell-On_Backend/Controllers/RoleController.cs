using Excell_On_Backend.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Excell_On_Backend.Controllers
{
    public class RoleController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private RoleManager<Role> _roleManager;
        private UserManager<Account> _userManager;
        public RoleController()
        {
            RoleStore<Role> roleStore = new RoleStore<Role>(db);
            _roleManager = new RoleManager<Role>(roleStore);
            UserStore<Account> userStore = new UserStore<Account>(db);
            _userManager = new UserManager<Account>(userStore);
        }
        [HttpGet]
        public IEnumerable<IdentityRole> GetAll()
        {
            return _roleManager.Roles.ToList();
        }
        [HttpPost]
        public async Task<IHttpActionResult> CreateRole(RoleModel roleModel)
        {

            Role role = new Role()
            {
                Name = roleModel.Name
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
       
        [Route("api/Role/AddRoleForUser")]
        [HttpPost]
        public async Task<IHttpActionResult> RoleForUser(RoleForUserModel roleForUser)
        {
            var result = await _userManager.AddToRoleAsync(roleForUser.AccountId, roleForUser.Name);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

       

    }
}
