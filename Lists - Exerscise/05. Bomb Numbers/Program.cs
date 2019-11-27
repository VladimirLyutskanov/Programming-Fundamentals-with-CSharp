using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numberToDetonateAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int digit = numberToDetonateAndPower[0];
            int power = numberToDetonateAndPower[1];

            int start = 0;
            int final = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == digit)
                {
                    start = i - power;
                    if (start < 0)
                    {
                        start = 0;
                    }
                    final = i + power;
                    if (final > numbers.Count - 1)
                    {
                        final = numbers.Count - 1;
                    }
                    for (int j = start; j <= final; j++)
                    {
                        numbers[j] = 0;
                    }

                }
            }


            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}
