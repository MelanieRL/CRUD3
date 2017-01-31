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
    public class SGR_COMUNASController : Controller
    {
        private BD db = new BD();

        // GET: SGR_COMUNAS
        public ActionResult Index()
        {
            var sGR_COMUNAS = db.SGR_COMUNAS.Include(s => s.SGR_PROVINCIAS);
            return View(sGR_COMUNAS.ToList());
        }

        // GET: SGR_COMUNAS/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_COMUNAS sGR_COMUNAS = db.SGR_COMUNAS.Find(id);
            if (sGR_COMUNAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_COMUNAS);
        }

        // GET: SGR_COMUNAS/Create
        public ActionResult Create()
        {
            ViewBag.ID_PROVINCIA = new SelectList(db.SGR_PROVINCIAS, "ID_PROVINCIA", "DESCRIPCION");
            return View();
        }

        // POST: SGR_COMUNAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_COMUNA,ID_PROVINCIA,DESCRIPCION")] SGR_COMUNAS sGR_COMUNAS)
        {
            if (ModelState.IsValid)
            {
                db.SGR_COMUNAS.Add(sGR_COMUNAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_PROVINCIA = new SelectList(db.SGR_PROVINCIAS, "ID_PROVINCIA", "DESCRIPCION", sGR_COMUNAS.ID_PROVINCIA);
            return View(sGR_COMUNAS);
        }

        // GET: SGR_COMUNAS/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_COMUNAS sGR_COMUNAS = db.SGR_COMUNAS.Find(id);
            if (sGR_COMUNAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_PROVINCIA = new SelectList(db.SGR_PROVINCIAS, "ID_PROVINCIA", "DESCRIPCION", sGR_COMUNAS.ID_PROVINCIA);
            return View(sGR_COMUNAS);
        }

        // POST: SGR_COMUNAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_COMUNA,ID_PROVINCIA,DESCRIPCION")] SGR_COMUNAS sGR_COMUNAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sGR_COMUNAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_PROVINCIA = new SelectList(db.SGR_PROVINCIAS, "ID_PROVINCIA", "DESCRIPCION", sGR_COMUNAS.ID_PROVINCIA);
            return View(sGR_COMUNAS);
        }

        // GET: SGR_COMUNAS/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_COMUNAS sGR_COMUNAS = db.SGR_COMUNAS.Find(id);
            if (sGR_COMUNAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_COMUNAS);
        }

        // POST: SGR_COMUNAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            SGR_COMUNAS sGR_COMUNAS = db.SGR_COMUNAS.Find(id);
            db.SGR_COMUNAS.Remove(sGR_COMUNAS);
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
