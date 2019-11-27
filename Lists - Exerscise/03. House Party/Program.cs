using System;
using System.Collections.Generic;
using System.Linq;

namespace just_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();


            int cicles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cicles; i++)
            {

                List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = input[0];
                if (input[2] == "going!")
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }

                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
