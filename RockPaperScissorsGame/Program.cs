using RockPaperScissorsGame.SRC;
using System;
using Microsoft.Extensions.DependencyInjection;
using RockPaperScissorsGame.SRC.Interface;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game started...........");
            var serviceProvider = new ServiceCollection()
            .AddScoped<IPlayer, Player>()
            .AddSingleton<IGame, Game>()
            .AddSingleton<IUtil, Util>()
            .BuildServiceProvider();

            var game= serviceProvider.GetService<IGame>();
            game.StartGame();
            Console.WriteLine("Game Exit...............");

            Console.ReadKey();



        }
    }
}
