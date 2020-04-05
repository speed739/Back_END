using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Funkcjonalności
{
    class Zamowienia : PozycjeZamowienia
    {

        DateTime data_zam = DateTime.Now;
        Random godz = new Random();
        public void Koszyk(IDbConnection connection, User a)
        {
            var sql = "INSERT INTO Zamówienia(IDzamówienia,IDklienta," +
                "DataZamówienia,DataWysyłki,NazwaOdbiorcy," +
                "AdresOdbiorcy,MiastoOdbiorca,KrajOdbiorcy)" +
                " VALUES(@id_zam,@id_kli,@data_zam,@data_wys,@naz_od,@ad_od,@mi_od,@kr_od)";

            var command = connection.Execute(sql,
                new
                {
                    id_zam = ,
                    id_kli = a.ID,
                    data_zam = data_zam.Date,
                    data_wys = data_zam.AddHours(godz.Next(5, 48)),
                    naz_od = $"{a.Imie} {a.Nazwisko}",
                    ad_od = a.Adres,
                    mi_od = a.Miasto,
                    kr_od = a.Kraj
                });
        }
    }
}
