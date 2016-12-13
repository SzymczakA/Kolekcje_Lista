using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Lista
{
    class Osoba
    {
        public Osoba() { }
        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }


        private string imie;
        private string nazwisko;


        public void Wypisz()
        {
            Console.WriteLine(imie + " " + nazwisko);
        }
    }
}
