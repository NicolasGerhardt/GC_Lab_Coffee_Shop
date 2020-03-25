using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class UserProfileController : Controller
    {
        [HttpPost]
        public IActionResult Summary(string fname, string lname, string email, string password)
        {
            ViewData["fname"] = fname;
            ViewData["lname"] = lname;
            ViewData["email"] = email;
            ViewData["password"] = password;
            return View();
        }
    }
}