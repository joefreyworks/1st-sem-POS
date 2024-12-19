using pos.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pos.classes
{
    internal class Account
    {
     
        public bool CheckEmailIfExist(string email)
        {
            string query = "SELECT * FROM account WHERE email = '{0}' ";
            return SQLQuery.checkQuery(string.Format(query, email));
        }

        public bool UpdatePassword(string email, string password)
        {
            string query = "UPDATE account set password = '{0}' WHERE email = '{1}' ";
            return SQLQuery.executeQuery(string.Format(query, password, email));
        }
        public DataTable GetAllAccounts()
        {
            string query = "SELECT * FROM account ORDER BY FullName ASC";
            return SQLQuery.GetData(query);
        }
        public DataTable GetAccount(string username, string password, string AccountType)
        {
            string query = "SELECT * FROM account WHERE Username = '{0}' AND Password = '{1}' AND AccountType = '{2}' ";
            return SQLQuery.GetData(string.Format(query, username, password, AccountType));
        }

        public DataTable GetAccount(string username)
        {
            string query = "SELECT * FROM account WHERE Username = '{0}' ";
            return SQLQuery.GetData(string.Format(query, username));
        }

        public DataTable GetAccountByID(int iD)
        {
            string query = "SELECT * FROM account WHERE ID = {0} ";
            return SQLQuery.GetData(string.Format(query, iD));
        }

        public bool AddAccount(string username, string password, string fullName, string email, string contactNumber, string address, string positions)
        {
            string query = "INSERT INTO account (Username, [Password], FullName, Email, ContactNumber, Address, [Positions], AccountType, RegisterDate ) VALUES " +
                "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}' )";
            
            string accountType = positions.ToLower() == "admin staff" ? "administrator" : "cashier";
            string today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            return SQLQuery.executeQuery(string.Format(query, username, password, fullName, email, contactNumber, address, positions, accountType, today));
        }

        public bool UpdateAccount(string username, string password, string fullName, string email, string contactNumber, string address, string positions, int iD)
        {
            string query = "UPDATE account SET " +
                "Username = '{0}', " +
                "[Password] = '{1}', " +
                "FullName = '{2}', " +
                "Email = '{3}', " +
                "ContactNumber = '{4}', " +
                "Address = '{5}', " +
                "[Positions] = '{6}', " +
                "AccountType = '{7}' " +
                "WHERE ID = {8}";

            string accountType = positions.ToLower() == "admin staff" ? "administrator" : "cashier";
            return SQLQuery.executeQuery(string.Format(query, username, password, fullName, email, contactNumber, address, positions, accountType, iD));
        }


        public bool DeleteAccount(int ID) {
            string query = "DELETE FROM account WHERE ID = {0}";
            return SQLQuery.executeQuery(string.Format(query, ID));
        }
    }
}
