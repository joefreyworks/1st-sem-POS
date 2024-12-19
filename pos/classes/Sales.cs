using pos.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos.classes
{
    internal class Sales
    { // CREATE: Add a new sales record
        public bool AddSale(int productID, int orderQuantity, int unitPrice, DateTime dateOrder, string soldTo, int userInCharge, string transactionNumber)
        {
            string query = string.Format(
                "INSERT INTO sales (ProductID, OrderQuantity, UnitPrice, DateOrder, SoldTo, UserInCharge, TransactionNumber) " +
                "VALUES ({0}, {1}, {2}, '{3}', '{4}', {5}, '{6}')",
                productID, orderQuantity, unitPrice, dateOrder.ToString("yyyy-MM-dd"), soldTo.Replace("'", "''"), userInCharge, transactionNumber
            );
            if (SQLQuery.executeQuery(query))
            {
                query = "UPDATE inventory SET QuantityRemaining = (QuantityRemaining - {0}) WHERE ProductID  = {1}";
                return SQLQuery.executeQuery(string.Format(query, orderQuantity, productID));
            }
            return false;
        }

        public DataTable GetSales(DateTime dateOrder)
        {
            string query = @"
                    SELECT 
                        TransactionNumber, 
                        DateOrder
                    FROM 
                        sales
                    WHERE 
                        CDate(DateOrder) = #{0}#
                    GROUP BY 
                        TransactionNumber, 
                        DateOrder
                    ORDER BY 
                        DateOrder DESC";
            return SQLQuery.GetData(string.Format(query, dateOrder.ToString("yyyy-MM-dd")));
        }

        // READ: Get all sales records
        public DataTable GetAllSales()
        {
            string query = "SELECT * FROM sales ORDER BY DateOrder DESC";
            return SQLQuery.GetData(query);
        }

        // READ: Get all sales records
        public DataTable GetDailySales(DateTime dateTime)
        {
            string query = @"
                            SELECT 
                                products.ID AS ID, 
                                ProductName AS [Product Name], 
                                ProductSize AS [Size], 
                                Unit, 
                                UnitPrice AS [Price], 
                                OrderQuantity AS [Quantity Sold],
                                DateOrder AS [Date],
                                (UnitPrice * OrderQuantity) AS [Sales]
                            FROM sales 
                            INNER JOIN products 
                            ON sales.ProductID = products.ID 
                            WHERE DateOrder = #{0}# 
                            ORDER BY DateOrder DESC";

            return SQLQuery.GetData(string.Format(query, dateTime.ToString("yyyy-MM-dd")));
        }

        public DataTable GetCustomerDailySales(DateTime dateTime)
        {
            string query = @"
                            SELECT 
                                DateOrder AS [Date],
                                ProductName AS [Product Name], 
                                OrderQuantity AS [Quantity Sold],
                                UnitPrice AS [Price], 
                                (UnitPrice * OrderQuantity) AS [Total Sales]
                            FROM sales 
                            INNER JOIN products 
                            ON sales.ProductID = products.ID 
                            WHERE DateOrder = #{0}# 
                            ORDER BY DateOrder DESC";

            return SQLQuery.GetData(string.Format(query, dateTime.ToString("yyyy-MM-dd")));
        }

        public DataTable GetMonthlySales(int year, int month)
        {
            string query = @"
            SELECT 
                products.ID AS ID, 
                ProductName AS [Product Name], 
                ProductSize AS [Size], 
                Unit, 
                SUM(UnitPrice) AS [Price], 
                SUM(OrderQuantity) AS [Quantity Sold],
                SUM(UnitPrice * OrderQuantity) AS [Sales]
            FROM sales 
            INNER JOIN products 
            ON sales.ProductID = products.ID 
            WHERE YEAR(DateOrder) = {0} AND MONTH(DateOrder) = {1}
            GROUP BY 
                products.ID, 
                ProductName, 
                ProductSize, 
                Unit
            ORDER BY ProductName ASC";

            return SQLQuery.GetData(string.Format(query, year, month));
        }

        public DataTable GetYearlySales(int year)
        {
            string query = @"
                    SELECT 
                        FORMAT(DateOrder, 'mmmm') AS [Month], 
                        SUM(OrderQuantity) AS [Total Quantity Sold], 
                        SUM(UnitPrice * OrderQuantity) AS [Total Sales]
                    FROM sales 
                    INNER JOIN products 
                    ON sales.ProductID = products.ID 
                    WHERE YEAR(DateOrder) = {0}
                    GROUP BY FORMAT(DateOrder, 'mmmm'), MONTH(DateOrder)
                    ORDER BY MONTH(DateOrder)";

            return SQLQuery.GetData(string.Format(query, year));
        }




        // READ: Get a specific sales record by ID
        public DataTable GetSaleByID(int id)
        {
            string query = string.Format("SELECT * FROM sales WHERE ID = {0}", id);
            return SQLQuery.GetData(query);
        }

        // UPDATE: Update a specific sales record
        public bool UpdateSale(int id, int productID, int orderQuantity, DateTime dateOrder, string soldTo, int userInCharge)
        {
            string query = string.Format(
                "UPDATE sales SET " +
                "ProductID = {0}, OrderQuantity = {1}, DateOrder = '{2}', SoldTo = '{3}', UserInCharge = {4} " +
                "WHERE ID = {5}",
                productID, orderQuantity, dateOrder.ToString("yyyy-MM-dd"), soldTo.Replace("'", "''"), userInCharge, id
            );
            return SQLQuery.executeQuery(query);
        }

        // DELETE: Delete a specific sales record by ID
        public bool DeleteSale(int id)
        {
            string query = string.Format("DELETE FROM sales WHERE ID = {0}", id);
            return SQLQuery.executeQuery(query);
        }
    }
}
