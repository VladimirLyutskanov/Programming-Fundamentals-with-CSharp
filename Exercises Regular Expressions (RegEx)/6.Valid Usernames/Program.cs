using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var newInput = string.Join(" ", input);
            var pattern = @"\b([A-Za-z]\w{2,24})\b";

            List<string> userNames = new List<string>();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(newInput);

            var maxElem = "";
            var maxElemSec = "";
            var sumLenght = 0;
            foreach (Match match in matches)
            {
                userNames.Add(match.Value);
            }
            for (int i = 0; i < userNames.Count - 1; i++)
            {
                var currentSum = userNames[i].Length + userNames[i + 1].Length;
                if (currentSum > sumLenght)
                {
                    maxElem = userNames[i];
                    maxElemSec = userNames[i + 1];
                    sumLenght = currentSum;
                }
            }
            Console.WriteLine(maxElem.Trim());
            Console.WriteLine(maxElemSec.Trim());
        }
    }
}
