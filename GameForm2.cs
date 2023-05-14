using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicDive
{
    public partial class GameForm2 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public GameForm2()
        {
            InitializeComponent();
            ResetGame();
        }

        private void GameForm2_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void GameForm2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void GameForm2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            LB_D.Text = "Score: " + score;
            score++;


            if (goleft == true && PB_NC.Left > 10)
            {
                PB_NC.Left -= playerSpeed;
            }
            if (goright == true && PB_NC.Left < 415)
            {
                PB_NC.Left += playerSpeed;
            }

            PB_DD1.Top += roadSpeed;
            PB_DD2.Top += roadSpeed;

            if (PB_DD2.Top > 519)
            {
                PB_DD2.Top = -519;
            }
            if (PB_DD1.Top > 519)
            {
                PB_DD1.Top = -519;
            }

            PB_XD1.Top += trafficSpeed;
            PB_XD2.Top += trafficSpeed;


            if (PB_XD2.Top > 530)
            {
                changeAIcars(PB_XD2);
            }

            if (PB_XD1.Top > 530)
            {
                changeAIcars(PB_XD1);
            }

            if (PB_NC.Bounds.IntersectsWith(PB_XD1.Bounds) || PB_NC.Bounds.IntersectsWith(PB_XD2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 500)
            {
                PB_V.Image = Properties.Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                PB_V.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 2000)
            {
                PB_V.Image = Properties.Resources.gold;
                trafficSpeed = 27;
                roadSpeed = 25;
            }


        }
        private void changeAIcars(PictureBox tempCar)
        {

            carImage = rand.Next(1, 9);

            switch (carImage)
            {

                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.carGreen1;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGrey1;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carOrange1;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed1;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow1;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }


            tempCar.Top = carPosition.Next(100, 400) * -1;


            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }
        }

        private void gameOver()
        {
            playSound();
            GameTime.Stop();
            PB_BUM.Visible = true;
            PB_NC.Controls.Add(PB_BUM);
            PB_BUM.Location = new Point(-8, 5);
            PB_BUM.BackColor = Color.Transparent;

            PB_V.Visible = true;
            PB_V.BringToFront();

            BTN_BD.Enabled = true;




        }

        private void ResetGame()
        {

            BTN_BD.Enabled = false;
            PB_BUM.Visible = false;
            PB_V.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            PB_V.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            PB_XD1.Top = carPosition.Next(200, 500) * -1;
            PB_XD1.Left = carPosition.Next(5, 200);

            PB_XD2.Top = carPosition.Next(200, 500) * -1;
            PB_XD2.Left = carPosition.Next(245, 422);

            GameTime.Start();



        }

        private void BTN_BD_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();

        }

    }
}
