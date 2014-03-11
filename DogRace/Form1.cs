using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random MyRandomizer = new Random();
            Greyhound[] GreyhoundArray = new Greyhound[4];
            Guy[] GuyArray = new Guy[3];

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = dog1PictureBox,
                StartingPosition = dog1PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog1PictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = dog2PictureBox,
                StartingPosition = dog2PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog2PictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = dog3PictureBox,
                StartingPosition = dog3PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog3PictureBox.Width,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[4] = new Greyhound()
            {
                MyPictureBox = dog4PictureBox,
                StartingPosition = dog4PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog4PictureBox.Width,
                Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                MyBet = new Bet() {Amount = 0},
                Cash = 50,
                Name = "Joe",
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };
            GuyArray[1] = new Guy()
            {
                MyBet = new Bet() { Amount = 0 },
                Cash = 75,
                Name = "Bob",
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };
            GuyArray[2] = new Guy()
            {
                MyBet = new Bet() { Amount = 0 },
                Cash = 45,
                Name = "Al",
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

        }
    }
}
