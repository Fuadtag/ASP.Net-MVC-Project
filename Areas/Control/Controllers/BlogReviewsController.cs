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
    public class BlogReviewsController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/BlogReviews
        public ActionResult Index()
        {
            var blogReviews = db.BlogReviews.Include(b => b.Blog).Include(b => b.Candidate);
            return View(blogReviews.ToList());
        }

        // GET: Control/BlogReviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return HttpNotFound();
            }
            return View(blogReview);
        }

        // GET: Control/BlogReviews/Create
        public ActionResult Create()
        {
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Title");
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Name");
            return View();
        }

        // POST: Control/BlogReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CandidateId,BlogId,Text,CreatedAt")] BlogReview blogReview)
        {
            if (ModelState.IsValid)
            {
                db.BlogReviews.Add(blogReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Title", blogReview.BlogId);
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Name", blogReview.CandidateId);
            return View(blogReview);
        }

        // GET: Control/BlogReviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return HttpNotFound();
            }
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Title", blogReview.BlogId);
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Name", blogReview.CandidateId);
            return View(blogReview);
        }

        // POST: Control/BlogReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CandidateId,BlogId,Text,CreatedAt")] BlogReview blogReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BlogId = new SelectList(db.Blogs, "Id", "Title", blogReview.BlogId);
            ViewBag.CandidateId = new SelectList(db.Candidates, "Id", "Name", blogReview.CandidateId);
            return View(blogReview);
        }

        // GET: Control/BlogReviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogReview blogReview = db.BlogReviews.Find(id);
            if (blogReview == null)
            {
                return HttpNotFound();
            }
            return View(blogReview);
        }

        // POST: Control/BlogReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogReview blogReview = db.BlogReviews.Find(id);
            db.BlogReviews.Remove(blogReview);
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
