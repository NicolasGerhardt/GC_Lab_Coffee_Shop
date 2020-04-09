using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Name is too short")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a positive number")]
        [RegularExpression(@"^\d*(\.\d{1,2})?$", ErrorMessage = "Please enter valid price, without the $")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Price { get; set; }

        [MaxLength(300, ErrorMessage = "Description is too long")]
        public string Description { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Category is too long")]
        public string Category { get; set; }

    }
}
