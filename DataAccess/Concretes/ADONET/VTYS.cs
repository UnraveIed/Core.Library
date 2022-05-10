using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes.ADONET
{
    public class VTYS
    {
        private static string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=LastLibraryDb; Trusted_Connection=true";
        public static bool SqlExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
                return true;
            }
            catch(Exception ex)
            {
                var excep = ex;
                return false;
            }
        }

        public static SqlDataReader SqlExecuteReader(SqlCommand cmd)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            cmd.Connection = conn;
            return cmd.ExecuteReader();
        }
    }
}

