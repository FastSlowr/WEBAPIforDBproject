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
    public class ZakazsController : ApiController
    {
        private Db db = new Db();

        // GET: api/Zakazs
        public List<ZakazD> GetZakaz()
        {
            List<ZakazD> zList = new List<ZakazD>();
            foreach (var item in db.Zakaz)
            {
                ZakazD zD = new ZakazD();
                zD.AktPriema = item.AktPriema;
                zD.AktVidachi = item.AktVidachi;
                zD.CarID = item.CarID;
                zD.Check = item.Check;
                zD.ClientID = item.ClientID;
                zD.EmplID = item.EmplID;
                zD.ZakazEnd = item.ZakazEnd;
                zD.ZakazID = item.ZakazID;
                zD.ZakazStart = item.ZakazStart;
                zList.Add(zD);
            }
            return zList;
        }

        // GET: api/Zakazs/5
        [ResponseType(typeof(Zakaz))]
        public IHttpActionResult GetZakaz(int id)
        {
            Zakaz zakaz = db.Zakaz.Find(id);
            if (zakaz == null)
            {
                return NotFound();
            }

            return Ok(zakaz);
        }

        // PUT: api/Zakazs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZakaz(int id, Zakaz zakaz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zakaz.ZakazID)
            {
                return BadRequest();
            }

            db.Entry(zakaz).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZakazExists(id))
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

        // POST: api/Zakazs
        [ResponseType(typeof(Zakaz))]
        public IHttpActionResult PostZakaz(Zakaz zakaz)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zakaz.Add(zakaz);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zakaz.ZakazID }, zakaz);
        }

        // DELETE: api/Zakazs/5
        [ResponseType(typeof(Zakaz))]
        public IHttpActionResult DeleteZakaz(int id)
        {
            Zakaz zakaz = db.Zakaz.Find(id);
            if (zakaz == null)
            {
                return NotFound();
            }

            db.Zakaz.Remove(zakaz);
            db.SaveChanges();

            return Ok(zakaz);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZakazExists(int id)
        {
            return db.Zakaz.Count(e => e.ZakazID == id) > 0;
        }
    }
}