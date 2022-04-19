using Excell_On_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Excell_On_Backend.Controllers
{
    public class ContractController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<Contract> GetAll()
        {
            return db.Contracts;
        }
    }
}
