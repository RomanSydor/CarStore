using CarStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class IdSaverController : Controller
    {
        IIdSaverService _service;
        public IdSaverController(IIdSaverService s) 
        {
            _service = s;
        }

        public ActionResult BrandChoose(int? id)
        {
            _service.BrandIdSave(id);
            return RedirectToAction("Index", "CarType");
        }

        public ActionResult CarTypeChoose(int? id)
        {
            _service.CarTypeIdSave(id);
            return RedirectToAction("Index", "CarModel", new { id });
        }

        public ActionResult CarModelChoose(int? id)
        {
            _service.CarModelIdSave(id);
            return RedirectToAction("Details", "CarModel", new { id });
        }
        public ActionResult ConfigChoose(int? id)
        {
            _service.ConfigIdSave(id);
            return RedirectToAction("Index", "CarColor");
        }
        public ActionResult CarColorChoose(int? id)
        {
            _service.CarColorIdSave(id);
            return RedirectToAction("Create", "Purchase");
        }
    }
}