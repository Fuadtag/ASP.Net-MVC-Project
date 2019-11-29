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
    public class AdvicesController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/Advices
        public ActionResult Index()
        {
            return View(db.Advices.ToList());
        }

        // GET: Control/Advices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advice advice = db.Advices.Find(id);
            if (advice == null)
            {
                return HttpNotFound();
            }
            return View(advice);
        }

        // GET: Control/Advices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/Advices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Title,Text,CreatedAt")] Advice advice)
        {
            if (ModelState.IsValid)
            {
                db.Advices.Add(advice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(advice);
        }

        // GET: Control/Advices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advice advice = db.Advices.Find(id);
            if (advice == null)
            {
                return HttpNotFound();
            }
            return View(advice);
        }

        // POST: Control/Advices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Title,Text,CreatedAt")] Advice advice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(advice);
        }

        // GET: Control/Advices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advice advice = db.Advices.Find(id);
            if (advice == null)
            {
                return HttpNotFound();
            }
            return View(advice);
        }

        // POST: Control/Advices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Advice advice = db.Advices.Find(id);
            db.Advices.Remove(advice);
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
