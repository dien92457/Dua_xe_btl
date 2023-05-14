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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }
        private void IntroForm_Load(object sender, EventArgs e)
        {
            MusicPlayerIntro.URL = Application.StartupPath + "\\resources\\song1.mp3";
            MusicPlayerIntro.settings.autoStart = true;
            MusicPlayerIntro.settings.setMode("loop", true);
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Setting.musicIntroForm = 0;
            GameForm gf = new GameForm();
            gf.ShowDialog();
            
           // Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IntructForm iff = new IntructForm();
            iff.ShowDialog();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            if(Setting.musicIntroForm==1)
            {
                MusicPlayerIntro.Ctlcontrols.play();
            }
            else
            {
                MusicPlayerIntro.Ctlcontrols.pause();
            }
        }

        private void BTN_BD2_Click(object sender, EventArgs e)
        {
            Setting.musicIntroForm = 0;
            GameForm2 gf = new GameForm2();
            gf.ShowDialog();
        }

        private void BTN_HD2_Click(object sender, EventArgs e)
        {
            IntrucForm2 iff = new IntrucForm2();
            iff.ShowDialog();
        }
    }
}
