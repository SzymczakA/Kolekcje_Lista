using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Lista
{
    class Element
    {
        public Element(Osoba dane_, Element adresNastepnego_)
        {
            Dane = dane_;
            AdresNastepnego = adresNastepnego_;
        }


        private Osoba dane;
        private Element adresNastepnego;


        public Osoba Dane
        {
            get
            {
                return dane;
            }

            set
            {
                dane = value;
            }
        }
        public Element AdresNastepnego
        {
            get
            {
                return adresNastepnego;
            }

            set
            {
                adresNastepnego = value;
            }
        }

        public void WypiszDane()
        {
            dane.Wypisz();
        }
    }
}
