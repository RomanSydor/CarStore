using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class ConfigController : Controller
    {
        CarStoreContext db = new CarStoreContext();
        public ActionResult Index(int? id)
        {
            var result = new List<Config>();
            if (id == null)
            {
                return View(db.Configs.ToList());
            }
            else 
            {
                foreach (var c in db.Configs)
                {
                    if (c.CarModelId == id)
                    {
                        result.Add(c);
                    }
                }
                return View(result.ToList());
            }
        }

        public ActionResult Details(int ? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Config config = db.Configs.Find(id);
            if (config == null)
            {
                return HttpNotFound();
            }
            return View(config);
        }
    }
}