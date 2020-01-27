using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

           


            string name = " ";
            double grade = 0;
            for (int i = 0; i < number; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                List<double> grades = new List<double>();

                if (!students.ContainsKey(name))
                {
                    grades.Add(grade);
                    students[name] = grades;
                }
                else
                {
                    students[name].Add(grade);    
                }

               
            }
            
            
            foreach (var kvp in students.OrderByDescending(x => x.Value.Average()))
            {
                if (kvp.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }
                
            }
        }
    }
}
