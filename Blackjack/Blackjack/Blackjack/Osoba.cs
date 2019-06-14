using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Osoba
    {
        private string imie;

        public string Imie { get => imie; set => imie = value; }

        private string funkcja;
        public string Funkcja { get => funkcja; set => funkcja = value; }

        private List<Karta> karty;

        public List<Karta> Karty { get => karty; set => karty = value; }

        private int suma;
        public int Suma { get => suma; set => suma = value; }

        private bool jestAs = false;
        public bool JestAs { get => jestAs; set => jestAs = value; }

        public Osoba(string imie, string funkcja)
        {
            this.imie = imie;
            this.funkcja = funkcja;
        }

        
    }
}
