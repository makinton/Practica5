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
    public class Modulo2Controller : Controller
    {
        private Practica5Modulo2 db = new Practica5Modulo2();

        // GET: Modulo2
        public ActionResult Index()
        {
            return View(db.Modulo2.ToList());
        }

        // GET: Modulo2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo2 modulo2 = db.Modulo2.Find(id);
            if (modulo2 == null)
            {
                return HttpNotFound();
            }
            return View(modulo2);
        }

        // GET: Modulo2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modulo2/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDEvento,Evento,FechaHora")] Modulo2 modulo2)
        {
            if (ModelState.IsValid)
            {
                db.Modulo2.Add(modulo2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modulo2);
        }

        // GET: Modulo2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo2 modulo2 = db.Modulo2.Find(id);
            if (modulo2 == null)
            {
                return HttpNotFound();
            }
            return View(modulo2);
        }

        // POST: Modulo2/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDEvento,Evento,FechaHora")] Modulo2 modulo2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modulo2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modulo2);
        }

        // GET: Modulo2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Modulo2 modulo2 = db.Modulo2.Find(id);
            if (modulo2 == null)
            {
                return HttpNotFound();
            }
            return View(modulo2);
        }

        // POST: Modulo2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Modulo2 modulo2 = db.Modulo2.Find(id);
            db.Modulo2.Remove(modulo2);
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
