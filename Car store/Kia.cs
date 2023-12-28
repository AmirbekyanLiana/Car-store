using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Kia
    {
        protected string model;
        public virtual void Kia_Info()
        {
            Console.WriteLine("Kia models");
        }
        public void Kia_purchase(int buyer_money, Kia_Forte Kia_forte, Kia_Optima Kia_optima, Kia_Sportag Kia_sportag)
        {
            if (buyer_money > Kia_forte.Kia_Forte_money)
            {
                Kia_forte.Kia_Info();
            }
            if (buyer_money > Kia_optima.Kia_Optima_money)
            {
                Kia_optima.Kia_Info();
            }
            if (buyer_money > Kia_sportag.Kia_Sportag_money)
            {
                Kia_sportag.Kia_Info();
            }
            else
            {
                Console.WriteLine("I'm sorry you don't have much money");
            }
        }
    }
}
