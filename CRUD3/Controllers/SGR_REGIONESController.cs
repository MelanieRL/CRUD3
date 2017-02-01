using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD3;

namespace CRUD3.Controllers
{
    public class SGR_REGIONESController : Controller
    {
        private BD db = new BD();

        // GET: SGR_REGIONES
        public ActionResult Index()
        {
            return View(db.SGR_REGIONES.ToList());
        }

        // GET: SGR_REGIONES/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_REGIONES sGR_REGIONES = db.SGR_REGIONES.Find(id);
            if (sGR_REGIONES == null)
            {
                return HttpNotFound();
            }
            return View(sGR_REGIONES);
        }

        // GET: SGR_REGIONES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SGR_REGIONES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_REGION,DESCRIPCION")] SGR_REGIONES sGR_REGIONES)
        {
            if (ModelState.IsValid)
            {
                db.SGR_REGIONES.Add(sGR_REGIONES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sGR_REGIONES);
        }

        // GET: SGR_REGIONES/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_REGIONES sGR_REGIONES = db.SGR_REGIONES.Find(id);
            if (sGR_REGIONES == null)
            {
                return HttpNotFound();
            }
            return View(sGR_REGIONES);
        }

        // POST: SGR_REGIONES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_REGION,DESCRIPCION")] SGR_REGIONES sGR_REGIONES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sGR_REGIONES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sGR_REGIONES);
        }

        // GET: SGR_REGIONES/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_REGIONES sGR_REGIONES = db.SGR_REGIONES.Find(id);
            if (sGR_REGIONES == null)
            {
                return HttpNotFound();
            }
            return View(sGR_REGIONES);
        }

        // POST: SGR_REGIONES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            SGR_REGIONES sGR_REGIONES = db.SGR_REGIONES.Find(id);
            db.SGR_REGIONES.Remove(sGR_REGIONES);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
