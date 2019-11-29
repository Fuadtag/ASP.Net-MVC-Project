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
    public class SuccessStoriesController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/SuccessStories
        public ActionResult Index()
        {
            return View(db.SuccessStories.ToList());
        }

        // GET: Control/SuccessStories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessStory successStory = db.SuccessStories.Find(id);
            if (successStory == null)
            {
                return HttpNotFound();
            }
            return View(successStory);
        }

        // GET: Control/SuccessStories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/SuccessStories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,Author,Position,Photo")] SuccessStory successStory)
        {
            if (ModelState.IsValid)
            {
                db.SuccessStories.Add(successStory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(successStory);
        }

        // GET: Control/SuccessStories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessStory successStory = db.SuccessStories.Find(id);
            if (successStory == null)
            {
                return HttpNotFound();
            }
            return View(successStory);
        }

        // POST: Control/SuccessStories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,Author,Position,Photo")] SuccessStory successStory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(successStory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(successStory);
        }

        // GET: Control/SuccessStories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuccessStory successStory = db.SuccessStories.Find(id);
            if (successStory == null)
            {
                return HttpNotFound();
            }
            return View(successStory);
        }

        // POST: Control/SuccessStories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuccessStory successStory = db.SuccessStories.Find(id);
            db.SuccessStories.Remove(successStory);
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
