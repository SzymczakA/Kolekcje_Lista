using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Lista
{
    class Lista
    {


        private Element pierwszyElement = null;
        private int liczbaElementow = 0;

        public int LiczbaElementow
        {
            get
            {
                return liczbaElementow;
            }

            set
            {
                liczbaElementow = value;
            }
        }

        public void Dodaj(Osoba dane_)
        {
            Element tmpDodawany = new Element(dane_, null);
            Element tmp = pierwszyElement;
            if (pierwszyElement == null)
            {
                pierwszyElement = tmpDodawany;

            }
            else
            {
                while (tmp.AdresNastepnego != null)
                {
                    tmp = tmp.AdresNastepnego;
                }
                tmp.AdresNastepnego = tmpDodawany;
            }
            liczbaElementow++;
        }
        public void Wstaw(Osoba dane_, int index_)
        {
            Element tmpDodawany = new Element(dane_, null);
            if (index_ == 0)
            {
                tmpDodawany.AdresNastepnego = pierwszyElement;
                pierwszyElement = tmpDodawany;
                liczbaElementow++;
            }
            if (0 < index_ && index_ < liczbaElementow)
            {
                Element tmp = PobierzRef(index_ - 1);
                tmpDodawany.AdresNastepnego = tmp.AdresNastepnego;
                tmp.AdresNastepnego = tmpDodawany;
                liczbaElementow++;
            }

        }
        public void Wypisz()
        {
            Element tmp = pierwszyElement;
            for (int i = 0; i < liczbaElementow; i++)
            {
                tmp.WypiszDane();
                tmp = tmp.AdresNastepnego;
            }
        }
        public Osoba Pobierz(int index_)
        {
            
            if (index_ == 0)
            {
                Osoba tmpDane = pierwszyElement.Dane;
                pierwszyElement = pierwszyElement.AdresNastepnego;
                liczbaElementow--;
                return tmpDane;
            }
            if (0 < index_ && index_ < liczbaElementow)
            {
                Element tmp = PobierzRef(index_ - 1);
                Osoba tmpDane = tmp.AdresNastepnego.Dane;
                if (tmp.AdresNastepnego != null) tmp.AdresNastepnego = tmp.AdresNastepnego.AdresNastepnego;
                liczbaElementow--;
                return tmpDane;
            }
                return null;
        }
        Element PobierzRef(int index_)
        {
            Element tmp = pierwszyElement;
            for (int i = 0; i < index_; i++)
            {
                tmp = tmp.AdresNastepnego;
            }
            return tmp;
        }

    }
}
