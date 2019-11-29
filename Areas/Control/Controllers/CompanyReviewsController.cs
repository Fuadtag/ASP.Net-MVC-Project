using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetFinalProject.Data;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.Areas.Control.Controllers
{
    public class CompanyReviewsController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/CompanyReviews
        public ActionResult Index()
        {
            var companyReviews = db.CompanyReviews.Include(c => c.Company).Include(c => c.Employee);
            return View(companyReviews.ToList());
        }

        // GET: Control/CompanyReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyReview companyReview = db.CompanyReviews.Find(id);
            if (companyReview == null)
            {
                return HttpNotFound();
            }
            return View(companyReview);
        }

        // GET: Control/CompanyReviews/Create
        public ActionResult Create()
        {
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name");
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name");
            return View();
        }

        // POST: Control/CompanyReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CompanyId,EmployeeId,CreatedAt,Text")] CompanyReview companyReview)
        {
            if (ModelState.IsValid)
            {
                db.CompanyReviews.Add(companyReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", companyReview.CompanyId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", companyReview.EmployeeId);
            return View(companyReview);
        }

        // GET: Control/CompanyReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyReview companyReview = db.CompanyReviews.Find(id);
            if (companyReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", companyReview.CompanyId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", companyReview.EmployeeId);
            return View(companyReview);
        }

        // POST: Control/CompanyReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CompanyId,EmployeeId,CreatedAt,Text")] CompanyReview companyReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", companyReview.CompanyId);
            ViewBag.EmployeeId = new SelectList(db.Employees, "Id", "Name", companyReview.EmployeeId);
            return View(companyReview);
        }

        // GET: Control/CompanyReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyReview companyReview = db.CompanyReviews.Find(id);
            if (companyReview == null)
            {
                return HttpNotFound();
            }
            return View(companyReview);
        }

        // POST: Control/CompanyReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyReview companyReview = db.CompanyReviews.Find(id);
            db.CompanyReviews.Remove(companyReview);
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
