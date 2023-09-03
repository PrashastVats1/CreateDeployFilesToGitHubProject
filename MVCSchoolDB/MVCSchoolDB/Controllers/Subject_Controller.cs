using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCSchoolDB.Data;
using MVCSchoolDB.Models;

namespace MVCSchoolDB.Controllers
{
    public class Subject_Controller : Controller
    {
        private RainbowSchoolDBContext db = new RainbowSchoolDBContext();

        // GET: Subject_
        public ActionResult Index()
        {
            return View(db.Subject_.ToList());
        }

        // GET: Subject_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject_ subject_ = db.Subject_.Find(id);
            if (subject_ == null)
            {
                return HttpNotFound();
            }
            return View(subject_);
        }

        // GET: Subject_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subject_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubId,SubName,CId")] Subject_ subject_)
        {
            if (ModelState.IsValid)
            {
                db.Subject_.Add(subject_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subject_);
        }

        // GET: Subject_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject_ subject_ = db.Subject_.Find(id);
            if (subject_ == null)
            {
                return HttpNotFound();
            }
            return View(subject_);
        }

        // POST: Subject_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubId,SubName,CId")] Subject_ subject_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subject_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subject_);
        }

        // GET: Subject_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject_ subject_ = db.Subject_.Find(id);
            if (subject_ == null)
            {
                return HttpNotFound();
            }
            return View(subject_);
        }

        // POST: Subject_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subject_ subject_ = db.Subject_.Find(id);
            db.Subject_.Remove(subject_);
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
