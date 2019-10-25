using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int scroll = 0;

            for (int j = number; j > 0; j--)
            {
                scroll++;

                for (int i = 1; i <= scroll; i++)
                {
                    Console.Write(scroll + " ");
                    if (i == scroll)
                    {
                        Console.WriteLine();
                    }

                }

            }

        }
    }
}
