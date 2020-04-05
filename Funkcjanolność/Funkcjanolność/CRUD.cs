using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Funkcjonalności
{
    class CRUD
    {
        public void Create(User a, SqlConnection connection)
        {
            string sql = "INSERT INTO ZNorthwind.dbo.Klienci(IDklienta,NazwaFirmy,Miasto,Adres,KodPocztowy,Kraj,Telefon)" +
                "VALUES (@id,@nazwafirmy,@miasto,@adres,@kodpocztowy,@kraj,@telefon)";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nazwafirmy", a.NazwaFirmy);
            command.Parameters.AddWithValue("@id", a.ID);
            command.Parameters.AddWithValue("@miasto", a.Miasto);
            command.Parameters.AddWithValue("@adres", a.Adres);
            command.Parameters.AddWithValue("@kodpocztowy", a.Kod_Pocztowy);
            command.Parameters.AddWithValue("@kraj", a.Kraj);
            command.Parameters.AddWithValue("@telefon", a.Telefon);
            command.ExecuteNonQuery();
        }
        public void Update(int id, string nowa_nazwa, SqlConnection connection)
        {
            string sql = "UPDATE ZNorthwind.dbo.Region SET RegionDescription = @regionName WHERE RegionID=@id";
            var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@regionName", nowa_nazwa);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

        }
        public void Delete(User a, SqlConnection connection)
        {
            string sql = "DELETE FROM ZNorthwind.dbo.Klienci WHERE IDklienta=@id";
            var command = new SqlCommand(sql, connection);
           
            command.Parameters.AddWithValue("@id", a.ID);
            command.ExecuteNonQuery();

        }

    }
}



