using RockPaperScissorsGame.SRC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class Game :IGame
    {
        private IPlayer humanPlayer;
        private IPlayer computerPlayer;
        private readonly IUtil util;
        public Game(IUtil util)
        {
            this.util = util;           
        }
        public void StartGame()
        {
            String userCommand = null;
            var name = util.GreetOpponent();
            this.humanPlayer = new Player(name);
            this.computerPlayer = new Player("Computer");

            util.StartGameMessage(humanPlayer);            
            do
            {
                //Get player hand
                var humanHandSign = util.ChooseHandSign();
                this.humanPlayer.HandSign = humanHandSign;                           

                //Generate a random hand for computer
                this.computerPlayer.HandSign = PlayerHandSign.MapRandomToMove(); 
                
                // Compare choices and declare winner based on defined game rule
                Console.WriteLine(PlayerHandSign.GetWinner(this.humanPlayer, this.computerPlayer));
                
                Console.WriteLine();
                Console.WriteLine("Do you wish to play again, Please enter Y/N ?");
                userCommand = Convert.ToString(Console.ReadLine());
            } while (userCommand.ToUpper().Equals("Y", StringComparison.OrdinalIgnoreCase));
        }
    }
}
