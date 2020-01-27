using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> clients = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string command = input[0];
                string name = input[1];
                if (command == "register")
                {
                    string regNumber = input[2];
                    if (!clients.ContainsKey(name))
                    {
                        clients.Add(name, regNumber);
                        Console.WriteLine($"{name} registered {regNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {regNumber}");
                    }
                }
                else
                {
                    if (!clients.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        clients.Remove(name);
                    }
                }
            }

            foreach (var kvp in clients)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
