using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> timeToPlay = new Dictionary<string, int>();
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();

            int totalTime = 0;
            while ((input = Console.ReadLine()) != "start of concert")
            {
                List<string> inputToSplit = input.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (inputToSplit[0] == "Add")
                {
                    string band = inputToSplit[1];
                    List<string> singers = inputToSplit[2].Split(", ").ToList();
                    if (!bands.ContainsKey(band))
                    {
                        bands[band] = new List<string>();
                        foreach (var item in singers)
                        {
                            bands[band].Add(item);
                        }
                    }
                    else
                    {
                        foreach (var item in singers)
                        {
                            if (!bands[band].Contains(item))
                            {
                                bands[band].Add(item);
                            }

                        }
                    }
                }
                if (inputToSplit[0] == "Play")
                {
                    string band = inputToSplit[1];
                    int time = int.Parse(inputToSplit[2]);

                    if (!timeToPlay.ContainsKey(band))
                    {
                        timeToPlay[band] = time;
                    }
                    else
                    {
                        timeToPlay[band] += time;
                    }



                    totalTime += time;
                }

            }

            string bantToDisplay = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var time in timeToPlay.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine($"{time.Key} -> {time.Value}");
            }

            Console.WriteLine(bantToDisplay);

            foreach (var band in bands)
            {
                if (band.Key == bantToDisplay)
                {
                    foreach (var member in band.Value)
                    {
                        Console.WriteLine($"=> {member}");
                    }
                }

            }

        }
    }
}
