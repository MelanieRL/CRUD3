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
    public class SGR_PLANTASController : Controller
    {asdasdasd
        private BD db = new BD();

        // GET: SGR_PLANTAS
        public ActionResult Index()
        {
            var sGR_PLANTAS = db.SGR_PLANTAS.Include(s => s.SGR_EMPRESAS).Include(s => s.SGR_LOCALIDADES);
            return View(sGR_PLANTAS.ToList());
        }

        // GET: SGR_PLANTAS/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PLANTAS sGR_PLANTAS = db.SGR_PLANTAS.Find(id);
            if (sGR_PLANTAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_PLANTAS);
        }

        // GET: SGR_PLANTAS/Create
        public ActionResult Create()
        {
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA");
            ViewBag.ID_LOCALIDAD = new SelectList(db.SGR_LOCALIDADES, "ID_LOCALIDAD", "NOMBRE");
            return View();
        }

        // POST: SGR_PLANTAS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PLANTA,ID_EMPRESA,COD_SISS,DESCRIPCION,ID_LOCALIDAD,FECHA_OPERACION,ACTIVO")] SGR_PLANTAS sGR_PLANTAS)
        {
            if (ModelState.IsValid)
            {
                db.SGR_PLANTAS.Add(sGR_PLANTAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_PLANTAS.ID_EMPRESA);
            ViewBag.ID_LOCALIDAD = new SelectList(db.SGR_LOCALIDADES, "ID_LOCALIDAD", "NOMBRE", sGR_PLANTAS.ID_LOCALIDAD);
            return View(sGR_PLANTAS);
        }

        // GET: SGR_PLANTAS/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PLANTAS sGR_PLANTAS = db.SGR_PLANTAS.Find(id);
            if (sGR_PLANTAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_PLANTAS.ID_EMPRESA);
            ViewBag.ID_LOCALIDAD = new SelectList(db.SGR_LOCALIDADES, "ID_LOCALIDAD", "NOMBRE", sGR_PLANTAS.ID_LOCALIDAD);
            return View(sGR_PLANTAS);
        }

        // POST: SGR_PLANTAS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PLANTA,ID_EMPRESA,COD_SISS,DESCRIPCION,ID_LOCALIDAD,FECHA_OPERACION,ACTIVO")] SGR_PLANTAS sGR_PLANTAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sGR_PLANTAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_PLANTAS.ID_EMPRESA);
            ViewBag.ID_LOCALIDAD = new SelectList(db.SGR_LOCALIDADES, "ID_LOCALIDAD", "NOMBRE", sGR_PLANTAS.ID_LOCALIDAD);
            return View(sGR_PLANTAS);
        }

        // GET: SGR_PLANTAS/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_PLANTAS sGR_PLANTAS = db.SGR_PLANTAS.Find(id);
            if (sGR_PLANTAS == null)
            {
                return HttpNotFound();
            }
            return View(sGR_PLANTAS);
        }

        // POST: SGR_PLANTAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            SGR_PLANTAS sGR_PLANTAS = db.SGR_PLANTAS.Find(id);
            db.SGR_PLANTAS.Remove(sGR_PLANTAS);
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
