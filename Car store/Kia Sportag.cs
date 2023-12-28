using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Kia_Sportag : Kia
    {
        private string[] colors = new string[2];
        public int Kia_Sportag_quantity;
        private string engine_power;
        private string ID;
        public int Kia_Sportag_money;
        public Kia_Sportag()
        {
            model = "Kia_Sportag";
            colors[0] = "black";
            colors[1] = "white";
            Kia_Sportag_quantity = 4;
            engine_power = "290 HP";
            Kia_Sportag_money = 32974;
            ID = "987KS440KAL892008";
        }
        public override void Kia_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Kia_Sportag_quantity} \n Engine power: {engine_power} \n Money{Kia_Sportag_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
