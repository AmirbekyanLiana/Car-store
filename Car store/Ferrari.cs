using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Ferrari
    {
        protected string model;
        public virtual void Ferrari_Info()
        {
            Console.WriteLine("Ferrari models");
        }
        public void Ferrari_purchase(int buyer_money, Ferrari_Purosangue ferrari_Purosangue, Ferrari_430_кабриолет ferrari_430_Кабриолет, Ferrari_F8_Tributo ferrari_F8_Tributo)
        {
            if (buyer_money > ferrari_Purosangue.Ferrari_Purosangue_money)
            {
                ferrari_Purosangue.Ferrari_Info();
            }
            if (buyer_money > ferrari_430_Кабриолет.Ferrari_430_кабриолет_money)
            {
                ferrari_430_Кабриолет.Ferrari_Info();
            }
            if (buyer_money > ferrari_F8_Tributo.Ferrari_F8_Tributo_money)
            {
                ferrari_F8_Tributo.Ferrari_Info();
            }
            else
            {
                Console.WriteLine("I'm sorry you don't have much money");
            }
        }
    }
}
