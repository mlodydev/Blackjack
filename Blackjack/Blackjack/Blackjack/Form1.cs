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
        public event Action Trzymaj;
        //public event Action Start;

        private void button1Dobieraj_click(object sender, EventArgs e)
        {
            if (Dobieraj != null)
            {
                Dobieraj();
            }
        }

        private void Button2Trzymaj_Click(object sender, EventArgs e)
        {
            if (Trzymaj != null)
            {
                Trzymaj();
            }
        }

        private void Button3Start_Click(object sender, EventArgs e)
        {
            
        }
    }
}
