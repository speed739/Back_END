using System;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Funkcjonalności
{
    class Program
    {
        static void Main(string[] args)
        {
            DBconnection conn = new DBconnection();
            Produkty x = new Produkty();


            Console.WriteLine("ID produktu - " + x.Wybierz_Produkt().Item1);
            Console.WriteLine("Cena Jednostkowa - " + x.Wybierz_Produkt().Item2);
            x.Connection().Close();

        }
    }
}
