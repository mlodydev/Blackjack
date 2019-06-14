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

        public int ilekart()
        {
            return gracz.Karty.Count();
        }
    }
}
