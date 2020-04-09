using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Coffee_Shop.Controllers
{
    public class AdminController : Controller
    {

        IConfiguration ConfigRoot;
        DAL dal;

        public AdminController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("CoffeeShop"));
        }


        public IActionResult Index()
        {
            var products = dal.GetProductsAll();
            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                dal.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = dal.GetProductByID(id);

            if (product == null)
            {
                TempData["Red Action Text"] = "No Menu Item found with that ID. Make selection from items on Menu";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product product)
        {
            dal.DeleteProductByID(product.ID);
            TempData["Red Action Text"] = $"Product ID \'{product.ID}\'  has been deleted";
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {

            var product = dal.GetProductByID(id);

            if (product == null)
            {
                TempData["Red Action Text"] = "No Menu Item found with that ID. Make selection from items on Menu";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Edit(int id)
        {

            var product = dal.GetProductByID(id);

            if (product == null)
            {
                TempData["Red Action Text"] = "No Menu Item found with that ID. Make selection from items on Menu";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                dal.UpdateProduct(product);
                return RedirectToAction("Details", new { ID = product.ID });
            }

            return View(product);
        }
    }
}