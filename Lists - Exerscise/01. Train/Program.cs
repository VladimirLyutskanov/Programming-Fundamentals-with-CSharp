using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                int wagonsToAdd = 0;
                int peopleToAdd = 0;
                if (command.Count == 2)
                {
                    wagonsToAdd = int.Parse(command[1]);
                    wagons.Add(wagonsToAdd);
                }
                if (command.Count == 1)
                {
                    peopleToAdd = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + peopleToAdd <= maxCapacity)
                        {
                            wagons[i] += peopleToAdd;
                            break;
                        }

                    }
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
