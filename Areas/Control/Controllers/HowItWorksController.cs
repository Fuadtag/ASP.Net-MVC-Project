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
    public class HowItWorksController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/HowItWorks
        public ActionResult Index()
        {
            return View(db.HowItWorks.ToList());
        }

        // GET: Control/HowItWorks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HowItWork howItWork = db.HowItWorks.Find(id);
            if (howItWork == null)
            {
                return HttpNotFound();
            }
            return View(howItWork);
        }

        // GET: Control/HowItWorks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/HowItWorks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text,Photo")] HowItWork howItWork)
        {
            if (ModelState.IsValid)
            {
                db.HowItWorks.Add(howItWork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(howItWork);
        }

        // GET: Control/HowItWorks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HowItWork howItWork = db.HowItWorks.Find(id);
            if (howItWork == null)
            {
                return HttpNotFound();
            }
            return View(howItWork);
        }

        // POST: Control/HowItWorks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text,Photo")] HowItWork howItWork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(howItWork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(howItWork);
        }

        // GET: Control/HowItWorks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HowItWork howItWork = db.HowItWorks.Find(id);
            if (howItWork == null)
            {
                return HttpNotFound();
            }
            return View(howItWork);
        }

        // POST: Control/HowItWorks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HowItWork howItWork = db.HowItWorks.Find(id);
            db.HowItWorks.Remove(howItWork);
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
