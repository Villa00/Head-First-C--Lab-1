﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
                return Amount;
            else
                return -Amount;
        }
    }
}
