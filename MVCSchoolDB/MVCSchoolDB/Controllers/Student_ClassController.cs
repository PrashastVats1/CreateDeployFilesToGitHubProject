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
    public class Student_ClassController : Controller
    {
        private RainbowSchoolDBContext db = new RainbowSchoolDBContext();

        // GET: Student_Class
        public ActionResult Index()
        {
            var student_Class = db.Student_Class.Include(s => s.Subject_);
            return View(student_Class.ToList());
        }

        // GET: Student_Class/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Class student_Class = db.Student_Class.Find(id);
            if (student_Class == null)
            {
                return HttpNotFound();
            }
            return View(student_Class);
        }

        // GET: Student_Class/Create
        public ActionResult Create()
        {
            ViewBag.SubId = new SelectList(db.Subject_, "SubId", "SubName");
            return View();
        }

        // POST: Student_Class/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FName,LName,CId,SubId")] Student_Class student_Class)
        {
            if (ModelState.IsValid)
            {
                db.Student_Class.Add(student_Class);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SubId = new SelectList(db.Subject_, "SubId", "SubName", student_Class.SubId);
            return View(student_Class);
        }

        // GET: Student_Class/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Class student_Class = db.Student_Class.Find(id);
            if (student_Class == null)
            {
                return HttpNotFound();
            }
            ViewBag.SubId = new SelectList(db.Subject_, "SubId", "SubName", student_Class.SubId);
            return View(student_Class);
        }

        // POST: Student_Class/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FName,LName,CId,SubId")] Student_Class student_Class)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Class).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SubId = new SelectList(db.Subject_, "SubId", "SubName", student_Class.SubId);
            return View(student_Class);
        }

        // GET: Student_Class/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Class student_Class = db.Student_Class.Find(id);
            if (student_Class == null)
            {
                return HttpNotFound();
            }
            return View(student_Class);
        }

        // POST: Student_Class/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_Class student_Class = db.Student_Class.Find(id);
            db.Student_Class.Remove(student_Class);
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
