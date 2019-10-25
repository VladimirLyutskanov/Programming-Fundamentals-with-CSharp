using System;

namespace vendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                sum += coins;
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    sum -= coins;
                }
                command = Console.ReadLine();


            }

            string items = Console.ReadLine();
            double productPrice = 0;

            while (items != "End")
            {
                if (items == "Nuts")
                {
                    productPrice = 2;

                }
                if (items == "Water")
                {
                    productPrice = 0.7;

                }
                if (items == "Crisps")
                {
                    productPrice = 1.5;

                }
                if (items == "Soda")
                {
                    productPrice = 0.8;

                }
                if (items == "Coke")
                {
                    productPrice = 1;

                }
                if (items != "Nuts" && items != "Water" && items != "Crisps" && items != "Soda" && items != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                sum -= productPrice;

                if (items == "Nuts" || items == "Water" || items == "Crisps" || items == "Soda" || items == "Coke")
                {
                    Console.WriteLine($"Purchased {items.ToLower()}");
                }
                if (sum < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    sum += productPrice;
                }

                items = Console.ReadLine();

            }
            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
