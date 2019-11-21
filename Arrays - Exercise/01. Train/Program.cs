using System;
using System.Linq;

namespace _01.train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(numbers.Sum());

        }
    }
}