using pos.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.classes
{
    internal class Stocks
    {
        public bool AddStocks(int productID, string supplier, DateTime dateDelivered, int quantityReceived, int reorderLevel)
        {
            string query = "INSERT INTO Stocks (ProductID, Supplier, DateDelivered, QuantityReceived, ReOrderLevel) " +
                           "VALUES ('{0}', '{1}', '{2}', {3}, {4})";
            return SQLQuery.executeQuery(string.Format(query, productID, supplier, dateDelivered.ToString("yyyy-MM-dd"), quantityReceived, reorderLevel));
        }

        public DataTable GetAllStocks()
        {
            string query = "SELECT * FROM Stocks INNER JOIN  Products ON Stocks.ProductID = Products.ID ORDER BY Stocks.ID ASC";
            return SQLQuery.GetData(query);
        }

        public DataTable GetStocksByID(int id)
        {
            string query = "SELECT * FROM Stocks WHERE ID = ?";
            return SQLQuery.GetData(string.Format(query, id));
        }

        public bool UpdateStocks(int id, int productID, string supplier, DateTime dateDelivered, int quantityReceived, int reorderLevel)
        {
            string query = string.Format(
                "UPDATE Stocks SET ProductID = {0}, Supplier = '{1}', DateDelivered = '{2}', QuantityReceived = {3}, ReOrderLevel = {4} WHERE ID = {5}",
                productID, supplier.Replace("'", "''"), dateDelivered.ToString("yyyy-MM-dd"), quantityReceived, reorderLevel, id
            );

            return SQLQuery.executeQuery(query);
        }
        public bool DeleteStocks(int id)
        {
            string query = string.Format("DELETE FROM Stocks WHERE ID = {0}", id);

            return SQLQuery.executeQuery(query);
        }


    }
}
