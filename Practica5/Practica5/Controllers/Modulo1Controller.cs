using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practica5.Models;

namespace Practica5.Controllers
{
    public class Modulo1Controller : Controller
    {
        private Practica5Modulo1 db = new Practica5Modulo1();

        // GET: Modulo1
        public ActionResult Index()
        {
            return View(db.Modulo1.ToList());
        }

        // GET: Modulo1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo1 modulo1 = db.Modulo1.Find(id);
            if (modulo1 == null)
            {
                return HttpNotFound();
            }
            return View(modulo1);
        }

        // GET: Modulo1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modulo1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDM1,Nombre,Celular,Email,Direccion")] Modulo1 modulo1)
        {
            if (ModelState.IsValid)
            {
                db.Modulo1.Add(modulo1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modulo1);
        }

        // GET: Modulo1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo1 modulo1 = db.Modulo1.Find(id);
            if (modulo1 == null)
            {
                return HttpNotFound();
            }
            return View(modulo1);
        }

        // POST: Modulo1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDM1,Nombre,Celular,Email,Direccion")] Modulo1 modulo1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modulo1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modulo1);
        }

        // GET: Modulo1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo1 modulo1 = db.Modulo1.Find(id);
            if (modulo1 == null)
            {
                return HttpNotFound();
            }
            return View(modulo1);
        }

        // POST: Modulo1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Modulo1 modulo1 = db.Modulo1.Find(id);
            db.Modulo1.Remove(modulo1);
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
