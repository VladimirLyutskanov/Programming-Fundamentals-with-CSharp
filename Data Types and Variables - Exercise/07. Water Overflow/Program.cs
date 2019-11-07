using System;

namespace _07._WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int sumOfLitres = 0;

            for (int i = 0; i < lines; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sumOfLitres += litres;

                if (sumOfLitres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLitres -= litres;
                }


            }
            Console.WriteLine(sumOfLitres);
        }
    }
}
