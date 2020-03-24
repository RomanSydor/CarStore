using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface ICarColorRepository
    {
        IEnumerable<CarColor> Index();
        CarColor Details(int? id);
    }
}
