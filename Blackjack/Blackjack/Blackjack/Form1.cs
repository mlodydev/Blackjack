using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form, IViev
    {
        public Form1()
        {
            InitializeComponent();
            /*Talia talia = new Talia();
            Console.WriteLine(talia.IloscKart);
            List<Karta> trzykarty = talia.WydajKarty(3);
            foreach(Karta karta in trzykarty)
            {
                Console.WriteLine(karta.ToString());
            }*/


        }

        public string kartyGracza
        {
            set
            {
                textBox2Gracz.Text =value;
            }
        }

        public string kartyKrupiera
        {
            set
            {
                textBox1Krupier.Text =value;
            }
        }

        public event Action Dobieraj;
        //public event Action Trzymaj;
        //public event Action Start;

        private void button1Dobieraj_click(object sender, EventArgs e)
        {
            if (Dobieraj != null)
            {
                Dobieraj();
            }
        }

    }
}
