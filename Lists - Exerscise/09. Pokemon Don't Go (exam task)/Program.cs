using System;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToList();

            long sum = 0;
            while (elements.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                long element;
                if (index < 0)
                {
                    element = elements[0];
                    elements[0] = elements[elements.Count - 1];
                }
                else if (index >= elements.Count)
                {
                    element = elements[elements.Count - 1];
                    elements[elements.Count - 1] = elements[0];
                }
                else
                {
                    element = elements[index];
                    elements.RemoveAt(index);
                }

                sum += element;
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i] <= element)
                    {
                        elements[i] += element;
                    }
                    else
                    {
                        elements[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }

}
