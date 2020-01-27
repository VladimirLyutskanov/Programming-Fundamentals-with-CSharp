using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            Dictionary<string, double> orders = new Dictionary<string, double>();

            Dictionary<string, double> oldProducts = new Dictionary<string, double>();

            

            while (true)
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);


                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, price * quantity);
                    oldProducts.Add(product, quantity);
                }
                else
                {
                    oldProducts[product] += quantity;
                    orders[product]= oldProducts[product] * price;
                }


                input = Console.ReadLine().Split();

                if (input[0] == "buy")
                {
                    break;
                }

            
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
         
        
        }

        
    }
}
