using System;
using System.Linq;

namespace _08._magicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());
            int newSum = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length - 1; j++)
                {

                    newSum = nums[i] + nums[j + 1];
                    if (newSum == sum)
                    {
                        Console.WriteLine($"{nums[i] + " "}{nums[j + 1]}");


                    }

                }

            }

        }
    }
}
