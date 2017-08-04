using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.MVC.Services;
using ProductCatalog.MVC.Models;

namespace ProductCatalog.MVC.Controllers
{
    public class ProductController : Controller
    {
        private ICatalogServices catalogServices;

        public ProductController(ICatalogServices catalogServices)
        {
            this.catalogServices = catalogServices;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(catalogServices.GetProducts());
        }

        // GET: Product/Details/5
        public ActionResult Details(string itemCode)
        {
            var product = catalogServices.FindProductByIdOrName(itemCode);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            try
            {
                // TODO: Add insert logic here
                var product = catalogServices.CreateNewProduct(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = catalogServices.DeleteProduct(id);            
            return RedirectToAction("Index");
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}