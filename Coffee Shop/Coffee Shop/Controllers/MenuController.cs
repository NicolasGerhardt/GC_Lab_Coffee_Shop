using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Coffee_Shop.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Coffee_Shop.Controllers
{
    public class MenuController : Controller
    {
        IConfiguration ConfigRoot;
        SqlConnection connection;

        public MenuController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("CoffeeShop"));
        }

        public IActionResult Index()
        {
            string queryString = "select * from Products";
            var Products = connection.Query<Product>(queryString);
            return View(Products);
        }

        public IActionResult Details(int id)
        {
            string queryString = "select * from Products where ID = @ID";
            var product = connection.QueryFirstOrDefault<Product>(queryString, new { ID = id } );

            if (product == null)
            {
                ViewData["Bad-ID-Passed"] = true;

                queryString = "select * from Products";
                var Products = connection.Query<Product>(queryString);

                return View("Index", Products);
            }
            return View(product);
        }
    }
}