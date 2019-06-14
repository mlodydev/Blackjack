using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Presenter
    {
        Model model;
        IViev viev;

        public Presenter(Model model, IViev viev)
        {
            this.model = model;
            this.viev = viev;

            bool czykoniec = false;
            //while (czykoniec == false)
            //{
                model.PierwszeRozdanie();

                viev.kartyGracza = model.kartyGraczaString();
                viev.kartyKrupiera = model.kartyKrupieraZakryteString();
                model.liczSume();
                czykoniec = model.bustedGracz();
                this.viev.Dobieraj += Dobieranie;
                this.viev.Trzymaj += Trzymanie;



                //usun ponizej, nieskonczona petla by byla
                czykoniec = true;
            //}

        }

        private void Dobieranie()
        {
            if(model.ilekart() < 3)
            {
                model.dobieraGracz();
                viev.kartyGracza = model.kartyGraczaString();
                Console.WriteLine("powinno banglac");
            }
            model.liczSume();
            if (model.sumaKrupiera() <= 16)
            {
                model.dobieraKrupier();
            }
            viev.kartyKrupiera = model.kartyKrupieraString();
        }
        private void Trzymanie()
        {
            model.liczSume();
            Console.WriteLine("dziala");
            viev.kartyGracza = model.ktoWygral();
        }
    }
}
