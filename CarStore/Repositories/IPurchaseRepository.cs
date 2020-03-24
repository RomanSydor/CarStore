using CarStore.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CarStore.Repositories
{
    public interface IPurchaseRepository
    {
        IEnumerable<Purchase> Index();
        Purchase Details(int? id);
        Purchase Create([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase);
        Purchase Edit(int? id);
        Purchase Edit([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase);
        Purchase Delete(int? id);
        Purchase DeleteConfirmed(int id);
    }
}
