using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> sideDict = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string[] data = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string side = data[0];
                    string user = data[1];
                    if (!sideDict.ContainsKey(side))
                    {
                        sideDict.Add(side, new List<string>());
                    }
                    if (!sideDict[side].Contains(user) &&
                        !sideDict.Values.Any(x => x.Contains(user)))
                    {
                        sideDict[side].Add(user);

                    }

                }
                else if (input.Contains("->"))
                {
                    string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string user = data[0];
                    string side = data[1];

                    if (!sideDict.Any(x => x.Value.Contains(user)))
                    {
                        if (!sideDict.ContainsKey(side))
                        {

                            sideDict.Add(side, new List<String>());
                        }

                        sideDict[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var s in sideDict)
                        {
                            if (s.Value.Contains(user))
                            {
                                s.Value.Remove(user);
                            }
                        }

                        if (!sideDict.ContainsKey(side))
                        {
                            sideDict.Add(side, new List<string>());
                        }
                        sideDict[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var side in sideDict.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
