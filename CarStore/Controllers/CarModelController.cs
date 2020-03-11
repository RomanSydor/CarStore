using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class CarModelController : Controller
    {
        CarStoreContext db = new CarStoreContext();
        
        public ActionResult Index(int? id)
        {
            var result = new List<CarModel>();
            if (id == null)
            {
                return View(db.CarModels.ToList());
            }
            else
            {
                foreach (var cm in db.CarModels)
                {
                    if (cm.BrandId == id)
                    {
                        result.Add(cm);
                    }
                }
                return View(result.ToList());
            }
        }

        public ActionResult Details(int? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModel carModel = db.CarModels.Find(id);
            if (carModel == null)
            {
                return HttpNotFound();
            }
            return View(carModel);
        }
    }
}