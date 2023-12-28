using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Lamborghini_Aventado : Lamborghini
    {
        private string[] colors = new string[3];
        public int Lamborghini_Aventado_quantity;
        private string engine_power;
        private string ID;
        public int Lamborghini_Aventado_money;
        public Lamborghini_Aventado()
        {
            model = "Lamborghini_Aventado";
            colors[0] = "black";
            colors[1] = "red";
            colors[2] = "green";
            Lamborghini_Aventado_quantity = 4;
            engine_power = "690 HP";
            Lamborghini_Aventado_money = 200000;
            ID = "987LA440LAC892008";
        }
        public override void Lamborghini_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Lamborghini_Aventado_quantity} \n Engine power: {engine_power} \n Money{Lamborghini_Aventado_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
