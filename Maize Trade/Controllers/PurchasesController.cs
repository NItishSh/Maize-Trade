using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Maize_Trade.Models;

namespace Maize_Trade.Controllers
{
    public class PurchasesController : Controller
    {
        private MaizeTradeDbEntities db = new MaizeTradeDbEntities();

        // GET: Purchases
        public ActionResult Index()
        {
            var purchases = db.Purchases.Include(p => p.Farmer);
            return View(purchases.ToList());
        }

        public ActionResult MonthlyPurchase()
        {
            var purchases = db.Purchases.Include(p => p.Farmer);
            return View(purchases.ToList());
        }

        public ActionResult DailyPurchase()
        {
            var purchases = db.Purchases.Include(p => p.Farmer);
            return View(purchases.ToList());
        }
        // GET: Purchases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // GET: Purchases/Create
        public ActionResult Create()
        {
            ViewBag.FarmerID = new SelectList(db.Farmers, "FarmerID", "Name");
            Purchase purchase = new Purchase();
            purchase.Date = DateTime.Now;
            return View(purchase);
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PurchaseID,Date,FarmerID,MaizeWeight,MaizeRate,DeductionInWeight,TotalAmount,Note")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FarmerID = new SelectList(db.Farmers, "FarmerID", "Name", purchase.FarmerID);
            return View(purchase);
        }

        // GET: Purchases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarmerID = new SelectList(db.Farmers, "FarmerID", "Name", purchase.FarmerID);
            return View(purchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PurchaseID,Date,FarmerID,MaizeWeight,MaizeRate,DeductionInWeight,TotalAmount,Note")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FarmerID = new SelectList(db.Farmers, "FarmerID", "Name", purchase.FarmerID);
            return View(purchase);
        }

        // GET: Purchases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Purchase purchase = db.Purchases.Find(id);
            if (purchase == null)
            {
                return HttpNotFound();
            }
            return View(purchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchases.Find(id);
            db.Purchases.Remove(purchase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public PartialViewResult FarmerDetails(int id)
        {
            var result = db.Farmers.FirstOrDefault(x => x.FarmerID == id);
            return PartialView("_FarmerDetails", result);
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
