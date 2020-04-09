using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Coffee_Shop.Controllers
{
    public class MenuController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public MenuController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("CoffeeShop"));
        }

        public IActionResult Index()
        {
            var Products = dal.GetProductsAll();
            return View(Products);
        }

        public IActionResult Details(int id)
        {
            
            var product = dal.GetProductByID(id);

            if (product == null)
            {
                TempData["Bad-Product-ID-Passed"] = "No Menu Item found with that ID. Make selection from items on Menu";
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}