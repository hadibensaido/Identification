using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Identification.Models;
using MetierIdentification;

namespace Identification.Controllers
{
    public class QuestionnaireFormsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: QuestionnaireForms
        public ActionResult Index()
        {
            return View(db.QuestionnaireForms.ToList());
        }

        // GET: QuestionnaireForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionnaireForm questionnaireForm = db.QuestionnaireForms.Find(id);
            if (questionnaireForm == null)
            {
                return HttpNotFound();
            }
            return View(questionnaireForm);
        }

        // GET: QuestionnaireForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionnaireForms/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idQuestionnaireForm")] QuestionnaireForm questionnaireForm)
        {
            if (ModelState.IsValid)
            {
                db.QuestionnaireForms.Add(questionnaireForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionnaireForm);
        }

        // GET: QuestionnaireForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionnaireForm questionnaireForm = db.QuestionnaireForms.Find(id);
            if (questionnaireForm == null)
            {
                return HttpNotFound();
            }
            return View(questionnaireForm);
        }

        // POST: QuestionnaireForms/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idQuestionnaireForm")] QuestionnaireForm questionnaireForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionnaireForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionnaireForm);
        }

        // GET: QuestionnaireForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionnaireForm questionnaireForm = db.QuestionnaireForms.Find(id);
            if (questionnaireForm == null)
            {
                return HttpNotFound();
            }
            return View(questionnaireForm);
        }

        // POST: QuestionnaireForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionnaireForm questionnaireForm = db.QuestionnaireForms.Find(id);
            db.QuestionnaireForms.Remove(questionnaireForm);
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
