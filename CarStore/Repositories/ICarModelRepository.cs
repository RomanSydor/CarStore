using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface ICarModelRepository
    {
        IEnumerable<CarModel> Index(int? id);
        CarModel Details(int? id);
    }
}
