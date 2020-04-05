using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funkcjonalności
{
    class System_Logowania
    {
        public void Logowanie(SqlConnection connection)
        {
            string id, haslo, sql;

            Console.Write("Logowanie:\nPodaj Id - ");
            id = Console.ReadLine();
            Console.Write("Podaj haslo ");
            haslo = Console.ReadLine();

            sql = "SELECT COUNT(*) FROM Klienci WHERE IDklienta = @Id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", id);
            int results = (int)command.ExecuteScalar();

            if (results > 0)
            {
                Console.WriteLine("ZALAGOWANO");

            }
            else
            {
                Console.WriteLine("Błędne dane logowania spruboj ponownie");
                Console.WriteLine("--------------------------------------");
                Logowanie(connection);
            }

        }
    }
}
