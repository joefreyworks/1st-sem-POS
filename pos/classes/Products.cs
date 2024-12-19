using pos.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.classes
{
    internal class Products
    {
        public DataTable GetAllProduct()
        {
            string query = "SELECT * FROM products ORDER BY ProductName ASC";
            return SQLQuery.GetData(query);
        }

        public DataTable GetProduct(int iD) {
            string query = "SELECT * FROM products WHERE ID = {0}";
            return SQLQuery.GetData(string.Format(query, iD));
        }

        public bool DeleteProduct(int iD)
        {
            string query = "DELETE FROM products WHERE ID = {0}";
            return SQLQuery.executeQuery(string.Format(query, iD));
        }

        public bool AddProduct(string productName, string productSize, string unit, double price)
        {
            string query = "INSERT INTO products (ProductName, ProductSize, Unit, Price) VALUES ('{0}', '{1}', '{2}', {3})";
            return SQLQuery.executeQuery(string.Format(query, productName, productSize, unit, price));
        }

        public bool EditProduct(int id, string productName, string productSize, string unit, double price)
        {
            string query = "UPDATE products SET " +
                           "ProductName = '{1}', " +
                           "ProductSize = '{2}', " +
                           "Unit = '{3}', " +
                           "Price = {4} " +
                           "WHERE ID = {0}";
            return SQLQuery.executeQuery(string.Format(query, id, productName, productSize, unit, price));
        }

    }
}
