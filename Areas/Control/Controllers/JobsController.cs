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
    public class JobsController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/Jobs
        public ActionResult Index()
        {
            var jobs = db.Jobs.Include(j => j.Category).Include(j => j.Company).Include(j => j.Country);
            return View(jobs.ToList());
        }

        // GET: Control/Jobs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: Control/Jobs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name");
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name");
            return View();
        }

        // POST: Control/Jobs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,TitleText,EmailAdress,WebSite,JobType,City,CountryId,MinSalary,MaxSalary,Shift,CreatedAt,CompanyId,CategoryId,Notes,Experience,Description,Gender,IsAcceptedByAdmin")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Jobs.Add(job);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", job.CategoryId);
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", job.CompanyId);
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", job.CountryId);
            return View(job);
        }

        // GET: Control/Jobs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", job.CategoryId);
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", job.CompanyId);
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", job.CountryId);
            return View(job);
        }

        // POST: Control/Jobs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,TitleText,EmailAdress,WebSite,JobType,City,CountryId,MinSalary,MaxSalary,Shift,CreatedAt,CompanyId,CategoryId,Notes,Experience,Description,Gender,IsAcceptedByAdmin")] Job job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", job.CategoryId);
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", job.CompanyId);
            ViewBag.CountryId = new SelectList(db.Countries, "Id", "Name", job.CountryId);
            return View(job);
        }

        // GET: Control/Jobs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = db.Jobs.Find(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: Control/Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = db.Jobs.Find(id);
            db.Jobs.Remove(job);
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
