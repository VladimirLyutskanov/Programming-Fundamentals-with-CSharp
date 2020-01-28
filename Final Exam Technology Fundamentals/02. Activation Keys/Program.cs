using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            List<string> validKeys = new List<string>();

            string pattern = @"[\w]{16,25}";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);


            foreach (Match item in matches)
            {
                validKeys.Add(item.ToString());

            }

            for (int i = 0; i < validKeys.Count; i++)
            {
                if (validKeys[i].Length == 16)
                {
                    validKeys[i] = validKeys[i].Insert(4, "-");
                    validKeys[i] = validKeys[i].Insert(9, "-");
                    validKeys[i] = validKeys[i].Insert(14, "-");

                }
                else
                {
                    validKeys[i] = validKeys[i].Insert(5, "-");
                    validKeys[i] = validKeys[i].Insert(11, "-");
                    validKeys[i] = validKeys[i].Insert(17, "-");
                    validKeys[i] = validKeys[i].Insert(23, "-");
                }
            }

            for (int i = 0; i < validKeys.Count; i++)
            {

                for (int j = 0; j < validKeys[i].Length; j++)
                {

                    if (char.IsDigit(validKeys[i][j]))
                    {
                        int currentDigit = 9 - int.Parse(validKeys[i][j].ToString());
                        validKeys[i] = validKeys[i].Remove(j, 1);
                        validKeys[i] = validKeys[i].Insert(j, currentDigit.ToString());
                    }
                }
                validKeys[i] = validKeys[i].ToUpper();

            }
            Console.WriteLine(string.Join(", ", validKeys));


        }
    }
}
