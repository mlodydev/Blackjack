using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Model
    {
        Talia talia = new Talia();

        Osoba gracz = new Osoba("michal", "gracz");

        Osoba krupier = new Osoba("krupier", "krupier");

        public Model()
        {
            PierwszeRozdanie();
        }

        public void PierwszeRozdanie()
        {
            this.gracz.Karty = talia.WydajKarty(2);
            this.krupier.Karty = talia.WydajKarty(2);
        }

        public void liczSume()
        {
                foreach (Karta karta in gracz.Karty)
                {
                    gracz.Suma += karta.Wartosc;
                }
            
                foreach (Karta karta in krupier.Karty)
                {
                    krupier.Suma += karta.Wartosc;
                }
        }

        public int sumaKrupiera()
        {
            int suma = 0;
            foreach (Karta karta in krupier.Karty)
            {
                suma += karta.Wartosc;
            }
            return suma;
        }

        public string kartyGraczaString()
        {

            string karty = "";
            foreach (Karta karta in gracz.Karty)
            {
                karty += karta.ToString();
                karty += " ";
            }
            return karty;
        }

        public string kartyKrupieraZakryteString()
        {

            /*string karty = "";
            foreach (Karta karta in krupier.Karty)
            {
                karty += karta.ToString();
                karty += " ";
            }
            return karty;*/
            return krupier.Karty.ElementAt(0) + " x x";
        }

        public string kartyKrupieraString()
        {
            string karty = "";
            foreach (Karta karta in krupier.Karty)
            {
                karty += karta.ToString();
                karty += " ";
            }
            return karty;
        }

        public void dobieraGracz()
        {
            Karta nowaKarta = talia.WydajKarte();
            this.gracz.Karty.Add(nowaKarta);
        }

        public void dobieraKrupier()
        {
            Karta nowaKarta = talia.WydajKarte();
            this.krupier.Karty.Add(nowaKarta);
        }

        public bool bustedGracz()
        {
            bool czykoniec = false;
            if (gracz.Suma > 21)
            {
                foreach (Karta karta in gracz.Karty)
                {
                    if (karta.Figura == "A")
                        karta.Wartosc = 1;
                }
                liczSume();
            }
                return czykoniec;
        }

        public bool bustedKrupier()
        {
            bool czykoniec = false;
            if (gracz.Suma > 21)
            {
                foreach (Karta karta in krupier.Karty)
                {
                    if (karta.Figura == "A")
                        karta.Wartosc = 1;
                }
                liczSume();
            }
            return czykoniec;
        }

        public int ilekart()
        {
            return gracz.Karty.Count();
        }

        public bool czytokoniec()
        {
            bool decyzja = bustedGracz();
            decyzja = bustedKrupier();
            return false;
        }
        public string ktoWygral()
        {
            string zwyciezca = "";

            if (gracz.Suma > krupier.Suma)
                zwyciezca = "wygrales";
            else if (gracz.Suma == krupier.Suma)
                zwyciezca = "remis";
            else
                zwyciezca = "przegrales";

            return zwyciezca;
        }
        
    }
}
