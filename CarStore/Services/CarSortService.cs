using CarStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace CarStore.Services
{
    public class CarSortService : ICarSortService
    {
        CarStoreContext db = new CarStoreContext();
        IIdSaverService _idSaver;

        public CarSortService(IIdSaverService id)
        {
            _idSaver = id;
        }

        public IEnumerable<CarModel> Sort()
        {
            var result = new List<CarModel>();
            var p = _idSaver.AllIds();
            foreach (var c in db.CarModels)
            {
                if (c.BrandId == p.SavedBrandId && c.CarTypeId == p.SavedCarTypeId)
                {
                    result.Add(c);
                }
            }
            return result.ToList();
        }
    }
}