using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public class DAL
    {
        SqlConnection connection;

        public DAL(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public IEnumerable<Product> GetProductsAll()
        {
            string queryString = "select * from Products";
            var Products = connection.Query<Product>(queryString);
            return Products;
        }

        /// <summary>
        /// Will return either the first product found or null if not found. 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Product GetProductByID(int id)
        {
            string queryString = "select * from Products where ID = @ID";
            var product = connection.QueryFirstOrDefault<Product>(queryString, new { ID = id });
            return product;
        }

        public void AddProduct(Product product)
        {
            string queryString = "insert into Products (Name, Price, Description, Category) values (@name, @price, @description, @Category)";
            connection.Execute(queryString, product);
        }

        public void UpdateProduct(Product product)
        {
            string queryString = "update Products set Name = @Name, Price = @Price, Description = @Description, Category = @Category ";
            queryString += "where ID = @ID";
            connection.Execute(queryString, product);
        }

        public void DeleteProductByID(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @ID";
            connection.Execute(deleteString, new { ID = id });
        }
    }
}
