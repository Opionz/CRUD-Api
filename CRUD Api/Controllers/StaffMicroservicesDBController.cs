using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD_Api.Models;

namespace CRUD_Api.Controllers
{
    public class StaffMicroservicesDBController : ApiController
    {
    

        STAFFCRUDDBEntities db = new STAFFCRUDDBEntities();
        StaffMicroservices staff = new StaffMicroservices();



        // GET: api/StaffMicroservicesDB
        public IQueryable<StaffMicroservicesDB> GetStaffMicroservicesDBs()
        {
            return db.StaffMicroservicesDBs;
        }

        // GET: api/StaffMicroservicesDB/5
        [ResponseType(typeof(StaffMicroservicesDB))]
        public IHttpActionResult GetStaffMicroservicesDB(long id)
        {
            StaffMicroservicesDB staffMicroservicesDB = db.StaffMicroservicesDBs.Find(id);
            if (staffMicroservicesDB == null)
            {
                return NotFound();
            }

            return Ok(staffMicroservicesDB);
        }

        // PUT: api/StaffMicroservicesDB/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStaffMicroservicesDB(long id, StaffMicroservicesDB staffMicroservicesDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != staffMicroservicesDB.ID)
            {
                return BadRequest();
            }

            db.Entry(staffMicroservicesDB).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffMicroservicesDBExists(id))
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



        // POST: api/StaffMicroservicesDB
        [ResponseType(typeof(StaffMicroservicesDB))]
        public IHttpActionResult PostStaffMicroservicesDB(StaffMicroservicesDB staffMicroservicesDB)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StaffMicroservicesDBs.Add(staffMicroservicesDB);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (StaffMicroservicesDBExists(staffMicroservicesDB.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = staffMicroservicesDB.ID }, staffMicroservicesDB);
        }

        // DELETE: api/StaffMicroservicesDB/5
        [ResponseType(typeof(StaffMicroservicesDB))]
        public IHttpActionResult DeleteStaffMicroservicesDB(long id)
        {
            StaffMicroservicesDB staffMicroservicesDB = db.StaffMicroservicesDBs.Find(id);
            if (staffMicroservicesDB == null)
            {
                return NotFound();
            }

            db.StaffMicroservicesDBs.Remove(staffMicroservicesDB);
            db.SaveChanges();

            return Ok(staffMicroservicesDB);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StaffMicroservicesDBExists(long id)
        {
            return db.StaffMicroservicesDBs.Count(e => e.ID == id) > 0;
        }
    }
}