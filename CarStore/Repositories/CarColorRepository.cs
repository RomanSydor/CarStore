using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class CarColorRepository : IDisposable, ICarColorRepository
    {
        private CarStoreContext db = new CarStoreContext();

        public CarColor Details(int? id)
        {
            CarColor carColor = db.CarColors.Find(id);
            return carColor;
        }

        public IEnumerable<CarColor> Index()
        {
            return db.CarColors.ToList();
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