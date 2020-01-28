using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gameAndPrice = new Dictionary<string, double>();
            Dictionary<string, string> gameAndDlc = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(", ").ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(":"))
                {
                    string[] games = input[i].Split(":");
                    string game = games[0];
                    string dlc = games[1];

                    if (gameAndPrice.ContainsKey(game))
                    {
                        gameAndDlc[game] = dlc;

                        double increasedPrice = gameAndPrice[game] + gameAndPrice[game] * 0.2;
                        gameAndPrice[game] = increasedPrice;
                    }
                }
                else
                {
                    string[] prices = input[i].Split("-");
                    string game = prices[0];
                    double price = double.Parse(prices[1]);

                    gameAndPrice[game] = price;
                }
            }

            var gamesNoDlc = new Dictionary<string, double>();
            var gamesWithDlc = new Dictionary<string, double>();

            foreach (var game in gameAndPrice)
            {
                string gameName = game.Key;
                double gamePrice = game.Value;

                if (!gameAndDlc.ContainsKey(gameName))
                {
                    double loweredNoDlc = gamePrice - (gamePrice * 0.2);
                    gamesNoDlc[gameName] = loweredNoDlc;
                }
                else
                {
                    double loweredDlc = gamePrice / 2;
                    gamesWithDlc[gameName] = loweredDlc;
                }
            }

            foreach (var game in gamesWithDlc.OrderBy(x => x.Value))
            {

                Console.WriteLine($"{game.Key} - {gameAndDlc[game.Key]} - {game.Value:f2}");
            }

            foreach (var game in gamesNoDlc.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{game.Key} - {game.Value:f2}");
            }

        }
    }
}
