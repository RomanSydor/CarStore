using CarStore.Models;
using CarStore.Repositories;
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

        public PurchaseController(IPurchaseRepository r) 
        {
            repo = r;
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
                repo.Create(purchase);
                return RedirectToAction("Index", "Home");
            }

            return View(purchase);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            if (repo.Edit(id) == null)
            {
                return HttpNotFound();
            }
            return View(repo.Edit(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Customer,Phone,Date,BrandId,CarModelId,ConfigId,CarColorId")] Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                repo.Edit(purchase);
                return RedirectToAction("Index");
            }
            return View(purchase);
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