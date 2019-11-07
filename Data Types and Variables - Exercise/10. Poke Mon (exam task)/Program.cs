using System;

namespace _10._pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int NPower = int.Parse(Console.ReadLine());
            int MDistance = int.Parse(Console.ReadLine());
            int YExhaust = int.Parse(Console.ReadLine());
            int pokeCount = 0;

            double newN = 0.5 * NPower;

            while (NPower >= MDistance)
            {

                if (newN == NPower)
                {
                    NPower /= YExhaust;
                    if (NPower < MDistance)
                    {
                        break;
                    }
                }
                NPower -= MDistance;
                pokeCount++;

            }
            Console.WriteLine(NPower);
            Console.WriteLine(pokeCount);
        }
    }
}
