using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Repositories
{
    public class PurchaseRepository: IDisposable, IPurchaseRepository
    {
        private CarStoreContext db = new CarStoreContext();

        public Purchase Create([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return purchase;
        }

        public Purchase Delete(int? id)
        {
            Purchase purchase = db.Purchases.Find(id);
            return purchase;
        }

        public Purchase DeleteConfirmed(int id)
        {
            Purchase purchase = db.Purchases.Find(id);
            db.Purchases.Remove(purchase);
            db.SaveChanges();
            return purchase;
        }

        public Purchase Details(int? id)
        {
            Purchase purchase = db.Purchases.Find(id);
            return purchase;
        }

        public Purchase Edit(int? id)
        {
            Purchase purchase = db.Purchases.Find(id);
            return purchase;
        }

        public Purchase Edit([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Entry(purchase).State = EntityState.Modified;
            db.SaveChanges();
            return purchase;
        }

        public IEnumerable<Purchase> Index()
        {
            return db.Purchases.ToList();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}