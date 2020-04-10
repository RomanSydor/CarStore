using CarStore.Models;
using CarStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Repositories
{
    public class CarModelRepository : IDisposable, ICarModelRepository
    {

        private CarStoreContext db = new CarStoreContext();
        IPurchaseService _service;
        
        public CarModelRepository(IPurchaseService s)
        {
            _service = s;
        }


        public CarModel Details(int? id)
        {
            CarModel carModel = db.CarModels.Find(id);
            return carModel;
        }

        public IEnumerable<CarModel> Index(int? id)
        {
            var p = _service.Create();
            IEnumerable<CarModel> result = db.CarModels
                .Where(r => r.BrandId == p.BrandId
                && r.CarTypeId == p.CarTypeId);

            return result
                .ToList()
                .OrderBy(n => n.Name);
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