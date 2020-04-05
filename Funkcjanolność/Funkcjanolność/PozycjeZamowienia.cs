using System;
using Dapper;
using System.Data;

namespace Funkcjonalności
{
    class PozycjeZamowienia : Produkty
    {
        public int IDzamówienia { get; set; }
        int Ilosc { get; set; }

        public void Nowa_Pozycja_Zamowienia(IDbConnection connection)
        {
            var sql = "INSERT INTO PozycjeZamówienia(IDzamówienia,IDproduktu," +
                         "CenaJednostkowa,Ilość VALUES(@id_zam,@id_pr,@cena,@ilosc)";
            var command = connection.Execute(sql,
                        new
                        {
                            id_zam = Id_Generator(connection),
                            id_pr = Wybierz_Produkt().Item1,
                            cena = Wybierz_Produkt().Item2,
                            ilosc = Ilosc
                        });
        }
        int Id_Generator(IDbConnection connection)
        {
            var sql = "SELECT top 1 * FROM Zamówienia order by IDzamówienia DESC";
            var command = connection.QuerySingle<PozycjeZamowienia>(sql);

            if (true) //Warunek konczacy zamowienie
            {
                return ++command.IDzamówienia;
            }
            else
            {
                return command.IDzamówienia;
            }
        }
    }
}
