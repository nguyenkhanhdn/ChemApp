using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ChemApp.Models;

namespace ChemApp.Controllers
{
    public class ChemsController : Controller
    {
        private ChemDbContext db = new ChemDbContext();

        // GET: Chems
        public ActionResult Index()
        {
            return View(db.Chems.ToList());
        }

        // GET: Chems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chem chem = db.Chems.Find(id);
            if (chem == null)
            {
                return HttpNotFound();
            }
            return View(chem);
        }

        // GET: Chems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Formula,ImageUrl,Category")] Chem chem)
        {
            if (ModelState.IsValid)
            {
                db.Chems.Add(chem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chem);
        }

        // GET: Chems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chem chem = db.Chems.Find(id);
            if (chem == null)
            {
                return HttpNotFound();
            }
            return View(chem);
        }

        // POST: Chems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Formula,ImageUrl,Category")] Chem chem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chem);
        }

        // GET: Chems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chem chem = db.Chems.Find(id);
            if (chem == null)
            {
                return HttpNotFound();
            }
            return View(chem);
        }

        // POST: Chems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chem chem = db.Chems.Find(id);
            db.Chems.Remove(chem);
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
