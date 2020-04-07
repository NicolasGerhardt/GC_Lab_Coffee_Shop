using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public interface IUserAccountdb
    {

        public bool AddUser(UserAccount user);
        public List<UserAccount> GetAll();
    }
}
