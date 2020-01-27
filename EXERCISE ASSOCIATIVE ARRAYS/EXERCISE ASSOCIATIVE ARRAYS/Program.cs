using System;
using System.Collections.Generic;
using System.Linq;

namespace EXERCISE_ASSOCIATIVE_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputline = "";

            var products = new Dictionary<string, double>();
            //name} {price} {quantity}

            while ((inputline = Console.ReadLine())!="buy")
            {
                string[] input = inputline.Split();
                string type = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!products.ContainsKey(type))
                {
                    products[type] = quantity;
                }
                else if(products.ContainsKey(type))
                {
                    
                }

            }

        }
    }
}
