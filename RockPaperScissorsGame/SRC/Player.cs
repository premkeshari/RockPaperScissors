using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class Player
    {
        private string name;
        private PlayerHandSign handSign;
        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public PlayerHandSign HandSign
        {
            get { return handSign; }
            set { handSign = value; }
        }
    }
}
