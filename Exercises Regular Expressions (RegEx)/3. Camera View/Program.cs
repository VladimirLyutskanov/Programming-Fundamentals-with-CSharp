using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startIndex = lenght[0];
            int endIndex = lenght[1];


            var pattern = @"\|<(\w+)";

            var input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            var resultWords = new List<string>();
            foreach (Match match in matches)
            {
                var selectedMatch = match.Value;
                var result = selectedMatch.Skip(startIndex + 2).Take(endIndex).ToArray();
                var currentResult = string.Join("", result);
                resultWords.Add(currentResult);

            }

            Console.Write(string.Join(", ", resultWords));
            Console.WriteLine();
        }
    }
}
