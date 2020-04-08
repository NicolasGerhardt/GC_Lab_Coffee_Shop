using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{

    public class UserProfileController : Controller
    {
        //private readonly IUserAccountdb userAccountStore;


        public UserProfileController()
        {
            //this.userAccountStore = userAccountStore;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(UserAccount user)
        {
            //foreach (UserAccount u in userAccountStore.GetAll())
            //{
            //    Console.WriteLine("Accounts in store" + u.Email);
            //}

            if (ModelState.IsValid)
            {
                return View(user);
            }

            return View("Creation", user);
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Creation()
        {
            return View();
        }

    }
}