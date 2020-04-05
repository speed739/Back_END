using System;
using System.Collections.Generic;
using System.Text;

namespace Funkcjonalności
{
    class User
    {
        public string ID, NazwaFirmy, Imie, Nazwisko, Adres, Miasto, Kod_Pocztowy, Kraj, Telefon;
        string Haslo;
        public User(string nazwafirmy, string imie, string nazwisko, string miasto,
            string adres, string kod_Pocztowy, string kraj, string telefon)
        {
            NazwaFirmy = nazwafirmy;
            Imie = imie;
            Nazwisko = nazwisko;
            ID = (Imie.Remove(3) + Nazwisko.Remove(2)).ToUpper();
            Adres = adres;
            Miasto = miasto;
            Kod_Pocztowy = kod_Pocztowy;
            Kraj = kraj;
            Telefon = telefon;
            Haslo = ID;
        }
        public bool Zwroc_haslo(string a)
        {
            if (Haslo == a)
            {
                return true;
            }
            return false;
        }
    }
}
