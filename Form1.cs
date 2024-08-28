using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Random RandomPicture = new Random();
        Random CarPosition = new Random();
        int PlayerScore = 0;
        void ResetGame()
        {
            PlayerScore = 0;
            btnStart.Enabled = false;
            LevelPlayer.Visible = false;

            Car1.Left = CarPosition.Next(100, 200);
            Car1.Top = CarPosition.Next(200, 500)*-1;

            car2.Left = CarPosition.Next(220, 270);
            car2.Top = CarPosition.Next(200, 500) * -1;

            GameSpeed.Start();



        }
        void GameOver()
        {
            btnStart.Enabled = true;
            btnStart.TabStop = false;
                GameSpeed.Stop();

                if (PlayerScore > 1000)
                {
                    LevelPlayer.Image = Properties.Resources.gold;
                    LevelPlayer.Visible = true;
                    PlayerScore = 0;
                }
                if (PlayerScore > 500)
                {
                    LevelPlayer.Image = Properties.Resources.silver;
                    LevelPlayer.Visible = true;
                    PlayerScore = 0;

                }
                else
                {
                    LevelPlayer.Visible = true;
                    PlayerScore = 0;

                }




        }
        void MoveRoadFromTopToDown(PictureBox PBX)
        {
            PBX.Top += 10;

            if (PBX.Top > 535)
            {
                PBX.Top = -535;

            }

        }

        void MoveCarsFromTopToDown(PictureBox PBX)
        {
            PBX.Top += 10;

            if (PBX.Top > 535)
            {
                PBX.Top = -535;

                ChangCarsPicture(PBX);

            }

        }

        void ChangCarsPicture(PictureBox PBXCars)
        {
                    int NumberOfPicture = RandomPicture.Next(1, 8);
                switch (NumberOfPicture)
                {
                    case 1:
                        PBXCars.Image = Properties.Resources.carPink;
                        break;

                    case 2:
                        PBXCars.Image = Properties.Resources.carYellow;
                        break;
                    case 3:
                        PBXCars.Image = Properties.Resources.carOrange;
                        break;
                    case 4:
                        PBXCars.Image = Properties.Resources.carGreen;
                        break;
                    case 5:
                        PBXCars.Image = Properties.Resources.carGrey;
                        break;
                    case 6:
                        PBXCars.Image = Properties.Resources.ambulance;
                        break;
                    case 7:
                        PBXCars.Image = Properties.Resources.TruckBlue;
                        break;
                    case 8:
                        PBXCars.Image = Properties.Resources.TruckWhite;
                        break;
                }

            if ((string)PBXCars.Tag == "CarLeft")
            {
                PBXCars.Left = CarPosition.Next(10, 150);
            }
            if ((string)PBXCars.Tag == "CarRight")
            {
                PBXCars.Left = CarPosition.Next(190, 260);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }


        


        private void GameSpeed_tick(object sender, EventArgs e)
        {
            lblScorePlayer.Text = "Score ";

            MoveRoadFromTopToDown(road1);
            MoveRoadFromTopToDown(road2);

            MoveCarsFromTopToDown(Car1);
            MoveCarsFromTopToDown(car2);



            PlayerScore++;

            lblScorePlayer.Text = lblScorePlayer.Text + PlayerScore;



            if (player.Bounds.IntersectsWith(car2.Bounds) || player.Bounds.IntersectsWith(Car1.Bounds))
            {
                GameOver();
            }
            }

            private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up) {

                GameSpeed.Interval = 10;
            }
            if (e.KeyCode == Keys.Down)
            {

                GameSpeed.Interval = 20;
            }

            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 10)
                    player.Left -= 15;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Right < 325)
                    player.Left += 15;

            }



        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {

            ResetGame();
        }
    }
    }

