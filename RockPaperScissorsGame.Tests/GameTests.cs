using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsGame.SRC;
using static RockPaperScissorsGame.SRC.PlayerHandSign;

namespace RockPaperScissorsGame.Tests
{
    [TestClass]
    public class GameTests
    {
        Player humanPlayer = new Player("Prem");
        Player computerPlayer = new Player("Computer");
           
        [TestMethod]
        public void StartGame_BothPlayerChoseRock_RoundIsDraw()
        {  
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("R");
            computerPlayer.HandSign = new PlayerHandSign(Move.Rock);

            Assert.AreEqual("Sorry, It's a tie!", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }
        [TestMethod]
        public void StartGame_BothPlayerChosePaper_RoundIsDraw()
        {         
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("P");
            computerPlayer.HandSign = new PlayerHandSign(Move.Paper);

            Assert.AreEqual("Sorry, It's a tie!", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }
        [TestMethod]
        public void StartGame_BothPlayerChoseScissor_RoundIsDraw()
        {          
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("S");
            computerPlayer.HandSign = new PlayerHandSign(Move.Scissors);

            Assert.AreEqual("Sorry, It's a tie!", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }
        [TestMethod]
        public void StartGame_HumanPlayerChoseRock_ComputerPlayerChoseScissor_HumanIsWinner()
        {
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("R");
            computerPlayer.HandSign = new PlayerHandSign(Move.Scissors);

            Assert.AreEqual("Congrats " + humanPlayer.Name + " is the winner", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }

        [TestMethod]
        public void StartGame_HumanPlayerChosePaper_ComputerPlayerChoseScissor_ComputerIsWinner()
        {
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("P");
            computerPlayer.HandSign = new PlayerHandSign(Move.Scissors);

            Assert.AreEqual("Congrats " + computerPlayer.Name + " is the winner", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }
        [TestMethod]
        public void StartGame_HumanPlayerChoseScissor_ComputerPlayerChoseRock_ComputerIsWinner()
        {
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("S");
            computerPlayer.HandSign = new PlayerHandSign(Move.Rock);

            Assert.AreEqual("Congrats " + computerPlayer.Name + " is the winner", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }
        [TestMethod]
        public void StartGame_HumanPlayerChosePaper_ComputerPlayerChoseRock_ComputerIsWinner()
        {
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("P");
            computerPlayer.HandSign = new PlayerHandSign(Move.Rock);

            Assert.AreEqual("Congrats " + humanPlayer.Name + " is the winner", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }

        [TestMethod]
        public void StartGame_HumanPlayerChoseScissors_ComputerPlayerChosePaper_ComputerIsWinner()
        {
            humanPlayer.HandSign = PlayerHandSign.MapStringToMove("S");
            computerPlayer.HandSign = new PlayerHandSign(Move.Paper);

            Assert.AreEqual("Congrats " + humanPlayer.Name + " is the winner", PlayerHandSign.GetWinner(humanPlayer, computerPlayer));
        }       
    }
}

