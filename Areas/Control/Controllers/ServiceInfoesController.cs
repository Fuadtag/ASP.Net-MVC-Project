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
    public class ServiceInfoesController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/ServiceInfoes
        public ActionResult Index()
        {
            return View(db.ServiceInfos.ToList());
        }

        // GET: Control/ServiceInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceInfo = db.ServiceInfos.Find(id);
            if (serviceInfo == null)
            {
                return HttpNotFound();
            }
            return View(serviceInfo);
        }

        // GET: Control/ServiceInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Control/ServiceInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Text")] ServiceInfo serviceInfo)
        {
            if (ModelState.IsValid)
            {
                db.ServiceInfos.Add(serviceInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceInfo);
        }

        // GET: Control/ServiceInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceInfo = db.ServiceInfos.Find(id);
            if (serviceInfo == null)
            {
                return HttpNotFound();
            }
            return View(serviceInfo);
        }

        // POST: Control/ServiceInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Text")] ServiceInfo serviceInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceInfo);
        }

        // GET: Control/ServiceInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfo serviceInfo = db.ServiceInfos.Find(id);
            if (serviceInfo == null)
            {
                return HttpNotFound();
            }
            return View(serviceInfo);
        }

        // POST: Control/ServiceInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceInfo serviceInfo = db.ServiceInfos.Find(id);
            db.ServiceInfos.Remove(serviceInfo);
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
