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
    public class PricingsController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/Pricings
        public ActionResult Index()
        {
            return View(db.Pricings.ToList());
        }

        // GET: Control/Pricings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pricing pricing = db.Pricings.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // GET: Control/Pricings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/Pricings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Bandwidth,Onlinespace,Support,Domain,HiddenFees")] Pricing pricing)
        {
            if (ModelState.IsValid)
            {
                db.Pricings.Add(pricing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pricing);
        }

        // GET: Control/Pricings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pricing pricing = db.Pricings.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // POST: Control/Pricings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Bandwidth,Onlinespace,Support,Domain,HiddenFees")] Pricing pricing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pricing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pricing);
        }

        // GET: Control/Pricings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pricing pricing = db.Pricings.Find(id);
            if (pricing == null)
            {
                return HttpNotFound();
            }
            return View(pricing);
        }

        // POST: Control/Pricings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pricing pricing = db.Pricings.Find(id);
            db.Pricings.Remove(pricing);
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
