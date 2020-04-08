using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public class Product
    {
        /*
        use CoffeeShop;

        create Table Products (
	    ID int NOT NULL primary key identity(100,1),
 	    Name nvarchar(50) NOT NULL,
 	    Price float(32) NOT NULL,
 	    Description nvarchar(300),
 	    Category nvarchar(20) NOT NULL
        )
        */

        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

    }
}
