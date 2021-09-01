using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC.Interface
{
   public interface IUtil
    {
        string GreetOpponent();
        void StartGameMessage(IPlayer player);
        PlayerHandSign ChooseHandSign();
    }
}
