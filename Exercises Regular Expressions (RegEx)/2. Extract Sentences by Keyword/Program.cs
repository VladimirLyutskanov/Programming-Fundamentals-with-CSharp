using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordToFind = Console.ReadLine();

            
            var pattern = $@"\b{wordToFind}\b";

            Regex regex = new Regex(pattern);

          
            var input = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            
            foreach (var item in input)
            {

                if (regex.IsMatch(item))
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
