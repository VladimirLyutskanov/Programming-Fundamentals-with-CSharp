using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int workers = 26;
            int dropdown = 10;
            int leaving = 0;
            int total = 0;
            int daycount = 0;


            while (start >= 100)
            {
                leaving = start - workers;
                total += leaving;
                daycount++;
                start -= dropdown;

            }
            if (leaving > 26)
            {
                total -= workers;
            }


            Console.WriteLine(daycount);
            Console.WriteLine(total);
        }
    }
}
