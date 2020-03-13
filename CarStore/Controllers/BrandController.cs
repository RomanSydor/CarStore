using CarStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class BrandController : Controller
    {
        CarStoreContext db = new CarStoreContext();
        
        public ActionResult Index()
        {
            //var result = new List<Brand>();
            //if (id == null)
            //{
                return View(db.Brands.ToList());
            //}
            //else 
            //{
            //    foreach (var b in db.Brands) 
            //    {
            //        if (b.Id == id) 
            //        {
            //            result.Add(b);
            //        }
            //    }
            //    return View(result.ToList());
            //}
        }

        public ActionResult Details(int? id) 
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }
    }
}