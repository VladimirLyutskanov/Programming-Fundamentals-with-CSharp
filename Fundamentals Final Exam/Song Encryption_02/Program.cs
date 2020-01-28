using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        private static object Stringbuilder;

        static void Main(string[] args)
        {
            string artistPattern = @"^(?<artist>[A-Z][a-z ']*)$";
            string songPattern = @"^(?<song>[A-Z ]+)$";
            string keepPattern = @"[^' @]";

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> splitted = input.Split(":").ToList();

                string artist = splitted[0];
                string song = splitted[1];

                bool artistIsValid = Regex.IsMatch(artist, artistPattern);
                bool songIsValid = Regex.IsMatch(song, songPattern);

                if (!artistIsValid || !songIsValid)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Match artistMatch = Regex.Match(artist, artistPattern);
                    Match songMatch = Regex.Match(song, songPattern);

                    StringBuilder sb = new StringBuilder();

                    int lenght = artist.Length;
                    string text = $"{artistMatch}@{songMatch}";

                    foreach (char symbol in text)
                    {
                        char newSymbol = symbol;
                        bool isValidSymbol = Regex.IsMatch(newSymbol.ToString(), keepPattern);
                        if (isValidSymbol)
                        {
                            newSymbol = (char)(newSymbol + lenght);
                            if (symbol <= 90 && newSymbol > 90)
                            {
                                newSymbol -= (char)26;
                            }
                            else if (symbol <= 122 && newSymbol > 122)
                            {
                                newSymbol -= (char)26;
                            }
                        }
                        sb.Append(newSymbol);
                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                }
            }

        }
    }
}
