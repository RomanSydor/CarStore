using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> Index(int? id);
        Brand Details(int? id);

    }
}
