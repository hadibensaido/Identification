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
    public class QuestionnairesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Questionnaires
        public ActionResult Index()
        {
            var questionnaire = db.Questionnaire.Include(q => q.TypeQuestionnaire);
            return View(questionnaire.ToList());
        }

        // GET: Questionnaires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionnaire questionnaire = db.Questionnaire.Find(id);
            if (questionnaire == null)
            {
                return HttpNotFound();
            }
            return View(questionnaire);
        }

        // GET: Questionnaires/Create
        public ActionResult Create()
        {
            ViewBag.idType = new SelectList(db.TypeQuestionnaire, "idType", "libelleType");
            return View();
        }

        // POST: Questionnaires/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idQuestionnaire,libelleQuestionnaire,idType")] Questionnaire questionnaire)
        {
            if (ModelState.IsValid)
            {
                db.Questionnaire.Add(questionnaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idType = new SelectList(db.TypeQuestionnaire, "idType", "libelleType", questionnaire.idType);
            return View(questionnaire);
        }

        // GET: Questionnaires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionnaire questionnaire = db.Questionnaire.Find(id);
            if (questionnaire == null)
            {
                return HttpNotFound();
            }
            ViewBag.idType = new SelectList(db.TypeQuestionnaire, "idType", "libelleType", questionnaire.idType);
            return View(questionnaire);
        }

        // POST: Questionnaires/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idQuestionnaire,libelleQuestionnaire,idType")] Questionnaire questionnaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionnaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idType = new SelectList(db.TypeQuestionnaire, "idType", "libelleType", questionnaire.idType);
            return View(questionnaire);
        }

        // GET: Questionnaires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionnaire questionnaire = db.Questionnaire.Find(id);
            if (questionnaire == null)
            {
                return HttpNotFound();
            }
            return View(questionnaire);
        }

        // POST: Questionnaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Questionnaire questionnaire = db.Questionnaire.Find(id);
            db.Questionnaire.Remove(questionnaire);
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
