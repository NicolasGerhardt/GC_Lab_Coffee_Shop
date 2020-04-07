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
                user.Password = HashAndSaltPassword(user.Password);

                
                    
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

        private string HashAndSaltPassword(string password)
        {
            // Create Salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            // create bytes and hash password
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            //Combine salt and Password
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            // Clean IDisposable Resources
            
            //convert to string and return
            return Convert.ToBase64String(hashBytes);
        }

        private bool VerifyPasswordAgainstHash(string password, string savedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}