using pos.common;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.classes
{
    internal class Inventory
    {
        public bool AddInventory(int productID, string supplier, DateTime dateDelivered, int quantityReceived, int reorderLevel, string updatedBy, int quantityRemaining)
        {
            string query = string.Format(
                "INSERT INTO inventory (ProductID, Supplier, DateDelivered, QuantityReceived, ReOrderLevel, UpdatedBy, QuantityRemaining) " +
                "VALUES ({0}, '{1}', '{2}', {3}, {4}, '{5}', {6})",
                productID, supplier.Replace("'", "''"), dateDelivered.ToString("yyyy-MM-dd"), quantityReceived, reorderLevel, updatedBy.Replace("'", "''"), quantityRemaining
            );

            return SQLQuery.executeQuery(query);
        }


        public DataTable GetAllInventory()
        {
            string query = "SELECT * FROM inventory INNER JOIN  Products ON inventory.ProductID = Products.ID ORDER BY inventory.ID ASC";
            return SQLQuery.GetData(query);
        }

        public DataTable GetProductSizesByProductName(string productName)
        {
            string query = string.Format("SELECT * FROM inventory INNER JOIN  Products ON inventory.ProductID = Products.ID WHERE ProductName = '{0}' ORDER BY inventory.ID ASC", productName);
            return SQLQuery.GetData(query);
        }

        public bool CheckInventoryByProductID(int id)
        {
            string query = string.Format("SELECT * FROM inventory WHERE ProductID = {0}", id);
            return SQLQuery.checkQuery(query);
        }

        public bool UpdateInventory(int productID, string supplier, DateTime dateDelivered, int quantityReceived, int reorderLevel, string updatedBy)
        {
            string query = string.Format(
                "UPDATE inventory SET " +
                "Supplier = '{0}', DateDelivered = '{1}', QuantityReceived = {2}, " +
                "ReOrderLevel = {3}, UpdatedBy = '{4}', QuantityRemaining = (QuantityRemaining + {5}) " +
                "WHERE ProductID  = {6}",
                supplier.Replace("'", "''"), 
                dateDelivered.ToString("yyyy-MM-dd"), 
                quantityReceived,
                reorderLevel, 
                updatedBy.Replace("'", "''"), 
                quantityReceived,
                productID
            );

            return SQLQuery.executeQuery(query);
        }
        public bool DeleteInventory(int id)
        {
            string query = string.Format("DELETE FROM inventory WHERE ID = {0}", id);
            return SQLQuery.executeQuery(query);
        }


    }
}
