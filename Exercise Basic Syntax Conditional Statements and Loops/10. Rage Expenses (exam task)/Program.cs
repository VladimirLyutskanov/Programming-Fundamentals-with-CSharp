using System;

namespace rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGames = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetLost = Math.Floor(lostGames / 2);
            double mouseLost = Math.Floor(lostGames / 3);
            double keyboardLost = Math.Floor(lostGames / 6);
            double displylost = Math.Floor(lostGames / 12);

            double lost = (headsetPrice * headsetLost) + (mousePrice * mouseLost) + (keyboardPrice * keyboardLost) + (displayPrice * displylost);

            Console.WriteLine($"Rage expenses: {lost:f2} lv.");


        }
    }
}
