using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Repositories
{
    public interface ICarTypeRepository
    {
        IEnumerable<CarType> Index();
    }
}
