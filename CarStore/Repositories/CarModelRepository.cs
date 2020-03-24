using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class CarModelRepository : IDisposable, ICarModelRepository
    {

        private CarStoreContext db = new CarStoreContext();

        public CarModel Details(int? id)
        {
            CarModel carModel = db.CarModels.Find(id);
            return carModel;
        }

        public IEnumerable<CarModel> Index(int? id)
        {
            var result = new List<CarModel>();
            if (id == null)
            {
                return db.CarModels.ToList();
            }
            else
            {
                foreach (var cm in db.CarModels)
                {
                    if (cm.BrandId == id)
                    {
                        result.Add(cm);
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