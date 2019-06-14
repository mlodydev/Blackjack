using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Talia
    {
        private List<Karta> karty;
        internal List<Karta> Karty { get => karty; set => karty = value; }

        private List<string> kolory = new List<string> { "Karo", "Pik", "Kier", "Trefl" };

        private List<string> figury = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "D", "K", "J" };

        private int iloscKart = 52;

        public int IloscKart { get => iloscKart; set => iloscKart = value; }

        public Talia()
        {
            karty = nowaTalia(kolory, figury);
        }

        public static List<Karta> nowaTalia(List<string> kolory, List<string> figury)
        {
            List<Karta> karty1 = new List<Karta> { };
            // pętla tworzy talię kart
            foreach (string kolor in kolory)
            {
                int wartoscKarty = 2;
                foreach (string figura in figury)
                {
                    karty1.Add(new Karta(kolor, figura, wartoscKarty));
                    wartoscKarty++;
                    if (wartoscKarty > 11) wartoscKarty = 10;
                }
            }
            return karty1;
        }
        public List<Karta> WydajKarty(int ileKart)
        {
            List<Karta> kartki = new List<Karta> { };
            Random random = new Random();

            for (int i = 0; i < ileKart; i++)
            {
                int index = random.Next(iloscKart);
                kartki.Add(this.Karty.ElementAt(index));
                Karty.RemoveAt(index);
                iloscKart -= 1;
            }
            return kartki;
        }
        public Karta WydajKarte()
        {
            Random random = new Random();
            int index = random.Next(iloscKart);
            Karta kartka = this.Karty.ElementAt(index);
            Karty.RemoveAt(index);
            iloscKart -= 1;
            return kartka; 
        }
    }
}
