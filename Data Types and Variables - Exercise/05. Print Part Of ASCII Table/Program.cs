using System;

namespace _05._PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());



            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}