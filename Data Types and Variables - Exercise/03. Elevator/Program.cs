using System;

namespace _03.elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double volume = double.Parse(Console.ReadLine());

            double courses = Math.Ceiling(people / volume);
            Console.WriteLine(courses);
        }
    }
}
