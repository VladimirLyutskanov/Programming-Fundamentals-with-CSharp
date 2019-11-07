using System;

namespace _08._beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestCan = int.MinValue;
            string biggest = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;
                if (volume > biggestCan)
                {
                    biggestCan = volume;
                    biggest = model;

                }


            }
            Console.WriteLine(biggest);



        }
    }
}
