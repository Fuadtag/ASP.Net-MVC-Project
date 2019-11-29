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
    public class TestimonialsPhotoesController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/TestimonialsPhotoes
        public ActionResult Index()
        {
            var testimonialsPhotos = db.TestimonialsPhotos.Include(t => t.Testimonial);
            return View(testimonialsPhotos.ToList());
        }

        // GET: Control/TestimonialsPhotoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestimonialsPhoto testimonialsPhoto = db.TestimonialsPhotos.Find(id);
            if (testimonialsPhoto == null)
            {
                return HttpNotFound();
            }
            return View(testimonialsPhoto);
        }

        // GET: Control/TestimonialsPhotoes/Create
        public ActionResult Create()
        {
            ViewBag.TestimonialId = new SelectList(db.Testimonials, "Id", "Name");
            return View();
        }

        // POST: Control/TestimonialsPhotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,TestimonialId")] TestimonialsPhoto testimonialsPhoto)
        {
            if (ModelState.IsValid)
            {
                db.TestimonialsPhotos.Add(testimonialsPhoto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TestimonialId = new SelectList(db.Testimonials, "Id", "Name", testimonialsPhoto.TestimonialId);
            return View(testimonialsPhoto);
        }

        // GET: Control/TestimonialsPhotoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestimonialsPhoto testimonialsPhoto = db.TestimonialsPhotos.Find(id);
            if (testimonialsPhoto == null)
            {
                return HttpNotFound();
            }
            ViewBag.TestimonialId = new SelectList(db.Testimonials, "Id", "Name", testimonialsPhoto.TestimonialId);
            return View(testimonialsPhoto);
        }

        // POST: Control/TestimonialsPhotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,TestimonialId")] TestimonialsPhoto testimonialsPhoto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testimonialsPhoto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TestimonialId = new SelectList(db.Testimonials, "Id", "Name", testimonialsPhoto.TestimonialId);
            return View(testimonialsPhoto);
        }

        // GET: Control/TestimonialsPhotoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestimonialsPhoto testimonialsPhoto = db.TestimonialsPhotos.Find(id);
            if (testimonialsPhoto == null)
            {
                return HttpNotFound();
            }
            return View(testimonialsPhoto);
        }

        // POST: Control/TestimonialsPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestimonialsPhoto testimonialsPhoto = db.TestimonialsPhotos.Find(id);
            db.TestimonialsPhotos.Remove(testimonialsPhoto);
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
