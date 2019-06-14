using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    interface IViev
    {
        string kartyGracza { set; }
        string kartyKrupiera { set; }

        event Action Dobieraj;
        event Action Trzymaj;
        //event Action Start;
    }
}
