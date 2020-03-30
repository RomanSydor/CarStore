using CarStore.Models;
using CarStore.Repositories;
using System.Net;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class CarColorController : Controller
    {
        ICarColorRepository repo;

        public CarColorController(ICarColorRepository r)
        {
            repo = r;
        }

        public ActionResult Index()
        {
            return View(repo.Index());
        }

        public ActionResult Choose(int? id) 
        {
            TempPurchase.CarColorId = id.Value;
            return RedirectToAction("Create", "Purchase");
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
            return View(repo.Details(id));
        }
    }
}