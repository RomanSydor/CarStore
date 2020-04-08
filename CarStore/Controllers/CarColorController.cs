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
    }
}