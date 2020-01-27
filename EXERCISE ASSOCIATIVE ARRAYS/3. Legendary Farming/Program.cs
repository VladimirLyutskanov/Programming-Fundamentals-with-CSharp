using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>();

            dict["fragments"] = 0;
            dict["motes"] = 0;
            dict["shards"] = 0;

            var jumkElements = new Dictionary<string, int>();
            bool haveWinner = false;

            while (true)
            {
                if (dict["motes"]>=250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    dict["motes"] -= 250;
                }
                if (dict["fragments"] >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    dict["fragments"] -= 250;
                }
                if (dict["shards"] >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    dict["shards"] -= 250;
                }

                if (haveWinner)
                {
                    break;
                }
                var tokens = Console.ReadLine().ToLower().Split().ToArray();
                for (int i = 0; i < tokens.Length; i+=2)
                {

                    string type = tokens[i + 1];
                    int quantity = int.Parse(tokens[i]);

                    if (dict.ContainsKey(type))
                    {
                        dict[type] += quantity;
                        if (dict[type]>=250)
                        {
                            
                            haveWinner = true;
                            break;
                        }
                    }
                    else
                    {
                        if (jumkElements.ContainsKey(type))
                        {
                            jumkElements[type] += quantity;
                        }
                        else
                        {
                            jumkElements.Add(type, quantity);    
                        }


                    }

                  
                }

             

            }
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in jumkElements.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
          

        }
    }
}
