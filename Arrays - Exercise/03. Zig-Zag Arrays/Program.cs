using System;
using System.Linq;

namespace _03._zigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArrays = int.Parse(Console.ReadLine());

            int[] left = new int[numberOfArrays];
            int[] right = new int[numberOfArrays];


            for (int i = 0; i < numberOfArrays; i++)
            {
                int[] currenArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    left[i] = currenArr[0];
                    right[i] = currenArr[1];
                }
                else
                {
                    left[i] = currenArr[1];
                    right[i] = currenArr[0];
                }



            }
            Console.WriteLine(string.Join(" ", left));

            Console.WriteLine(string.Join(" ", right));
        }
    }
}
