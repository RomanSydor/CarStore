using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface IConfigRepository
    {
        IEnumerable<Config> Index(int? id);
        Config Details(int? id);
    }
}
