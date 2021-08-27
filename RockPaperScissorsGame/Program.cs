using RockPaperScissorsGame.SRC;
using System;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game started...........");
            Game game = new Game();
            game.StartGame();
            Console.WriteLine("Game Exit...............");
        }
    }
}
