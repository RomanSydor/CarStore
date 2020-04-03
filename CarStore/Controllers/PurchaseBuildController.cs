using System;
using CarStore.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarStore.Models;

namespace CarStore.Controllers
{
    public class PurchaseBuildController : Controller
    {
        IPurchaseService service;

        public PurchaseBuildController(IPurchaseService serv) 
        {
            service = serv;
        }

        public ActionResult BrandChoose(int? id) 
        {
            service.BrandChoose(id);
            return RedirectToAction("Index", "CarType");
        }

        public ActionResult CarTypeChoose(int? id)
        {
            service.CarTypeChoose(id);
            return RedirectToAction("Index", "CarModel", new { id });
        }

        public ActionResult CarModelChoose(int? id)
        {
            service.CarModelChoose(id);
            return RedirectToAction("Details", "CarModel", new { id });
        }
        public ActionResult ConfigChoose(int? id)
        {
            service.ConfigChoose(id);
            return RedirectToAction("Index", "CarColor");
        }
        public ActionResult CarColorChoose(int? id)
        {
            service.CarColorChoose(id);
            return RedirectToAction("Create", "Purchase");
        }
    }
}