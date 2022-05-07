using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Excell_On_Backend.Models;

namespace Excell_On_Backend.Controllers
{
    public class SpecificationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Specifications
        public IEnumerable<Specification> GetSpecifications()
        {
            return db.Specifications.ToList();
        }
        // GET: api/Specifications/5
        [ResponseType(typeof(Specification))]
        public async Task<IHttpActionResult> GetSpecification(int id)
        {
            Specification specification = await db.Specifications.FindAsync(id);
            if (specification == null)
            {
                return NotFound();
            }

            return Ok(specification);
        }

        // PUT: api/Specifications/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSpecification(int id, Specification specification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != specification.Id)
            {
                return BadRequest();
            }

            db.Entry(specification).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecificationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Specifications
        [ResponseType(typeof(Specification))]
        public async Task<IHttpActionResult> PostSpecification(Specification specification)
        {
            var dateNow = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Specification specificationModel = new Specification()
            {
                Name = specification.Name,
                CreatedAt = dateNow,
                UpdateAt = dateNow

            };
            db.Specifications.Add(specificationModel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = specification.Id }, specification);
        }

        // DELETE: api/Specifications/5
        [ResponseType(typeof(Specification))]
        public async Task<IHttpActionResult> DeleteSpecification(int id)
        {
            Specification specification = await db.Specifications.FindAsync(id);
            if (specification == null)
            {
                return NotFound();
            }

            db.Specifications.Remove(specification);
            await db.SaveChangesAsync();

            return Ok(specification);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SpecificationExists(int id)
        {
            return db.Specifications.Count(e => e.Id == id) > 0;
        }
    }
}