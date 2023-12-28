using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Lamborghini_Urus : Lamborghini
    {
        private string[] colors = new string[3];
        public int Lamborghini_Urusn_quantity;
        private string engine_power;
        private string ID;
        public int Lamborghini_Urus_money;
        public Lamborghini_Urus()
        {
            model = "Lamborghini_Urus";
            colors[0] = "black";
            colors[1] = "blue";
            colors[2] = "yelow";
            Lamborghini_Urusn_quantity = 4;
            engine_power = "690 HP";
            Lamborghini_Urus_money = 100000;
            ID = "987LH440LAC892008";
        }
        public override void Lamborghini_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Lamborghini_Urusn_quantity} \n Engine power: {engine_power} \n Money: {Lamborghini_Urus_money} \n ID: {ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
