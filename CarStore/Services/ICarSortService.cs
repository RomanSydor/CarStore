using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Services
{
    public interface ICarSortService
    {
        IEnumerable<CarModel> Sort();
    }
}
