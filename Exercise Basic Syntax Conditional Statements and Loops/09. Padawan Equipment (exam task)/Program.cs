using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltprice = double.Parse(Console.ReadLine());

            double countForLightsabers = Math.Ceiling(studentsCount * 1.1);
            double moneyForLight = countForLightsabers * lightSaberPrice;
            double moneyForRobes = studentsCount * robePrice;
            double moneyForBelts = studentsCount * beltprice;
            if (studentsCount >= 6)
            {
                double beltsToDeduct = Math.Floor(studentsCount / 6);
                moneyForBelts = (studentsCount - beltsToDeduct) * beltprice;
            }


            double total = moneyForBelts + moneyForLight + moneyForRobes;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            if (total > money)
            {

                Console.WriteLine($"Ivan Cho will need {(total - money):f2}lv more.");
            }





        }
    }
}
