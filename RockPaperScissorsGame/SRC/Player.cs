using RockPaperScissorsGame.SRC.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC
{
    public class Player :IPlayer
    {
        private string _name;
        private PlayerHandSign _handSign;
        public Player(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get =>_name;
            set =>_name = value;
        }

        public PlayerHandSign HandSign
        {
            get => _handSign;
            set => _handSign = value;
        }
    }
}
