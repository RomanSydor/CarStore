using CarStore.Repositories;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class CarTypeController : Controller
    {
        ICarTypeRepository repo;
        public CarTypeController(ICarTypeRepository r)
        {
            repo = r;
        }
        public ActionResult Index()
        {
            return View(repo.Index());
        }
    }
}