using CarStore.Models;
using CarStore.Repositories;
using CarStore.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarStore.Controllers
{
    public class PurchaseController : Controller
    {

        IPurchaseRepository repo;
        IPurchaseService _service;

        public PurchaseController(IPurchaseRepository r, IPurchaseService s)
        {
            repo = r;
            _service = s;
        }

        public ActionResult Index()
        {
            return View(repo.Index());
        }

        // GET: Purchase/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            if (repo.Details(id) == null)
            {
                return HttpNotFound();
            }
            return View(repo.Details(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                var pur = _service.Create();
                pur.Phone = purchase.Phone;
                pur.Customer = purchase.Customer;
                repo.Create(pur);
                return RedirectToAction("PurchaseConfirm", new { pur.Id });
            }
            return View(_service.Create());
        }

        public ActionResult PurchaseConfirm(int? id) 
        {
            return RedirectToAction("Details", new { id });
        }

        public ActionResult Edit(int id)
        {
            if (repo.Edit(id) == null)
            {
                return HttpNotFound();
            }
            repo.DeleteConfirmed(id);
            return RedirectToAction("Index", "Brand");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            if (repo.Delete(id) == null)
            { 
                return HttpNotFound();
            }
            return View(repo.Delete(id));
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.DeleteConfirmed(id);
            return RedirectToAction("Index");
        }
    }
}