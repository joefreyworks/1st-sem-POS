using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pos.common
{
    public static class SQLQuery
    {
        private static string CONNECTION_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\resources\Database.accdb;Persist Security Info=False;";

        public static DataTable GetData(string query)
        {
            DataTable result = new DataTable();
            using (var conn = new OleDbConnection(CONNECTION_STRING))
            {
                conn.Open();
                using (var da = new OleDbDataAdapter(query, conn))
                    da.Fill(result);
                if(conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        public static bool executeQuery(string query)
        {
            var result = false;
            using (var conn = new OleDbConnection(CONNECTION_STRING))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                {
                    result = cmd.ExecuteNonQuery() > 0;
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        public static bool checkQuery(string query)
        {
            var result = false;
            using (var conn = new OleDbConnection(CONNECTION_STRING))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                {
                    var dr = cmd.ExecuteReader();
                    result = dr.HasRows;
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
    }
}
