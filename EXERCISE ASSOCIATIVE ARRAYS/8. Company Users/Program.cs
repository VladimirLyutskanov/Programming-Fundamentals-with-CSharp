using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(" -> ").ToList(); ;

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            while (true)
            {


                string company = input[0];
                string id = input[1];

                if (!output.ContainsKey(company))
                {
                    output[company] = new List<string>();

                }
                if (!output[company].Contains(id))
                {
                    output[company].Add(id);
                }


                input = Console.ReadLine().Split(" -> ").ToList(); 
                if (input[0] == "End")
                {
                    break;
                }

            }

            foreach (var item in output.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }

        }   
    }
}
