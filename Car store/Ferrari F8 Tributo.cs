using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Ferrari_F8_Tributo : Ferrari
    {
        private string[] colors = new string[3];
        public int Ferrari_F8_Tributo_quantity;
        private string engine_power;
        private string ID;
        public int Ferrari_F8_Tributo_money;
        public Ferrari_F8_Tributo()
        {
            model = "Ferrari_F8_Tributo";
            colors[0] = "orange";
            colors[1] = "white";
            colors[2] = "black";
            Ferrari_F8_Tributo_quantity = 3;
            engine_power = "710 HP";
            Ferrari_F8_Tributo_money = 200336;
            ID = "586FF8480KJL87200";
        }
        public override void Ferrari_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Ferrari_F8_Tributo_quantity} \n Engine power: {engine_power}$ \n Money{Ferrari_F8_Tributo_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
