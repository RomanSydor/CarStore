using CarStore.Models;
using CarStore.Repositories;
using System.Net;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class ConfigController : Controller
    {
        IConfigRepository repo;

        public ConfigController(IConfigRepository r)
        {
            repo = r;
        }

        public ActionResult Index(int? id)
        {
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
            return View(repo.Details(id));
        }
    }
}