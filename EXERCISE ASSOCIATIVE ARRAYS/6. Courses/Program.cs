using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" : ");

            SortedDictionary<string, List<string>> courses = new SortedDictionary<string, List<string>>();
            Dictionary<string, int> counter = new Dictionary<string, int>();


            while (true)
            {
                
                string course = input[0];
                string student = input[1];


                List<string> students = new List<string>();
                

                if (!courses.ContainsKey(course))
                {
                    students.Add(student);
                    courses[course]=students;
                  
                }
                else
                {
                    
                    courses[course].Add(student);

                }
               
                if (!counter.ContainsKey(course))
                {
                    counter[course] = 0;                  
                }
                counter[course]++;
                

                input = Console.ReadLine().Split(" : ");
                if (input[0]=="end")
                {
                    break;
                }
            }
            
            
            foreach (var item in counter.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

                
                foreach (var kvp in courses[item.Key].OrderBy(x => x))

                {
                 
                    Console.WriteLine($"-- {kvp}");
                    
                }             

            }

        }
    }
}
