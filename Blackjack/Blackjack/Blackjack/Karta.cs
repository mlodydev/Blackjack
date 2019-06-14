using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Karta
    {
        private string kolor;
        public string Kolor { get => kolor; set => kolor = value; }

        private string figura;
        public string Figura { get => kolor; set => kolor = value; }

        private int wartosc;
        public int Wartosc { get => wartosc; set => wartosc = value; }

        public Karta(string kolor, string figura, int wartosc)
        {
            this.kolor = kolor;
            this.figura = figura;
            this.wartosc = wartosc;
        }
        public override string ToString()
        {
            return figura + " " + kolor;
        }
    }
}
