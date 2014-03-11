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
        Random MyRandomizer = new Random();
        Greyhound[] Greyhounds = new Greyhound[4];
        Guy[] Guys = new Guy[3];
        Guy Bettor;

        public void InitTrack()
        {
            Greyhounds[0] = new Greyhound()
            {
                MyPictureBox = dog1PictureBox,
                StartingPosition = dog1PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog1PictureBox.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[1] = new Greyhound()
            {
                MyPictureBox = dog2PictureBox,
                StartingPosition = dog2PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog2PictureBox.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[2] = new Greyhound()
            {
                MyPictureBox = dog3PictureBox,
                StartingPosition = dog3PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog3PictureBox.Width,
                Randomizer = MyRandomizer
            };
            Greyhounds[3] = new Greyhound()
            {
                MyPictureBox = dog4PictureBox,
                StartingPosition = dog4PictureBox.Left,
                RacetrackLength = trackPictureBox.Width - dog4PictureBox.Width,
                Randomizer = MyRandomizer
            };

            Guys[0] = new Guy()
            {
                Cash = 50,
                Name = "Joe",
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };
            Guys[1] = new Guy()
            {
                Cash = 75,
                Name = "Bob",
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };
            Guys[2] = new Guy()
            {
                Cash = 45,
                Name = "Al",
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            Bettor = Guys[0];

            foreach (Guy guy in Guys)
            {
                guy.UpdateLabels();
            }

            bettorLabel.Text = Guys[0].Name;
            minimumBetLabel.Text = "Minimum bet: " + amountNumericUpDown.Value;
        }

        public Form1()
        {
            InitializeComponent();
            InitTrack();
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            foreach (Greyhound dog in Greyhounds)
            {
                dog.Location = 0;
            }
            timer1.Start();
            betButton.Enabled = false;
            raceButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Greyhound dog in Greyhounds)
            {
                if (dog.Run())
                {
                    NewRace(Array.IndexOf(Greyhounds, dog)+1);
                }
            }

        }

        private void NewRace(int Winner)
        {
            timer1.Stop();
            foreach (Guy guy in Guys)
            {
                guy.Collect(Winner);
                guy.UpdateLabels();
            }
            betButton.Enabled = true;
            raceButton.Enabled = true;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked)
            {
                Bettor = Guys[1];
                bettorLabel.Text = Bettor.Name;
            }
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked)
            {
                Bettor = Guys[2];
                bettorLabel.Text = Bettor.Name;
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                Bettor = Guys[0];
                bettorLabel.Text = Bettor.Name;
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            Bettor.PlaceBet((int)amountNumericUpDown.Value, (int)dogNumericUpDown.Value);
        }
    }
}
