using System;

namespace _01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int companions = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = days * 50;
            for (int day = 1; day <= days; day++)
            {

                if (day % 10 == 0)
                {
                    companions -= 2;
                }


                if (day % 15 == 0)
                {
                    companions += 5;
                }


                if (day % 3 == 0)
                {
                    coins -= companions * 3;
                }

                if (day % 5 == 0)
                {
                    int earnedCoins = 20;
                    coins += earnedCoins * companions;
                    if (day % 3 == 0)
                    {
                        coins -= companions * 2;
                    }
                }

                coins -= companions * 2;

            }


            int coinsPerPerson = coins / companions;
            Console.WriteLine($"{companions} companions received {coinsPerPerson} coins each.");
        }
    }
}
