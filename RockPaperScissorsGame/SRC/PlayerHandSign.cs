﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class PlayerHandSign
    {
        private Move move;

        public enum Move
        {
            Rock,
            Paper,
            Scissors
        }

        public PlayerHandSign(Move move)
        {
            this.move = move;
        }

        public static PlayerHandSign MapStringToMove(string userChoice)
        {
            switch (userChoice.ToUpper())
            {
                case "P":
                    return new PlayerHandSign(Move.Paper);
                case "S":
                    return new PlayerHandSign(Move.Scissors);
                case "R":
                    return new PlayerHandSign(Move.Rock);
            }
            return null;
        }
        /// <summary>
        /// Random Move by the Computer
        /// </summary>
        /// <returns></returns>
        public static PlayerHandSign MapRandomToMove()
        {
            Random random = new Random();
            int cpuChoice = random.Next(0, 2);

            switch (cpuChoice)
            {
                case 0:
                    return new PlayerHandSign(Move.Rock);
                case 1:
                    return new PlayerHandSign(Move.Paper);
                case 2:
                    return new PlayerHandSign(Move.Scissors);
            }
            return null;
        }

        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <returns>The winning move.</returns>
        /// <param name="move">Handsign.</param>
        public static Move GetWinningMove(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    return Move.Paper;
                case Move.Paper:
                    return Move.Scissors;
                default:
                    return Move.Rock;
            }
        }

        public static string PlayerMove(Player player)
        {
           return Convert.ToString(player.HandSign.move);            
        }
        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns>The winner.</returns>
        /// <param name="player1">Handsign player1.</param>
        /// <param name="player2">Handsign player2.</param>
        public static string GetWinner(Player player1, Player player2)
        {
            if (GetWinningMove(player1.HandSign.move).Equals(player2.HandSign.move))
            {
                //return player2.HandSign.move; //player 1 loses to player 2
                return "Congrats " + player2.Name + " is the winner";
            }
            else if (GetWinningMove(player2.HandSign.move).Equals(player1.HandSign.move))
            {
                //return player1.HandSign.move; //player 2 loses to player 1
                return "Congrats " + player1.Name + " is the winner";
            }
            else
            {
                return "Sorry, It's a tie!";
            }
        }
    }
}
