using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Identification.Models;
using MetierIdentification.Models;

namespace Identification.Controllers
{
    public class PrestationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prestations
        public ActionResult Index()
        {
            return View(db.Prestations.ToList());
        }

        // GET: Prestations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestations prestations = db.Prestations.Find(id);
            if (prestations == null)
            {
                return HttpNotFound();
            }
            return View(prestations);
        }

        // GET: Prestations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prestations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPrestation,datePrestation")] Prestations prestations)
        {
            if (ModelState.IsValid)
            {
                db.Prestations.Add(prestations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestations);
        }

        // GET: Prestations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestations prestations = db.Prestations.Find(id);
            if (prestations == null)
            {
                return HttpNotFound();
            }
            return View(prestations);
        }

        // POST: Prestations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPrestation,datePrestation")] Prestations prestations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestations);
        }

        // GET: Prestations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestations prestations = db.Prestations.Find(id);
            if (prestations == null)
            {
                return HttpNotFound();
            }
            return View(prestations);
        }

        // POST: Prestations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prestations prestations = db.Prestations.Find(id);
            db.Prestations.Remove(prestations);
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
