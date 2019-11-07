using System;

namespace ExerciseDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numToString = "" + number;
            int sum = 0;


            for (int i = 0; i < numToString.Length; i++)
            {
                int newValue = int.Parse(numToString[i] + "");
                sum += newValue;

            }
            Console.WriteLine(sum);

        }
    }
}