using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int value = int.Parse (Console.ReadLine());

            Dictionary<string, int> output = new Dictionary<string, int>();
            while (true)
            {
                if (output.ContainsKey(command))
                {
                    output[command]+=value;
                }
                else
                {
                    output[command]=value;
                }
              

                command = Console.ReadLine();
                if (command=="stop")
                {
                    break;
                }
                value = int.Parse(Console.ReadLine());
            }

            foreach (var item in output.OrderBy(x=> x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
