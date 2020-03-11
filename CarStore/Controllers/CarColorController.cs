using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class CarColorController : Controller
    {
        CarStoreContext db = new CarStoreContext();
        public ActionResult Index()
        {
            return View(db.CarColors.ToList());
        }

        public ActionResult Details(int? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarColor carColor = db.CarColors.Find(id);
            if(carColor == null) 
            {
                return HttpNotFound();
            }
            return View(carColor);
        }
    }
}