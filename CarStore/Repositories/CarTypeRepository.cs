using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Repositories
{
    public class CarTypeRepository : IDisposable, ICarTypeRepository
    {
        private CarStoreContext db = new CarStoreContext();

        public IEnumerable<CarType> Index()
        {
            return db.CarTypes.ToList();
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