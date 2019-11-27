using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "End")
            {
                int numberTo = 0;
                int index = 0;
                int count = 0;
                int temp = 0;

                if (command[0] == "Add")
                {

                    numberTo = int.Parse(command[1]);

                    numbers.Add(numberTo);

                }
                if (command[0] == "Insert")
                {
                    numberTo = int.Parse(command[1]);
                    index = int.Parse(command[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, numberTo);
                    }


                }
                if (command[0] == "Remove")
                {
                    index = int.Parse(command[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }

                }
                if (command[0] == "Shift" && command[1] == "left")
                {
                    count = int.Parse(command[2]);

                    if (index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            temp = numbers[0];
                            numbers.Remove(temp);
                            numbers.Add(temp);
                        }
                    }


                }

                if (command[0] == "Shift" && command[1] == "right")
                {
                    count = int.Parse(command[2]);

                    if (index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNumber);
                            numbers.RemoveAt(numbers.Count - 1);

                        }
                    }


                }

                command = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
