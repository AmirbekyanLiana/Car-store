using System;

namespace Car_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------Welkom to car store------------------------------------------");
            for (; ; )
            {
                Buyer buyer = new Buyer();
                buyer.Purchase();
                Console.WriteLine("Make purchases");
                buyer.buy = Console.ReadLine();
                buyer.Buy();
            }   
        }
    }
}
