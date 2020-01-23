using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> rooms = Console.ReadLine().Split("|").ToList();

            int health = 100;
            int coins = 0;
            int count = 1;

            for (int i = 0; i < rooms.Count; i++)
            {

                var command = rooms[i].Split();
                int numberTo = int.Parse(command[1]);
                if (command[0] == "potion")
                {
                    int currentHealth = health;
                    health += numberTo;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {health - currentHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command[0] == "chest")
                {
                    coins += numberTo;
                    Console.WriteLine($"You found {numberTo} coins.");
                }
                else
                {
                    health -= numberTo;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {count}");
                        return;
                    }
                }

                count++;
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
