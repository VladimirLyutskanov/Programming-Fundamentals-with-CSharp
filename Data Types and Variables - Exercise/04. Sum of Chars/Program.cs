using System;

namespace _04._sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < number; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumOfChars += symbol;

            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
