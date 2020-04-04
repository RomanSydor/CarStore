using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class BrandRepository : IDisposable, IBrandRepository
    {

        private CarStoreContext db = new CarStoreContext();

        public Brand Details(int? id)
        {
            Brand brand = db.Brands.Find(id);
            return brand;
        }


        public IEnumerable<Brand> Index(int? id)
        {
            var result = new List<Brand>();
            if (id == null)
            {
                return db.Brands.ToList();
            }
            else
            {
                foreach (var b in db.Brands)
                {
                    if (b.Id == id)
                    {
                        result.Add(b);
                    }
                }
                return result.ToList();
            }
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