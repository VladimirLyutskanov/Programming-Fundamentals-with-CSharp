using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> numbers = new List<string>();
            foreach (var str in symbols)
            {
                numbers.Add(str);

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
