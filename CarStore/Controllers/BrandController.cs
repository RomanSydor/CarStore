using CarStore.Repositories;
using System.Net;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class BrandController : Controller
    {
        IBrandRepository repo;

        public BrandController(IBrandRepository r)
        {
            repo = r;
        }

        public ActionResult Index()
        {
            return View(repo.Index());
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