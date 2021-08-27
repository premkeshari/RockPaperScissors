using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class Util
    {
        public string GreetOpponent()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors Game! It's you against the Computer.");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} indicate that you are ready by hitting the enter key");
            return name;
        }

        public void StartGameMessage(Player player)
        {
            Console.WriteLine($"{player.Name} ,let's Play!\n");
        }

        public PlayerHandSign ChooseHandSign()
        {
            //Accept user input in various ways
            Console.WriteLine("R-Rock\n" +
                              "P-Paper\n" +
                              "S-Scissors\n" +
                              "Make your selection:");
            string input = Console.ReadLine();
            var handSign = PlayerHandSign.MapStringToMove(input);
            if (handSign == null)
            {
                Console.WriteLine("Sorry Invalid Input. Please choose again");
                return ChooseHandSign();
            }
            return handSign;
        }
    }
}
