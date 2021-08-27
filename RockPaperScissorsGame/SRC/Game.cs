using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class Game
    {
        private Player humanPlayer;
        private Player computerPlayer;
        private static Util util = new Util();

        public void StartGame()
        {
            String userInput = null;
            var name = util.GreetOpponent();
            
            //create players
            this.humanPlayer = new Player(name);
            this.computerPlayer = new Player("Computer");

            util.StartGameMessage(humanPlayer);            
            do
            {
                //Get player hand
                var humanHandSign = util.ChooseHandSign();
                this.humanPlayer.HandSign = humanHandSign;
                Console.WriteLine($"You chose : {PlayerHandSign.PlayerMove(humanPlayer)}");                

                //Generate a random hand for computer
                this.computerPlayer.HandSign = PlayerHandSign.MapRandomToMove();                
                Console.WriteLine($"Computer chose : {PlayerHandSign.PlayerMove(computerPlayer)}");
                
                // Compare choices and declare winner based on defined game rule
                Console.WriteLine(PlayerHandSign.GetWinner(this.humanPlayer, this.computerPlayer));
                
                Console.WriteLine();
                Console.WriteLine("Do you wish to play again, Please enter Y or N ?");
                userInput = Convert.ToString(Console.ReadLine());
            } while (userInput.ToUpper().Equals("Y", StringComparison.OrdinalIgnoreCase));
        }
    }
}
