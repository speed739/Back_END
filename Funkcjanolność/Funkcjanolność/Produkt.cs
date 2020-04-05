using Microsoft.Data.SqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace Funkcjonalności
{
    class Produkty : DBconnection
    {
        int IDproduktu { get; set; }
        int Wycofany { get; set; }
        string NazwaProduktu { get; set; }
        double CenaJednostkowa { get; set; }

        public (int,double) Wybierz_Produkt()
        {
            var sql = "SELECT * FROM mg.Produkty WHERE IDproduktu = 18";
            var result = Connection().QuerySingle<Produkty>(sql);
            //Console.WriteLine($"ID - { result.IDproduktu}\n" +
            //                  $"Nazwa - { result.NazwaProduktu}\n" +
            //                  $"CenaJednostkowa - {result.CenaJednostkowa}");

            return (result.IDproduktu,result.CenaJednostkowa);
        }
    }

}

