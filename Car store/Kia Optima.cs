using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Kia_Optima : Kia
    {
        private string[] colors = new string[1];
        public int Kia_Optima_quantity;
        private string engine_power;
        private string ID;
        public int Kia_Optima_money;
        public Kia_Optima()
        {
            model = "Kia_Optima";
            colors[0] = "black";
            Kia_Optima_quantity = 2;
            engine_power = "200 HP";
            Kia_Optima_money = 24974;
            ID = "988KO440KAL899008";
        }
        public override void Kia_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Kia_Optima_quantity} \n Engine power: {engine_power} \n Money{Kia_Optima_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
