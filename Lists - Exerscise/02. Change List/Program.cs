using System;
using System.Collections.Generic;
using System.Linq;

namespace just_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                int numberTo = 0;
                int index = 0;

                if (command[0] == "Delete")
                {
                    numberTo = int.Parse(command[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers.Contains(numberTo))
                        {
                            numbers.Remove(numberTo);
                        }
                    }


                }
                if (command[0] == "Insert")
                {
                    numberTo = int.Parse(command[1]);
                    index = int.Parse(command[2]);

                    numbers.Insert(index, numberTo);
                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
