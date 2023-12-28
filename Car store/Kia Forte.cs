using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store
{
    class Kia_Forte : Kia
    {
        private string[] colors = new string[2];
        public int Kia_Forte_quantity;
        private string engine_power;
        private string ID;
        public int Kia_Forte_money;
        public Kia_Forte()
        {
            model = "Kia_Forte";
            colors[0] = "blue";
            colors[1] = "red";
            Kia_Forte_quantity = 2;
            engine_power = "250 HP";
            Kia_Forte_money = 34974;
            ID = "989KFO440KAL89908";
        }
        public override void Kia_Info()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Quantity: {Kia_Forte_quantity} \n Engine power: {engine_power} \n Money{Kia_Forte_money} \n ID{ID}");
            Console.Write("Colors: ");
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
