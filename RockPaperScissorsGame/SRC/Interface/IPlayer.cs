﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame.SRC.Interface
{
   public interface IPlayer
    {
        string Name{get; set;}
        PlayerHandSign HandSign { get; set; }

    }
}
