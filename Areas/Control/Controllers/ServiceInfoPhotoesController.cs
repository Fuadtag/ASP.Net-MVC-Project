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
    public class ServiceInfoPhotoesController : Controller
    {
        private JoobsyContext db = new JoobsyContext();

        // GET: Control/ServiceInfoPhotoes
        public ActionResult Index()
        {
            var serviceInfoPhotos = db.ServiceInfoPhotos.Include(s => s.Service);
            return View(serviceInfoPhotos.ToList());
        }

        // GET: Control/ServiceInfoPhotoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfoPhoto serviceInfoPhoto = db.ServiceInfoPhotos.Find(id);
            if (serviceInfoPhoto == null)
            {
                return HttpNotFound();
            }
            return View(serviceInfoPhoto);
        }

        // GET: Control/ServiceInfoPhotoes/Create
        public ActionResult Create()
        {
            ViewBag.ServiceId = new SelectList(db.Services, "Id", "Icon");
            return View();
        }

        // POST: Control/ServiceInfoPhotoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ServiceId,Photo")] ServiceInfoPhoto serviceInfoPhoto)
        {
            if (ModelState.IsValid)
            {
                db.ServiceInfoPhotos.Add(serviceInfoPhoto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ServiceId = new SelectList(db.Services, "Id", "Icon", serviceInfoPhoto.ServiceId);
            return View(serviceInfoPhoto);
        }

        // GET: Control/ServiceInfoPhotoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfoPhoto serviceInfoPhoto = db.ServiceInfoPhotos.Find(id);
            if (serviceInfoPhoto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ServiceId = new SelectList(db.Services, "Id", "Icon", serviceInfoPhoto.ServiceId);
            return View(serviceInfoPhoto);
        }

        // POST: Control/ServiceInfoPhotoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ServiceId,Photo")] ServiceInfoPhoto serviceInfoPhoto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceInfoPhoto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ServiceId = new SelectList(db.Services, "Id", "Icon", serviceInfoPhoto.ServiceId);
            return View(serviceInfoPhoto);
        }

        // GET: Control/ServiceInfoPhotoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceInfoPhoto serviceInfoPhoto = db.ServiceInfoPhotos.Find(id);
            if (serviceInfoPhoto == null)
            {
                return HttpNotFound();
            }
            return View(serviceInfoPhoto);
        }

        // POST: Control/ServiceInfoPhotoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceInfoPhoto serviceInfoPhoto = db.ServiceInfoPhotos.Find(id);
            db.ServiceInfoPhotos.Remove(serviceInfoPhoto);
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
