using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public class UserAccountStore : IUserAccountdb
    {
        private List<UserAccount> userAccounts;

        public List<UserAccount> UserAccounts { get => userAccounts; set => userAccounts = value; }

        public UserAccountStore()
        {
            userAccounts = new List<UserAccount>();

            var testUser = new UserAccount();
            testUser.Email = "test@email.com";

            AddUser(testUser);
        }

        public bool AddUser(UserAccount user)
        {
            Console.WriteLine("new E-mail: " + user.Email);
            foreach (var u in userAccounts)
            {
                Console.WriteLine("existing E-mail: " + u.Email);
            }

            if (userAccounts.Exists(u => u.Email.StartsWith(user.Email)))
            {
                Console.WriteLine("Account exists");
                return false;
            }
            Console.WriteLine("Account does not exist");
            UserAccounts.Add(user);

            foreach (var u in userAccounts)
            {
                Console.WriteLine("InList E-mail: " + u.Email);
            }
            return true;
        }

        public List<UserAccount> GetAll()
        {
            return userAccounts;
        }
    }
}
