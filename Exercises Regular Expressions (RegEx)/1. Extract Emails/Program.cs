using System;
using System.Text.RegularExpressions;

namespace _1._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string pattern = @"[A-Za-z0-9]+([.\-_][A-Za-z0-9]+)*@[A-Za-z]+([.\-][A-Za-z0-9]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
