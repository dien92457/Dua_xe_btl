using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LogicDive
{

    
    public partial class GameForm : Form
    {
        List<int> inputkey = new List<int>();
        int UP = 1;
        int LEFT = 2;
        int DOWN = 3;
        int RIGHT = 4;
        int movSpeed = 45;
        int itemSpeed = 25;
        int meteorSpeed = 45;
        Random rd = new Random();
        int[] CheckPrev = new int[12];
        List<PictureBox> SpawnPointMeteor = new List<PictureBox>();
        List<PictureBox> Meteor = new List<PictureBox>();
        int meteorLimit = 2;
        List<PictureBox> ItemList = new List<PictureBox>();
        int ItemType = 0;//1=live-5%//2=gold-50%//3=speed-15%/4=heal-10%//5=boom-20%
        int ItemLimit = 1;
        int playerHP = 100;
        int playerLive = 2;
        long playerScore = 0;
        int QuestionType = 0;//1=Restart-Quit(y-n)//2=R U sure(y-n)
        int speedCD = 0;
        string StartUp = Application.StartupPath;
        int dameLimit = 21;
        int percentLimit = 16;
        int music = 1;//1==on//0==off
        int gamepause = 0;//1=pause//0=play
        public GameForm()
        {
            InitializeComponent();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            AddSpawnPoint();
            this.ActiveControl = label1;
            prB_HP.Value = 100;
            LB_HienThi.Visible = true;
            BTN_Start.Visible = true;
            BTN_Start.BringToFront();
            PB_XeDua.Top = 100;
            PB_XeDua.Left = 100;

            MusicPlayer.URL = StartUp + "\\resources\\song3.mp3";
            MusicPlayer.settings.autoStart = true;
            MusicPlayer.settings.setMode("loop", true);
        }
        public void AddSpawnPoint()
        {
            SpawnPointMeteor.Add(pictureBox1);
            SpawnPointMeteor.Add(pictureBox2);
            SpawnPointMeteor.Add(pictureBox3);
            SpawnPointMeteor.Add(pictureBox4);
            SpawnPointMeteor.Add(pictureBox5);
            SpawnPointMeteor.Add(pictureBox6);
            SpawnPointMeteor.Add(pictureBox7);
            SpawnPointMeteor.Add(pictureBox8);
            SpawnPointMeteor.Add(pictureBox9);
            SpawnPointMeteor.Add(pictureBox10);
            SpawnPointMeteor.Add(pictureBox11);
            SpawnPointMeteor.Add(pictureBox12);
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                int keypress = 0;
                if (e.KeyCode == Keys.Up)
                {
                    keypress = UP;
                }
                if (e.KeyCode == Keys.Left)
                {
                    keypress = LEFT;
                }
                if (e.KeyCode == Keys.Down)
                {
                    keypress = DOWN;
                }
                if (e.KeyCode == Keys.Right)
                {
                    keypress = RIGHT;
                }
                int flag = 0;
                for (int i = 0; i < inputkey.Count; i++)
                {
                    if (inputkey[i] == keypress)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    inputkey.Add(keypress);
                }
            }    
        }
        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up|| e.KeyCode == Keys.Left || e.KeyCode == Keys.Down|| e.KeyCode == Keys.Right)
            {
                int keyremove = 0;
                if (e.KeyCode == Keys.Up)
                {
                    keyremove = UP;
                }
                if (e.KeyCode == Keys.Left)
                {
                    keyremove = LEFT;
                }
                if (e.KeyCode == Keys.Down)
                {
                    keyremove = DOWN;
                }
                if (e.KeyCode == Keys.Right)
                {
                    keyremove = RIGHT;
                }
                for (int i = 0; i < inputkey.Count; i++)
                {
                    if (inputkey[i] == keyremove)
                    {
                        inputkey.Remove(inputkey[i]);
                        break;
                    }
                }
            }
           
        }
        private void TimerMov_Tick(object sender, EventArgs e)
        {
            if(inputkey.Count==1)
            {
                if(inputkey[0]== UP)
                {
                    if(PB_XeDua.Top>60)
                    {
                        PB_XeDua.Top -= movSpeed;//tốc độ
                    }
                }
                if (inputkey[0] == LEFT)
                {
                    if(PB_XeDua.Left>10)
                    {
                        PB_XeDua.Left -= movSpeed;
                    }
                }
                if (inputkey[0] == DOWN)
                {
                    if (PB_XeDua.Top < 500)
                    {
                        PB_XeDua.Top += movSpeed;
                    }
                }
                if (inputkey[0] == RIGHT)
                {
                   
                    if (PB_XeDua.Left < 640)
                    {
                        PB_XeDua.Left += movSpeed;
                    }
                }
            }
            if(inputkey.Count == 2)
            {
                if (inputkey[0] == UP)
                {
                    if(inputkey[1]==RIGHT)
                    {
                        if(PB_XeDua.Top > 60&& PB_XeDua.Left < 640)
                        {
                            PB_XeDua.Top -= movSpeed / 2;
                            PB_XeDua.Left += movSpeed / 2;
                        }

                    }
                    if(inputkey[1]==LEFT)
                    {
                        if(PB_XeDua.Top > 60 && PB_XeDua.Left > 10)
                        {
                            PB_XeDua.Top -= movSpeed / 2;
                            PB_XeDua.Left -= movSpeed / 2;
                        }
                    }
                }
                if (inputkey[0] == LEFT)
                {
                    if (inputkey[1] == UP)
                    {
                        if (PB_XeDua.Top > 60 && PB_XeDua.Left > 10)
                        {
                            PB_XeDua.Top -= movSpeed / 2;
                            PB_XeDua.Left -= movSpeed / 2;
                        }
                    }
                    if (inputkey[1] == DOWN)
                    {
                        if (PB_XeDua.Top < 500 && PB_XeDua.Left > 10)
                        {
                            PB_XeDua.Top += movSpeed / 2;
                            PB_XeDua.Left -= movSpeed / 2;
                        }
                    }
                }
                if (inputkey[0] == DOWN)
                {
                    if (inputkey[1] == RIGHT)
                    {
                        if(PB_XeDua.Top < 500&& PB_XeDua.Left < 640)
                        {
                            PB_XeDua.Top += movSpeed / 2;
                            PB_XeDua.Left += movSpeed / 2;
                        }

                    }
                    if (inputkey[1] == LEFT)
                    {
                        if(PB_XeDua.Top < 500&& PB_XeDua.Left > 10)
                        {
                            PB_XeDua.Top += movSpeed / 2;
                            PB_XeDua.Left -= movSpeed / 2;
                        }

                    }
                }
                if (inputkey[0] == RIGHT)
                {
                    if (inputkey[1] == UP)
                    {
                        if (PB_XeDua.Top > 60 && PB_XeDua.Left < 640)
                        {
                            PB_XeDua.Top -= movSpeed / 2;
                            PB_XeDua.Left += movSpeed / 2;
                        }
                    }
                    if (inputkey[1] == DOWN)
                    {
                        if (PB_XeDua.Top < 500 && PB_XeDua.Left < 640)
                        {
                            PB_XeDua.Top += movSpeed / 2;
                            PB_XeDua.Left += movSpeed / 2;
                        }
                    }
                }
            }
        }

        private void TimerGameTick_Tick(object sender, EventArgs e)
        {
            UpdateInfo();
            CreatMeteor();
            CreatItem();
            MoveObject();
            CheckColision();
        }
        public void UpdateInfo()
        {
            if(playerLive==3)
            {
                PB_Tim3.Visible = true;
                PB_Tim2.Visible = true;
                PB_Tim1.Visible = true;
            }
            else if(playerLive==2)
            {
                PB_Tim3.Visible = false;
                PB_Tim2.Visible = true;
                PB_Tim1.Visible = true;
            }
            else if(playerLive==1)
            {
                PB_Tim3.Visible = false;
                PB_Tim2.Visible = false;
                PB_Tim1.Visible = true;
            }
            else if(playerLive==0)
            {
                PB_Tim3.Visible = false;
                PB_Tim2.Visible = false;
                PB_Tim1.Visible = false;
            }
            playerScore += 2;
            LB_Diem.Text = playerScore.ToString();
            if(speedCD!=0)
            {
                speedCD--;
                labelSpeedX2.Visible = true;
            }
            if(speedCD==0)
            {
                movSpeed = 30;
                labelSpeedX2.Visible = false;
            }
            
            if(playerScore==500|| playerScore == 1000|| playerScore == 1500|| playerScore == 2000|| playerScore == 2500)
            {
                dameLimit += 5;
                percentLimit += 5;
            }
            if(playerScore == 750|| playerScore == 1250|| playerScore == 1750)
            {
                meteorLimit++;
            }
            if(playerScore == 2000|| playerScore == 2500)
            {
                meteorSpeed += 5;
            }

        }
        public void resetMap()
        {
            for(int i=Meteor.Count-1;i>=0;i--)
            {
                this.Controls.Remove(Meteor[i]);
                Meteor.Remove(Meteor[i]);
            }
            for (int i =ItemList.Count - 1; i >= 0; i--)
            {
                this.Controls.Remove(ItemList[i]);
                ItemList.Remove(ItemList[i]);
            }
            timerGameTick.Enabled = false;
            timerMov.Enabled = false;
            PB_XeDua.Top = 100;
            PB_XeDua.Left = 100;
            UpdateInfo();
      
        }
        public void reStartGame()
        {
            resetMap();
            playerScore = 0;
            playerHP = 100;
            prB_HP.Value = 100;
            playerLive = 2;
            meteorLimit = 2;
            meteorSpeed=45;
            dameLimit = 21;
            percentLimit = 16;
        }
        public void CreatMeteor()
        {
            if(Meteor.Count<meteorLimit)
            {
                int point = rd.Next(0, 12);
                while(CheckPlace(point)==0)
                {
                    point = rd.Next(0, 12);
                }
                for(int i=11;i>0;i--)
                {
                    CheckPrev[i] = CheckPrev[i - 1];
                }
                CheckPrev[0] = point;
                PictureBox A = new PictureBox();
                A.Top = SpawnPointMeteor[point].Top;
                A.Left = SpawnPointMeteor[point].Left;
                A.SizeMode = SpawnPointMeteor[point].SizeMode;
                int roll = rd.Next(0, 101);
                if(roll>=0&&roll<=percentLimit)
                {
                    A.Width = 67*3;
                    A.Height = 37*3;
                }
                else
                {
                    A.Width = 67;
                    A.Height = 37;
                }

                A.Visible = true;
                A.BackColor = Color.Transparent;
                this.Controls.Add(A);
                A.BringToFront();
                int spite = rd.Next(1, 6);
                if(spite==1)
                {
                    A.Image = new Bitmap(Application.StartupPath + "\\Resources\\bomb1.png");
                }
                else if(spite==2)
                {
                    A.Image = new Bitmap(Application.StartupPath + "\\Resources\\bomb2.png");
                }
                else if (spite == 3)
                {
                    A.Image = new Bitmap(Application.StartupPath + "\\Resources\\fireball.png");
                }
                else
                {
                    A.Image = new Bitmap(Application.StartupPath + "\\Resources\\fireball+.png");
                }
                Meteor.Add(A);
            }
        }
        public void CreatItem()
        {
            if(ItemList.Count<ItemLimit)
            {
                int roll = rd.Next(1, 4);
                if (roll == 1)
                {
                    roll = rd.Next(1, 101);
                    if (roll >= 1 && roll <= 40)
                    {
                        ItemType = 2;//gold-40%
                    }
                    else if (roll >= 99 && roll <= 100&&playerLive<3)
                    {
                        ItemType = 1;//live-2%
                    }
                    else if (roll >= 41 && roll <= 60)
                    {
                        ItemType = 3;//speed-20%
                    }
                    else if (roll >= 61 && roll <= 85)
                    {
                        ItemType = 5;//boom-25%
                    }
                    else
                    {
                        ItemType = 4;//heal-18%
                    }
                    roll = rd.Next(0, 12);
                    while (CheckPlace(roll) == 0)
                    {
                        roll= rd.Next(0, 12);
                    }
                    for (int i = 11; i > 0; i--)
                    {
                        CheckPrev[i] = CheckPrev[i - 1];
                    }
                    CheckPrev[0] = roll;
                    PictureBox A = new PictureBox();
                    A.Top = SpawnPointMeteor[roll].Top;
                    A.Left = SpawnPointMeteor[roll].Left;
                    A.SizeMode = SpawnPointMeteor[roll].SizeMode;
                    A.Width = 36;
                    A.Height = 34;
                    A.Visible = true;
                    A.BackColor = Color.Transparent;
                    this.Controls.Add(A);
                    A.BringToFront();
                    if (ItemType == 1)
                    {
                        A.Image = new Bitmap(Application.StartupPath + "\\Resources\\heart.png");
                    }
                    else if(ItemType == 2)
                    {
                        A.Image = new Bitmap(Application.StartupPath + "\\Resources\\coin.png");
                    }
                    else if (ItemType == 3)
                    {
                        A.Image = new Bitmap(Application.StartupPath + "\\Resources\\pluscoin.png");
                    }
                    else if (ItemType == 4)
                    {
                        A.Image = new Bitmap(Application.StartupPath + "\\Resources\\plusheart.png");
                    }
                    else
                    {
                        roll = rd.Next(0, 2);
                        if(roll==0)
                        {
                            A.Image = new Bitmap(Application.StartupPath + "\\Resources\\bomb.png");
                        }
                        else
                        {
                            A.Image = new Bitmap(Application.StartupPath + "\\Resources\\bomb3.png");
                        }
                        
                    }
                    ItemList.Add(A);
                }
            }
           
        }
        public int CheckPlace(int x)
        {
            for(int i=0;i<meteorLimit;i++)
            {
                if(CheckPrev[i]==x)
                {
                    return 0;
                }
            }
            return 1;
        }
        public void MoveObject()
        {
            for(int i=0;i<Meteor.Count;i++)
            {
                if(Meteor[i].Left>30)
                {
                    Meteor[i].Left -= meteorSpeed;
                }
            }
            for(int i=0;i<ItemList.Count;i++)
            {
                if (ItemList[i].Left > 30)
                {
                    ItemList[i].Left -=itemSpeed;
                }
            }
        }
        public void CheckColision()
        {
            while(Meteor[0].Bounds.IntersectsWith(pictureBoxBorder.Bounds)==true)
            {
                this.Controls.Remove(Meteor[0]);
                Meteor.Remove(Meteor[0]);
            }
            if(ItemList.Count>0)
            {
                if (ItemList[0].Bounds.IntersectsWith(pictureBoxBorder.Bounds) == true)
                {
                    this.Controls.Remove(ItemList[0]);
                    ItemList.Remove(ItemList[0]);
                }
            }
            for(int i=0;i<Meteor.Count;i++)
            {
                if(Meteor[i].Bounds.IntersectsWith(PB_XeDua.Bounds)==true)
                {
                    int roll = rd.Next(10, dameLimit);
                    labelInfo.Text = "Gặp va chạm nhẹ - Mất " + roll.ToString() + " máu";
                    SoundPlayer simpleSound = new SoundPlayer(StartUp + "\\Resources\\explo.wav");
                    simpleSound.Play();
                    playerHP -= roll;
                    if(playerHP<=0)
                    {
                        playerLive--;
                        this.Controls.Remove(Meteor[i]);
                        Meteor.Remove(Meteor[i]);
                        inputkey.Clear();
                        if (playerLive==0)
                        {                          
                            resetMap();
                            playerHP = 100;
                            prB_HP.Value = 100;
                            LB_HienThi.Visible = true;
                            pictureBoxPause.Visible = false;
                            LB_HienThi.Text = "You Lose" + "\r\n" + "Score :" + playerScore.ToString();
                            labelInfo.Text = "GameOver";
                            BTN_NO.Visible = true;
                            BTN_Yes.Text = "Restart";
                            BTN_NO.Text = "Quit";
                            BTN_Yes.Visible = true;
                            QuestionType = 1;
                        }
                        else
                        {
                            resetMap();
                            playerHP = 100;
                            prB_HP.Value = 100;
                            LB_HienThi.Visible = true;
                            pictureBoxPause.Visible = false;
                            LB_HienThi.Text = "You Lost A Live ";
                            labelInfo.Text = "Mất một mạng rồi";
                            BTN_Start.Visible = true;
                            BTN_Start.Text = "Retry";
                        }

                    }
                    else
                    {
                        prB_HP.Value = playerHP;
                        this.Controls.Remove(Meteor[i]);
                        Meteor.Remove(Meteor[i]);
                        i--;
                    }

                }
            }
            for(int i=0;i<ItemList.Count;i++)
            {
                if (ItemList[0].Bounds.IntersectsWith(PB_XeDua.Bounds) == true)
                {
                    if(ItemType==1)//live
                    {
                        SoundPlayer simpleSound = new SoundPlayer(StartUp + "\\Resources\\heal.wav");
                        simpleSound.Play();
                        labelInfo.Text = "Bạn nhặt được một mạng ";
                        if (playerLive<3)
                        {
                            playerLive++;
                        }
                        this.Controls.Remove(ItemList[0]);
                        ItemList.Remove(ItemList[0]);
                    }
                    else if(ItemType==2)//coin
                    {

                        SoundPlayer simpleSound = new SoundPlayer(StartUp+"\\Resources\\coin.wav");
                        simpleSound.Play();
                        labelInfo.Text = "Bạn nhặt được một đồng xu +50 điểm ";
                        playerScore += 50;
                        this.Controls.Remove(ItemList[0]);
                        ItemList.Remove(ItemList[0]);
                    }
                    else if (ItemType == 3)//speed
                    {
                        SoundPlayer simpleSound = new SoundPlayer(StartUp + "\\Resources\\powerup.wav");
                        simpleSound.Play();
                        labelInfo.Text = "Bạn nhặt được một tăng tốc , tốc độ x2 trong 5s ";
                        movSpeed = 60;
                        speedCD = 50;
                        this.Controls.Remove(ItemList[0]);
                        ItemList.Remove(ItemList[0]);
                    }
                    else if (ItemType == 4)//hp
                    {
                        SoundPlayer simpleSound = new SoundPlayer(StartUp + "\\Resources\\heal.wav");
                        simpleSound.Play();
                        int roll = rd.Next(10, 21);
                        playerHP += roll;
                        labelInfo.Text = "Nhặt được một hộp máu , bạn được hồi " + roll.ToString() + " máu";
                        if (playerHP>100)
                        {
                            playerHP = 100;
                        }
                        prB_HP.Value = playerHP;
                        this.Controls.Remove(ItemList[0]);
                        ItemList.Remove(ItemList[0]);
                    }
                    else
                    {
                        int roll = rd.Next(10, dameLimit);
                        playerHP -= roll;
                        labelInfo.Text = "Gặp va chạm nhẹ - Mất " + roll.ToString() + " máu";
                        SoundPlayer simpleSound = new SoundPlayer(StartUp + "\\Resources\\explo.wav");
                        simpleSound.Play();
                        if (playerHP <= 0)
                        {
                            playerLive--;
                            this.Controls.Remove(ItemList[0]);
                            ItemList.Remove(ItemList[0]);
                            inputkey.Clear();
                            if (playerLive == 0)
                            {
                                resetMap();
                                playerHP = 100;
                                prB_HP.Value = 100;
                                LB_HienThi.Visible = true; pictureBoxPause.Visible = false;
                                LB_HienThi.Text = "You Lose" + "\r\n" + "Score :" + playerScore.ToString();
                                labelInfo.Text = "GameOver";
                                BTN_NO.Visible = true;
                                BTN_Yes.Text = "Restart";
                                BTN_NO.Text = "Quit";
                                BTN_Yes.Visible = true;
                                QuestionType = 1;
                            }
                            else
                            {
                                resetMap();
                                playerHP = 100;
                                prB_HP.Value = 100;
                                LB_HienThi.Visible = true; pictureBoxPause.Visible = false;
                                LB_HienThi.Text = "You Lost A Live";
                                labelInfo.Text = "Đã mất một mạng ";
                                BTN_Start.Visible = true;
                                BTN_Start.Text = "Retry";
                            }

                        }
                        else
                        {
                            prB_HP.Value = playerHP;
                            this.Controls.Remove(ItemList[0]);
                            ItemList.Remove(ItemList[0]);
                            i--;
                        }
                    }

                }
            }

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            timerGameTick.Enabled = true;
            timerMov.Enabled = true;
            LB_HienThi.Visible = false;
            BTN_Start.Visible = false;
            pictureBoxPause.Visible = true;
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            if(QuestionType==1)
            {
                reStartGame();
                QuestionType = 0;
                BTN_NO.Visible = false;
                BTN_Yes.Visible = false;
                LB_HienThi.Visible = false;
                timerGameTick.Enabled = true;
                timerMov.Enabled = true;
                this.ActiveControl = null;
                pictureBoxPause.Visible = true;
            }
            else if (QuestionType == 2)
            {
                Close();
            }
        }

        private void ButtonNO_Click(object sender, EventArgs e)
        {
            if (QuestionType == 1)
            {
                LB_HienThi.Text = "Are You Sure";
                BTN_Yes.Text = "Yes";
                BTN_NO.Text = "No";
                QuestionType = 2;
            }
            else if (QuestionType == 2)
            {
                LB_HienThi.Text = "You Lose !!!" + "\r\n" + "Score :" + playerScore.ToString();
                BTN_Yes.Text = "Restart";
                BTN_NO.Text = "Quit";
                QuestionType = 1;
            }

        }

        private void PictureBoxSound_Click(object sender, EventArgs e)
        {
            if(music==0)
            {
                music = 1;
                pictureBoxSound.Image = new Bitmap(StartUp+"\\Resources\\musicon.png");
                MusicPlayer.Ctlcontrols.play();
                MusicPlayer.settings.autoStart = true;
                MusicPlayer.settings.setMode("loop", true);
            }
            else
            {
                music = 0;
                pictureBoxSound.Image = new Bitmap(StartUp + "\\Resources\\musicoff.jpg");
                MusicPlayer.Ctlcontrols.pause();
                MusicPlayer.settings.autoStart = true;
                MusicPlayer.settings.setMode("loop", true);
            }
        }

        private void PictureBoxPause_Click(object sender, EventArgs e)
        {
            if(gamepause==0)
            {
                gamepause = 1;
                pictureBoxPause.Image = new Bitmap(StartUp + "\\Resources\\playbut.png");
                timerGameTick.Enabled = false;
                timerMov.Enabled = false;
            }
            else
            {
                gamepause = 0;
                pictureBoxPause.Image = new Bitmap(StartUp + "\\Resources\\pausebut.png");
                timerGameTick.Enabled = true;
                timerMov.Enabled = true;
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicPlayer.Ctlcontrols.pause();
            Setting.musicIntroForm = 1;
        }

        private void labelNotify_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLive1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PB_XeDua_Click(object sender, EventArgs e)
        {

        }
    }
}
