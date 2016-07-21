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
    public class ReponsesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reponses
        public ActionResult Index(int? idQuestion,int? idReponse,int?idQuestionnaire)
        {
            if (idQuestion == null || idReponse == null || idQuestionnaire == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Questionnaire questionnaire = db.Questionnaire.Find(idQuestionnaire);
            Question question = db.Question.Find(idQuestion);
            if (questionnaire == null || question == null)
            {
                return HttpNotFound();
            }
            var reponse = db.Reponse.Include(r => r.Question);
            return View(reponse.ToList());
        }

        // GET: Reponses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reponse reponse = db.Reponse.Find(id);
            if (reponse == null)
            {
                return HttpNotFound();
            }
            return View(reponse);
        }

        // GET: Reponses/Create
        public ActionResult Create()
        {
            ViewBag.idQuestion = new SelectList(db.Question, "idQuestion", "libelleQuestion");
            return View();
        }

        // POST: Reponses/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idReponse,reponse,commentaire,idQuestion")] Reponse reponse)
        {
            if (ModelState.IsValid)
            {
                db.Reponse.Add(reponse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idQuestion = new SelectList(db.Question, "idQuestion", "libelleQuestion");
            return View(reponse);
        }

        // GET: Reponses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reponse reponse = db.Reponse.Find(id);
            if (reponse == null)
            {
                return HttpNotFound();
            }
            ViewBag.idQuestion = new SelectList(db.Question, "idQuestion", "libelleQuestion", reponse.idQuestion);
            return View(reponse);
        }

        // POST: Reponses/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idReponse,reponse,commentaire,idQuestion")] Reponse reponse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reponse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idQuestion = new SelectList(db.Question, "idQuestion", "libelleQuestion", reponse.idQuestion);
            return View(reponse);
        }

        // GET: Reponses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reponse reponse = db.Reponse.Find(id);
            if (reponse == null)
            {
                return HttpNotFound();
            }
            return View(reponse);
        }

        // POST: Reponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reponse reponse = db.Reponse.Find(id);
            db.Reponse.Remove(reponse);
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
