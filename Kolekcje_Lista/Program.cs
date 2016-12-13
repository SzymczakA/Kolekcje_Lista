using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Alicja", "Nowak");
            Osoba o2 = new Osoba("Karolina", "Kowalska");
            Osoba o3 = new Osoba("Michal", "Jabłoński");
            Osoba o4 = new Osoba("Karol", "Wiśniewski");
            Lista l = new Lista();
            l.Dodaj(o);
            l.Dodaj(o2);
            l.Dodaj(o3);
            l.Dodaj(o4);
            l.Wypisz();
            l.Pobierz(2);
            l.Pobierz(0);
            l.Pobierz(1);
            l.Wypisz();
            l.Wstaw(o3, 0);
            l.Wstaw(o4, 1);
            l.Wstaw(o, 2);
            l.Wypisz();


            //List<Osoba> l = new List<Osoba>();
            //l.Add(o);
            //l.Add(o2);
            //l.Add(o3);
            //l.Add(o4);
            //l[2].Wypisz();
            //l[3].Wypisz();
            //l.Insert(2, o);
            //Console.ReadKey();
            //l[2].Wypisz();
            //l[3].Wypisz();
            //l[4].Wypisz();

            Console.ReadKey();

        }
    }
}
