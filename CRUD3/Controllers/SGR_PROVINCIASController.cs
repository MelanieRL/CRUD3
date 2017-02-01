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
    public class SGR_PROVINCIASController : Controller
    {
        private BD db = new BD();

        // GET: SGR_PROVINCIAS
        public ActionResult Index()
        {
            var sGR_PROVINCIAS = db.SGR_PROVINCIAS.Include(s => s.SGR_REGIONES);
            return View(sGR_PROVINCIAS.ToList());
        }

        // GET: SGR_PROVINCIAS/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PROVINCIAS sGR_PROVINCIAS = db.SGR_PROVINCIAS.Find(id);
            if (sGR_PROVINCIAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_PROVINCIAS);
        }

        // GET: SGR_PROVINCIAS/Create
        public ActionResult Create()
        {
            ViewBag.ID_REGION = new SelectList(db.SGR_REGIONES, "ID_REGION", "DESCRIPCION");
            return View();
        }

        // POST: SGR_PROVINCIAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PROVINCIA,ID_REGION,DESCRIPCION")] SGR_PROVINCIAS sGR_PROVINCIAS)
        {
            if (ModelState.IsValid)
            {
                db.SGR_PROVINCIAS.Add(sGR_PROVINCIAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_REGION = new SelectList(db.SGR_REGIONES, "ID_REGION", "DESCRIPCION", sGR_PROVINCIAS.ID_REGION);
            return View(sGR_PROVINCIAS);
        }

        // GET: SGR_PROVINCIAS/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PROVINCIAS sGR_PROVINCIAS = db.SGR_PROVINCIAS.Find(id);
            if (sGR_PROVINCIAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_REGION = new SelectList(db.SGR_REGIONES, "ID_REGION", "DESCRIPCION", sGR_PROVINCIAS.ID_REGION);
            return View(sGR_PROVINCIAS);
        }

        // POST: SGR_PROVINCIAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PROVINCIA,ID_REGION,DESCRIPCION")] SGR_PROVINCIAS sGR_PROVINCIAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sGR_PROVINCIAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_REGION = new SelectList(db.SGR_REGIONES, "ID_REGION", "DESCRIPCION", sGR_PROVINCIAS.ID_REGION);
            return View(sGR_PROVINCIAS);
        }

        // GET: SGR_PROVINCIAS/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PROVINCIAS sGR_PROVINCIAS = db.SGR_PROVINCIAS.Find(id);
            if (sGR_PROVINCIAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_PROVINCIAS);
        }

        // POST: SGR_PROVINCIAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            SGR_PROVINCIAS sGR_PROVINCIAS = db.SGR_PROVINCIAS.Find(id);
            db.SGR_PROVINCIAS.Remove(sGR_PROVINCIAS);
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
