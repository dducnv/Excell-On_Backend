using Excell_On_Backend.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Excell_On_Backend.Controllers
{
    public class OrderController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IEnumerable<Order> GetAll()
        {
            return db.Orders;
        }
    
    }
}
