using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Buyer
    {
        public string buy;
        public int Buyer_money;
        public string brend;
        public Buyer()
        {
            Console.WriteLine("What brand of car do you want");
            brend = Console.ReadLine();
            Console.WriteLine("How much money do you have?");
            Buyer_money = Convert.ToInt32(Console.ReadLine());
        }
        public void Purchase()
        {
            if (brend == "Ferrari")
            {
                Ferrari ferrari_models = new Ferrari();
                Ferrari_Purosangue ferrari_purosangue = new Ferrari_Purosangue();
                Ferrari_430_кабриолет ferrari_430_кабриолет = new Ferrari_430_кабриолет();
                Ferrari_F8_Tributo ferrari_f8_Tributo = new Ferrari_F8_Tributo();
                ferrari_models.Ferrari_Info();
                ferrari_models.Ferrari_purchase(Buyer_money, ferrari_purosangue, ferrari_430_кабриолет, ferrari_f8_Tributo);
            }
            else if (brend == "Kia")
            {
                Kia kia_models = new Kia();
                Kia_Forte kia_forte = new Kia_Forte();
                Kia_Optima kia_Optima = new Kia_Optima();
                Kia_Sportag Kia_Sportag = new Kia_Sportag();
                kia_models.Kia_Info();
                kia_models.Kia_purchase(Buyer_money, kia_forte, kia_Optima, Kia_Sportag);
            }
            else if (brend == "Lamborghini")
            {
                Lamborghini Lamborghini_models = new Lamborghini();
                Lamborghini_Aventado ob1 = new Lamborghini_Aventado();
                Lamborghini_Huracan ob2 = new Lamborghini_Huracan();
                Lamborghini_Urus ob3 = new Lamborghini_Urus();
                Lamborghini_models.Lamborghini_Info();
                Lamborghini_models.Lamborghini_purchase(Buyer_money, ob1, ob2, ob3);
            }            
        }
        public void Buy()
        {
            if (buy == "ferrari purosangue")
            {
                Ferrari_Purosangue ferrari_purosangue = new Ferrari_Purosangue();
                ferrari_purosangue.Ferrari_Purosangue_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Ferrari 430 кабриолет")
            {
                Ferrari_430_кабриолет ferrari_430_кабриолет = new Ferrari_430_кабриолет();
                ferrari_430_кабриолет.Ferrari_430_кабриолет_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Ferrari F8 Tributo")
            {
                Ferrari_F8_Tributo ferrari_F8_Tributo = new Ferrari_F8_Tributo();
                ferrari_F8_Tributo.Ferrari_F8_Tributo_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Kia Forte")
            {
                Kia_Forte kia_forte = new Kia_Forte();
                kia_forte.Kia_Forte_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "kia Optima")
            {
                Kia_Optima kia_Optima = new Kia_Optima();
                kia_Optima.Kia_Optima_money--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Kia Sportag")
            {
                Kia_Sportag Kia_Sportag = new Kia_Sportag();
                Kia_Sportag.Kia_Sportag_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Lamborghini Aventado")
            {
                Lamborghini_Aventado Lamborghini_Aventado = new Lamborghini_Aventado();
                Lamborghini_Aventado.Lamborghini_Aventado_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Lamborghini Huracan")
            {
                Lamborghini_Huracan Lamborghini_Huracan = new Lamborghini_Huracan();
                Lamborghini_Huracan.Lamborghini_Huracan_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
            if (buy == "Lamborghini Urus")
            {                
                Lamborghini_Urus Lamborghini_Urus = new Lamborghini_Urus();
                Lamborghini_Urus.Lamborghini_Urusn_quantity--;
                Console.WriteLine("Thank you for your purchase!");
            }
        }
    }
}
