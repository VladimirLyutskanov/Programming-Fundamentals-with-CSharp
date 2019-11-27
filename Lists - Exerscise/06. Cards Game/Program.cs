using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < firstHand.Count; i++)
            {
                if (firstHand[i] == secondHand[i])
                {
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);

                }
                else if (firstHand[i] > secondHand[i])
                {
                    firstHand.Add(firstHand[i]);
                    firstHand.RemoveAt(i);

                    firstHand.Add(secondHand[i]);
                    secondHand.RemoveAt(i);
                }
                else if (secondHand[i] > firstHand[i])
                {
                    secondHand.Add(secondHand[i]);
                    secondHand.RemoveAt(i);
                    secondHand.Add(firstHand[i]);
                    firstHand.RemoveAt(i);

                }
                if (firstHand.Count < 1 || secondHand.Count < 1)
                {
                    if (firstHand.Count > secondHand.Count)
                    {
                        Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                    }
                    else
                    {
                        Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                    }
                    break;
                }
                i = -1;
            }


        }
    }
}
