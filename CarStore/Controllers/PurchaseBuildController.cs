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
        public Purchase purchase = new Purchase();

        public PurchaseBuildController(IPurchaseService serv) 
        {
            service = serv;
        }

        public ActionResult BrandChoose(int? id) 
        {
            service.ChooseBrand(id);
            return RedirectToAction("Index", "CarModel", new { id });
        }
        public ActionResult CarModelChoose(int? id)
        {
            service.ChooseCarModel(id);
            return RedirectToAction("Details", "CarModel", new { id });
        }
        public ActionResult ConfigChoose(int? id)
        {
            service.ChooseConfig(id);
            return RedirectToAction("Index", "CarColor");
        }
        public ActionResult CarColorChoose(int? id)
        {
            service.ChooseCarColor(id);
            return RedirectToAction("Create", "Purchase");
        }
    }
}