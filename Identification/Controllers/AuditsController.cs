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
    public class AuditsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Audits
        public ActionResult Index()
        {
            var audit = db.Audit;//.Include(a => a.Etablissement).Include(a => a.Questionnaire);
            return View(audit.ToList());
        }

        // GET: Audits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Audit audit = db.Audit.Find(id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            return View(audit);
        }

        // GET: Audits/Create
        public ActionResult Create()
        {
            ViewBag.idEtablissement = new SelectList(db.Etablissement, "idEtablissement", "libelleEtablissement");
            ViewBag.idQuestionnaire = new SelectList(db.Questionnaire, "idQuestionnaire", "libelleQuestionnaire");
            return View();
        }

        // POST: Audits/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAudit,dateAudit,libelleAudit,idEtablissement,idQuestionnaire")] Audit audit)
        {
            if (ModelState.IsValid)
            {
                db.Audit.Add(audit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idEtablissement = new SelectList(db.Etablissement, "idEtablissement", "libelleEtablissement", audit.idEtablissement);
            ViewBag.idQuestionnaire = new SelectList(db.Questionnaire, "idQuestionnaire", "libelleQuestionnaire", audit.idQuestionnaire);
            return View(audit);
        }

        // GET: Audits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Audit audit = db.Audit.Find(id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEtablissement = new SelectList(db.Etablissement, "idEtablissement", "libelleEtablissement", audit.idEtablissement);
            ViewBag.idQuestionnaire = new SelectList(db.Questionnaire, "idQuestionnaire", "libelleQuestionnaire", audit.idQuestionnaire);
            return View(audit);
        }

        // POST: Audits/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAudit,dateAudit,libelleAudit,idEtablissement,idQuestionnaire")] Audit audit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(audit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idEtablissement = new SelectList(db.Etablissement, "idEtablissement", "libelleEtablissement", audit.idEtablissement);
            ViewBag.idQuestionnaire = new SelectList(db.Questionnaire, "idQuestionnaire", "libelleQuestionnaire", audit.idQuestionnaire);
            return View(audit);
        }

        // GET: Audits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Audit audit = db.Audit.Find(id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            return View(audit);
        }

        // POST: Audits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Audit audit = db.Audit.Find(id);
            db.Audit.Remove(audit);
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
