using CarStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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