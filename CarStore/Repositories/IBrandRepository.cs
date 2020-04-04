using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> Index();
        Brand Details(int? id);

    }
}
