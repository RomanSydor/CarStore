using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarStore.Services
{
    public class CarSortService : ICarSortService
    {
        CarStoreContext db = new CarStoreContext();
        IPurchaseService _service;

        public CarSortService(IPurchaseService s) 
        {
            _service = s;
        }

        public IEnumerable<CarModel> Sort()
        {
            var result = new List<CarModel>();
            var p = _service.Create();
            foreach (var c in db.CarModels)
            {
                if (c.BrandId == p.BrandId && c.CarTypeId == p.CarTypeId)
                {
                    result.Add(c);
                }
            }
            return result.ToList();
        }
    }
}