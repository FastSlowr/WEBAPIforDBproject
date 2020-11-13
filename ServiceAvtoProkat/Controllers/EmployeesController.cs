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
using ServiceAvtoProkat;

namespace ServiceAvtoProkat.Controllers
{
    public class EmployeesController : ApiController
    {
        private Db db = new Db();

        // GET: api/Employees
        public List<EmployeeD> GetEmployee()
        {
            List<EmployeeD> eList = new List<EmployeeD>();
            foreach (var item in db.Employee)
            {
                EmployeeD eD = new EmployeeD();
                eD.EmplID = item.EmplID;
                eD.EmplName = item.EmplName;
                eD.EmplTel = item.EmplTel;
                eD.PostID = item.PostID;
                eList.Add(eD);
            }
            return eList;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee item = db.Employee.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            EmployeeD eD = new EmployeeD();
            eD.EmplID = item.EmplID;
            eD.EmplName = item.EmplName;
            eD.EmplTel = item.EmplTel;
            eD.PostID = item.PostID;

            return Ok(eD);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EmplID)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employee.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.EmplID }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employee.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employee.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employee.Count(e => e.EmplID == id) > 0;
        }
    }
}