using CarStore.Models;
using CarStore.Repositories;
using System.Net;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class CarModelController : Controller
    {
        ICarModelRepository repo;

        public CarModelController(ICarModelRepository r)
        {
            repo = r;
        }

        public ActionResult Index(int? id)
        {
            TempPurchase.BrandId = id.Value;
            return View(repo.Index(id));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (repo.Details(id) == null)
            {
                return HttpNotFound();
            }
            TempPurchase.CarModelId = id.Value;
            return View(repo.Details(id));
        }
    }
}