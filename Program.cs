using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace TheRightPriceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<GameGenerator, RightPriceGameGenerator>()
                .BuildServiceProvider();

            var MyGameList = serviceProvider.GetService<GameGenerator>();
            var games = MyGameList.GetGame(10);
            var count = 0;
            foreach (var game in games)
            {
                game.PlayTheGame();
                count++;
                Console.WriteLine("\nYOU GAME COUNT:"+count);
            }
        }
    }
}
