using System;

namespace printAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = first; i <= second; i++)
            {
                total += i;
                if (i == second)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.Write(i + " ");


            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
