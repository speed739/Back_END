using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funkcjonalności
{
    public class DBconnection
    {
        static string connectionString =
                       @"Data Source=DESKTOP-MA3N1EE\SQLEXPRESS;
                    Initial Catalog=ZNorthwind;Integrated Security=True;
                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
