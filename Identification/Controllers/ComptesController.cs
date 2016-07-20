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
    public class ComptesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Comptes
        public ActionResult Index()
        {
            try
            {
                return View(db.Compte.ToList());
            }
            catch (ArgumentNullException)
            {

                throw;
            }
        }

        // GET: Comptes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compte compte = db.Compte.Find(id);
            if (compte == null)
            {
                return HttpNotFound();
            }
            return View(compte);
        }

        // GET: Comptes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comptes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCompte,libelleCompte")] Compte compte)
        {
            if (ModelState.IsValid)
            {
                db.Compte.Add(compte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compte);
        }

        // GET: Comptes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compte compte = db.Compte.Find(id);
            if (compte == null)
            {
                return HttpNotFound();
            }
            return View(compte);
        }

        // POST: Comptes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCompte,libelleCompte")] Compte compte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compte);
        }

        // GET: Comptes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compte compte = db.Compte.Find(id);
            if (compte == null)
            {
                return HttpNotFound();
            }
            return View(compte);
        }

        // POST: Comptes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compte compte = db.Compte.Find(id);
            db.Compte.Remove(compte);
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
