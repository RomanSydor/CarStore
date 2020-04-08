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
        IPurchaseService _service;

        public PurchaseBuildController(IPurchaseService serv) 
        {
            _service = serv;
        }

        public ActionResult BrandChoose(int? id)
        {
            _service.BrandChoose(id);
            return RedirectToAction("Index", "CarType");
        }

        public ActionResult CarTypeChoose(int? id)
        {
            _service.CarTypeChoose(id);
            return RedirectToAction("Index", "CarModel", new { id });
        }

        public ActionResult CarModelChoose(int? id)
        {
            _service.CarModelChoose(id);
            return RedirectToAction("Details", "CarModel", new { id });
        }
        public ActionResult ConfigChoose(int? id)
        {
            _service.ConfigChoose(id);
            return RedirectToAction("Index", "CarColor");
        }
        public ActionResult CarColorChoose(int? id)
        {
            _service.CarColorChoose(id);
            return RedirectToAction("Create", "Purchase");
        }

        public ActionResult BackToCarDetails() 
        {
            var pur = _service.Create();
            int id = pur.CarModelId;
            return RedirectToAction("Details", "CarModel", new { id });
        }

        public ActionResult BackToConfig() 
        {
            var pur = _service.Create();
            _service.ConfigCancel(pur.ConfigId);
            int id = pur.CarModelId;
            return RedirectToAction("Index", "Config", new { id });
        }

        public ActionResult BackToColor() 
        {
            var pur = _service.Create();
            _service.CarColorCancel(pur.CarColorId);
            int id = pur.CarModelId;
            return RedirectToAction("Index", "CarColor");
        }
    }
}