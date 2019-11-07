using System;

namespace _11._snowballs
{
    class Program
    {
        static void Main(string[] args)
        {



            int n = int.Parse(Console.ReadLine());
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            double bestValue = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= bestValue)
                {
                    bestValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");


        }
    }
}
