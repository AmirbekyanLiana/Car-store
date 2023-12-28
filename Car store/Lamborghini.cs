using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Lamborghini
    {
        protected string model;
        public virtual void Lamborghini_Info()
        {
            Console.WriteLine("Lamborghini models");
        }
        public void Lamborghini_purchase(int buyer_money, Lamborghini_Aventado Lamborghini_Aventado, Lamborghini_Huracan Lamborghini_huracan, Lamborghini_Urus Lamborghini_urus)
        {
            if (buyer_money > Lamborghini_Aventado.Lamborghini_Aventado_money)
            {
                Lamborghini_Aventado.Lamborghini_Info();
            }
            if (buyer_money > Lamborghini_huracan.Lamborghini_Huracan_money)
            {
                Lamborghini_huracan.Lamborghini_Info();
            }
            if (buyer_money > Lamborghini_urus.Lamborghini_Urus_money)
            {
                Lamborghini_urus.Lamborghini_Info();
            }
            else
            {
                Console.WriteLine("I'm sorry you don't have much money");
            }
        }
    }
}
