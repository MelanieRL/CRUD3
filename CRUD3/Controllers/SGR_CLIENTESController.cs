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
    public class SGR_CLIENTESController : Controller
    {
        private BD db = new BD();

        // GET: SGR_CLIENTES
        public ActionResult Index()
        {
            var sGR_CLIENTES = db.SGR_CLIENTES.Include(s => s.SGR_PLANTAS).Include(s => s.SGR_EMPRESAS).Include(s => s.SGR_COMUNAS).Include(s => s.SGR_TIPOS_CLIENTE).Include(s => s.SGR_ESTADOS_CLIENTE).Include(s => s.SGR_TIPOS_CALC_EXC).Include(s => s.SGR_TIPOS_SIST_TRAT).Include(s => s.SGR_FRECUENCIAS_MUES);
            return View(sGR_CLIENTES.ToList());
        }

        // GET: SGR_CLIENTES/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_CLIENTES sGR_CLIENTES = db.SGR_CLIENTES.Find(id);
            if (sGR_CLIENTES == null)
            {
                return HttpNotFound();
            }
            return View(sGR_CLIENTES);
        }

        // GET: SGR_CLIENTES/Create
        public ActionResult Create()
        {
            ViewBag.ID_PLANTA = new SelectList(db.SGR_PLANTAS, "ID_PLANTA", "COD_SISS");
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA");
            ViewBag.ID_COMUNA = new SelectList(db.SGR_COMUNAS, "ID_COMUNA", "DESCRIPCION");
            ViewBag.ID_TIPO_CLIENTE = new SelectList(db.SGR_TIPOS_CLIENTE, "ID_TIPO_CLIENTE", "DESCRIPCION");
            ViewBag.ID_ESTADO_CLIENTE = new SelectList(db.SGR_ESTADOS_CLIENTE, "ID_ESTADO_CLIENTE", "DESCRIPCION");
            ViewBag.ID_TIPO_CALCULO = new SelectList(db.SGR_TIPOS_CALC_EXC, "ID_TIPO_CALCULO", "DESCRIPCION");
            ViewBag.ID_TIPO_SIST_TRATAMI = new SelectList(db.SGR_TIPOS_SIST_TRAT, "ID_TIPO_SIST_TRATAMI", "DESCRIPCION");
            ViewBag.ID_FREC_MUESTREO = new SelectList(db.SGR_FRECUENCIAS_MUES, "ID_FREC_MUESTREO", "DESCRIPCION");
            return View();
        }

        // POST: SGR_CLIENTES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SGR,ID_RUBRO,ID_EMPRESA,RUT_CLIENTE,NOMBRE_CLIENTE,REP_LEGAL,RUT_REP_LEGAL,DV_REP_LEGAL,ID_SISS,ID_PLANTA,NOMBRE_FANTASIA,ID_TIPO_CLIENTE,ID_ESTADO_CLIENTE,ID_COMUNA,ID_CONTRATO,ID_TIPO_CALCULO,DIRECCION,SECTOR,FONO,FAX,CASILLA_POSTAL,CODIGO_POSTAL,CONTACTO1,RUT_CONTACTO1,EMAIL_CONTACTO1,FONO_CONTACTO1,CONTACTO2,RUT_CONTACTO2,EMAIL_CONTACTO2,FONO_CONTACTO2,CONTACTO_RILES,RUT_CONTACTO_RILES,EMAIL_CONTACTO_RILES,FONO_CONTACTO_RILES,IDENT_CONCES_DGA_RILES,NRO_RCA,ANO_RCA,CONV_DGA_DSMOP,ID_TIPO_SIST_TRATAMI,FECHA_ENT_OPER_RILES,VOLUMEN_DESCARGA,NRO_DESCARGAS,RPM,NRO_RPM,ID_FREC_MUESTREO,LINK_RPM,FECHA_T4_RPM,ID_CON_DIRECTO,ID_CON_CONVENIO,ID_CON_OPERATIVO,ID_EXCEDENTES,ID_DGA_RILES,ID_DGA_AS,ID_DGA_RESIDUOS,CAMPO_F_1,CAMPO_F_2,CAMPO_F_3,CAMPO_F_4,CAMPO_F_5,GIRO,RAZON_SOCIAL")] SGR_CLIENTES sGR_CLIENTES)
        {
            if (ModelState.IsValid)
            {
                db.SGR_CLIENTES.Add(sGR_CLIENTES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_PLANTA = new SelectList(db.SGR_PLANTAS, "ID_PLANTA", "COD_SISS", sGR_CLIENTES.ID_PLANTA);
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_CLIENTES.ID_EMPRESA);
            ViewBag.ID_COMUNA = new SelectList(db.SGR_COMUNAS, "ID_COMUNA", "DESCRIPCION", sGR_CLIENTES.ID_COMUNA);
            ViewBag.ID_TIPO_CLIENTE = new SelectList(db.SGR_TIPOS_CLIENTE, "ID_TIPO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CLIENTE);
            ViewBag.ID_ESTADO_CLIENTE = new SelectList(db.SGR_ESTADOS_CLIENTE, "ID_ESTADO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_ESTADO_CLIENTE);
            ViewBag.ID_TIPO_CALCULO = new SelectList(db.SGR_TIPOS_CALC_EXC, "ID_TIPO_CALCULO", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CALCULO);
            ViewBag.ID_TIPO_SIST_TRATAMI = new SelectList(db.SGR_TIPOS_SIST_TRAT, "ID_TIPO_SIST_TRATAMI", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_SIST_TRATAMI);
            ViewBag.ID_FREC_MUESTREO = new SelectList(db.SGR_FRECUENCIAS_MUES, "ID_FREC_MUESTREO", "DESCRIPCION", sGR_CLIENTES.ID_FREC_MUESTREO);
            return View(sGR_CLIENTES);
        }

        // GET: SGR_CLIENTES/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_CLIENTES sGR_CLIENTES = db.SGR_CLIENTES.Find(id);
            if (sGR_CLIENTES == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_PLANTA = new SelectList(db.SGR_PLANTAS, "ID_PLANTA", "COD_SISS", sGR_CLIENTES.ID_PLANTA);
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_CLIENTES.ID_EMPRESA);
            ViewBag.ID_COMUNA = new SelectList(db.SGR_COMUNAS, "ID_COMUNA", "DESCRIPCION", sGR_CLIENTES.ID_COMUNA);
            ViewBag.ID_TIPO_CLIENTE = new SelectList(db.SGR_TIPOS_CLIENTE, "ID_TIPO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CLIENTE);
            ViewBag.ID_ESTADO_CLIENTE = new SelectList(db.SGR_ESTADOS_CLIENTE, "ID_ESTADO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_ESTADO_CLIENTE);
            ViewBag.ID_TIPO_CALCULO = new SelectList(db.SGR_TIPOS_CALC_EXC, "ID_TIPO_CALCULO", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CALCULO);
            ViewBag.ID_TIPO_SIST_TRATAMI = new SelectList(db.SGR_TIPOS_SIST_TRAT, "ID_TIPO_SIST_TRATAMI", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_SIST_TRATAMI);
            ViewBag.ID_FREC_MUESTREO = new SelectList(db.SGR_FRECUENCIAS_MUES, "ID_FREC_MUESTREO", "DESCRIPCION", sGR_CLIENTES.ID_FREC_MUESTREO);
            return View(sGR_CLIENTES);
        }

        // POST: SGR_CLIENTES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SGR,ID_RUBRO,ID_EMPRESA,RUT_CLIENTE,NOMBRE_CLIENTE,REP_LEGAL,RUT_REP_LEGAL,DV_REP_LEGAL,ID_SISS,ID_PLANTA,NOMBRE_FANTASIA,ID_TIPO_CLIENTE,ID_ESTADO_CLIENTE,ID_COMUNA,ID_CONTRATO,ID_TIPO_CALCULO,DIRECCION,SECTOR,FONO,FAX,CASILLA_POSTAL,CODIGO_POSTAL,CONTACTO1,RUT_CONTACTO1,EMAIL_CONTACTO1,FONO_CONTACTO1,CONTACTO2,RUT_CONTACTO2,EMAIL_CONTACTO2,FONO_CONTACTO2,CONTACTO_RILES,RUT_CONTACTO_RILES,EMAIL_CONTACTO_RILES,FONO_CONTACTO_RILES,IDENT_CONCES_DGA_RILES,NRO_RCA,ANO_RCA,CONV_DGA_DSMOP,ID_TIPO_SIST_TRATAMI,FECHA_ENT_OPER_RILES,VOLUMEN_DESCARGA,NRO_DESCARGAS,RPM,NRO_RPM,ID_FREC_MUESTREO,LINK_RPM,FECHA_T4_RPM,ID_CON_DIRECTO,ID_CON_CONVENIO,ID_CON_OPERATIVO,ID_EXCEDENTES,ID_DGA_RILES,ID_DGA_AS,ID_DGA_RESIDUOS,CAMPO_F_1,CAMPO_F_2,CAMPO_F_3,CAMPO_F_4,CAMPO_F_5,GIRO,RAZON_SOCIAL")] SGR_CLIENTES sGR_CLIENTES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sGR_CLIENTES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_PLANTA = new SelectList(db.SGR_PLANTAS, "ID_PLANTA", "COD_SISS", sGR_CLIENTES.ID_PLANTA);
            ViewBag.ID_EMPRESA = new SelectList(db.SGR_EMPRESAS, "ID_EMPRESA", "NOMBRE_EMPRESA", sGR_CLIENTES.ID_EMPRESA);
            ViewBag.ID_COMUNA = new SelectList(db.SGR_COMUNAS, "ID_COMUNA", "DESCRIPCION", sGR_CLIENTES.ID_COMUNA);
            ViewBag.ID_TIPO_CLIENTE = new SelectList(db.SGR_TIPOS_CLIENTE, "ID_TIPO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CLIENTE);
            ViewBag.ID_ESTADO_CLIENTE = new SelectList(db.SGR_ESTADOS_CLIENTE, "ID_ESTADO_CLIENTE", "DESCRIPCION", sGR_CLIENTES.ID_ESTADO_CLIENTE);
            ViewBag.ID_TIPO_CALCULO = new SelectList(db.SGR_TIPOS_CALC_EXC, "ID_TIPO_CALCULO", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_CALCULO);
            ViewBag.ID_TIPO_SIST_TRATAMI = new SelectList(db.SGR_TIPOS_SIST_TRAT, "ID_TIPO_SIST_TRATAMI", "DESCRIPCION", sGR_CLIENTES.ID_TIPO_SIST_TRATAMI);
            ViewBag.ID_FREC_MUESTREO = new SelectList(db.SGR_FRECUENCIAS_MUES, "ID_FREC_MUESTREO", "DESCRIPCION", sGR_CLIENTES.ID_FREC_MUESTREO);
            return View(sGR_CLIENTES);
        }

        // GET: SGR_CLIENTES/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SGR_CLIENTES sGR_CLIENTES = db.SGR_CLIENTES.Find(id);
            if (sGR_CLIENTES == null)
            {
                return HttpNotFound();
            }
            return View(sGR_CLIENTES);
        }

        // POST: SGR_CLIENTES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            SGR_CLIENTES sGR_CLIENTES = db.SGR_CLIENTES.Find(id);
            db.SGR_CLIENTES.Remove(sGR_CLIENTES);
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
