using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = double.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;


            if (people == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                if (day == "Saturday")
                {
                    price = 9.80;
                }
                if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            if (people == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                if (day == "Saturday")
                {
                    price = 15.60;
                }
                if (day == "Sunday")
                {
                    price = 16;
                }
            }
            if (people == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                if (day == "Saturday")
                {
                    price = 20;
                }
                if (day == "Sunday")
                {
                    price = 22.50;
                }
            }
            double total = count * price;
            if (people == "Students" && count >= 30)
            {
                total = total * 0.85;
            }
            if (people == "Business" && count >= 100)
            {
                total = (count - 10) * price;
            }
            if (people == "Regular" && count >= 10 && count <= 20)
            {
                total = total * 0.95;
            }

            Console.WriteLine($"Total price: {total:f2}");

        }
    }
}
