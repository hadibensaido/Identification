﻿using System;
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
    public class ProfilsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Profils
        public ActionResult Index()
        {
            try
            {
                return View(db.Profils.ToList());
            }
            catch (ArgumentNullException)
            {

                throw;
            }
        }

        // GET: Profils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profil profil = db.Profils.Find(id);
            if (profil == null)
            {
                return HttpNotFound();
            }
            return View(profil);
        }

        // GET: Profils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profils/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProfil,libelleProfil")] Profil profil)
        {
            if (ModelState.IsValid)
            {
                db.Profils.Add(profil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profil);
        }

        // GET: Profils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profil profil = db.Profils.Find(id);
            if (profil == null)
            {
                return HttpNotFound();
            }
            return View(profil);
        }

        // POST: Profils/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idProfil,libelleProfil")] Profil profil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profil);
        }

        // GET: Profils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profil profil = db.Profils.Find(id);
            if (profil == null)
            {
                return HttpNotFound();
            }
            return View(profil);
        }

        // POST: Profils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profil profil = db.Profils.Find(id);
            db.Profils.Remove(profil);
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
