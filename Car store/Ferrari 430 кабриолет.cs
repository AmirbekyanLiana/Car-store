using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Ferrari_430_кабриолет : Ferrari
    {
        private string[] colors = new string[3];
        public int Ferrari_430_кабриолет_quantity;
        private string engine_power;
        private string ID;
        public int Ferrari_430_кабриолет_money;
        public Ferrari_430_кабриолет()
        {
            model = "Ferrari_430_кабриолет";
            colors[0] = "yelow";
            colors[1] = "red";
            colors[2] = "blue";
            Ferrari_430_кабриолет_quantity = 4;
            engine_power = "490 HP";
            Ferrari_430_кабриолет_money = 180974;
            ID = "586FK480KJL872008";
        }
        public override void Ferrari_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Ferrari_430_кабриолет_quantity} \n Engine power: {engine_power} \n Money{Ferrari_430_кабриолет_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", " );
            }
            Console.WriteLine();
        }
    }
}
