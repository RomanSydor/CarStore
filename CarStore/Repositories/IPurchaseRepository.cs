using CarStore.Models;
using System.Collections.Generic;

namespace CarStore.Repositories
{
    public interface IPurchaseRepository
    {
        IEnumerable<Purchase> Index();
        Purchase Details(int? id);
        Purchase Create(Purchase purchase);
        Purchase Edit(int? id);
        Purchase Delete(int? id);
        Purchase DeleteConfirmed(int id);
    }
}
