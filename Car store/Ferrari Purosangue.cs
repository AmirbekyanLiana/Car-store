using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Ferrari_Purosangue : Ferrari
    {
        private string[] colors = new string[3];
        public int Ferrari_Purosangue_quantity;
        private string engine_power;
        private string ID;
        public int Ferrari_Purosangue_money;
        public Ferrari_Purosangue()
        {
            model = "Ferrari_Purosangue";
            colors[0] = "orange";
            colors[1] = "green";
            colors[2] = "black";
            Ferrari_Purosangue_quantity = 3;
            engine_power = "610 HP";
            Ferrari_Purosangue_money = 196336;
            ID = "586FP480KJL882018";
        }
        public override void Ferrari_Info()
        {
            Console.WriteLine($" Model: {model}");
            Console.WriteLine($" Quantity: {Ferrari_Purosangue_quantity} \n Engine power: {engine_power} \n Money: {Ferrari_Purosangue_money}$ \n ID: {ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }                                      
}             
                                                                                                             