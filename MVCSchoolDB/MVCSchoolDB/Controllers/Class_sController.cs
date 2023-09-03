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
    public class Class_sController : Controller
    {
        private RainbowSchoolDBContext db = new RainbowSchoolDBContext();

        // GET: Class_s
        public ActionResult Index()
        {
            return View(db.Class_.ToList());
        }

        // GET: Class_s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_ class_ = db.Class_.Find(id);
            if (class_ == null)
            {
                return HttpNotFound();
            }
            return View(class_);
        }

        // GET: Class_s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class_s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClassId,CName")] Class_ class_)
        {
            if (ModelState.IsValid)
            {
                db.Class_.Add(class_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(class_);
        }

        // GET: Class_s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_ class_ = db.Class_.Find(id);
            if (class_ == null)
            {
                return HttpNotFound();
            }
            return View(class_);
        }

        // POST: Class_s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClassId,CName")] Class_ class_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(class_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(class_);
        }

        // GET: Class_s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Class_ class_ = db.Class_.Find(id);
            if (class_ == null)
            {
                return HttpNotFound();
            }
            return View(class_);
        }

        // POST: Class_s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Class_ class_ = db.Class_.Find(id);
            db.Class_.Remove(class_);
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
