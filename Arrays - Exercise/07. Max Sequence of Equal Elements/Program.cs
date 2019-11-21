using System;
using System.Linq;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int bestCount = 0;
            int firstIndexindex = 0;
            int index = 0;

            for (int i = 0; i < input.Length; i++)

            {
                int count = 1;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                        index = i;
                        if (count > bestCount)
                        {
                            firstIndexindex = index;
                            bestCount = count;

                        }
                    }
                    else
                    {

                        break;
                    }
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{input[firstIndexindex] + " "}");
            }

        }
    }
}
