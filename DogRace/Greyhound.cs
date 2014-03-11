﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random Randomizer = new Random(); // Static?

        public bool Run()
        {
            Location += Randomizer.Next(5);
            MyPictureBox.Left = StartingPosition + Location;
            if (Location >= RacetrackLength)
            {
                // Finished the race
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
