namespace LogicDive
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timerMov = new System.Windows.Forms.Timer(this.components);
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Diem = new System.Windows.Forms.Label();
            this.prB_HP = new System.Windows.Forms.ProgressBar();
            this.BTN_Yes = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BTN_NO = new System.Windows.Forms.Button();
            this.LB_HienThi = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelSpeedX2 = new System.Windows.Forms.Label();
            this.MusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.PB_Tim3 = new System.Windows.Forms.PictureBox();
            this.PB_Tim2 = new System.Windows.Forms.PictureBox();
            this.PB_Tim1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSound = new System.Windows.Forms.PictureBox();
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PB_XeDua = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XeDua)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMov
            // 
            this.timerMov.Tick += new System.EventHandler(this.TimerMov_Tick);
            // 
            // timerGameTick
            // 
            this.timerGameTick.Tick += new System.EventHandler(this.TimerGameTick_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(297, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "HP :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(639, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "LIVE :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(121, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Score :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Diem
            // 
            this.LB_Diem.BackColor = System.Drawing.Color.Transparent;
            this.LB_Diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Diem.ForeColor = System.Drawing.Color.Yellow;
            this.LB_Diem.Location = new System.Drawing.Point(191, 5);
            this.LB_Diem.Name = "LB_Diem";
            this.LB_Diem.Size = new System.Drawing.Size(123, 19);
            this.LB_Diem.TabIndex = 24;
            this.LB_Diem.Text = "9999999";
            this.LB_Diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prB_HP
            // 
            this.prB_HP.Location = new System.Drawing.Point(352, 5);
            this.prB_HP.Margin = new System.Windows.Forms.Padding(2);
            this.prB_HP.Name = "prB_HP";
            this.prB_HP.Size = new System.Drawing.Size(282, 19);
            this.prB_HP.TabIndex = 29;
            // 
            // BTN_Yes
            // 
            this.BTN_Yes.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BTN_Yes.FlatAppearance.BorderSize = 4;
            this.BTN_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Yes.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Yes.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_Yes.Location = new System.Drawing.Point(326, 289);
            this.BTN_Yes.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Yes.Name = "BTN_Yes";
            this.BTN_Yes.Size = new System.Drawing.Size(112, 36);
            this.BTN_Yes.TabIndex = 31;
            this.BTN_Yes.Text = "Yes";
            this.BTN_Yes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Yes.UseVisualStyleBackColor = true;
            this.BTN_Yes.Visible = false;
            this.BTN_Yes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BTN_Start.FlatAppearance.BorderSize = 4;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Start.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_Start.Location = new System.Drawing.Point(413, 289);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(99, 36);
            this.BTN_Start.TabIndex = 32;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Visible = false;
            this.BTN_Start.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // BTN_NO
            // 
            this.BTN_NO.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BTN_NO.FlatAppearance.BorderSize = 4;
            this.BTN_NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NO.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NO.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_NO.Location = new System.Drawing.Point(491, 289);
            this.BTN_NO.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_NO.Name = "BTN_NO";
            this.BTN_NO.Size = new System.Drawing.Size(103, 36);
            this.BTN_NO.TabIndex = 33;
            this.BTN_NO.Text = "No";
            this.BTN_NO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_NO.UseVisualStyleBackColor = true;
            this.BTN_NO.Visible = false;
            this.BTN_NO.Click += new System.EventHandler(this.ButtonNO_Click);
            // 
            // LB_HienThi
            // 
            this.LB_HienThi.BackColor = System.Drawing.Color.DarkGray;
            this.LB_HienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_HienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_HienThi.Font = new System.Drawing.Font("Ravie", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_HienThi.ForeColor = System.Drawing.Color.Yellow;
            this.LB_HienThi.Location = new System.Drawing.Point(321, 208);
            this.LB_HienThi.Name = "LB_HienThi";
            this.LB_HienThi.Size = new System.Drawing.Size(273, 118);
            this.LB_HienThi.TabIndex = 34;
            this.LB_HienThi.Text = "Press The Start Button";
            this.LB_HienThi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_HienThi.Click += new System.EventHandler(this.labelNotify_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.Yellow;
            this.labelInfo.Location = new System.Drawing.Point(-5, 29);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(639, 21);
            this.labelInfo.TabIndex = 35;
            this.labelInfo.Text = "Hello :3\r\n\r\n\r\n";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpeedX2
            // 
            this.labelSpeedX2.BackColor = System.Drawing.Color.Yellow;
            this.labelSpeedX2.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedX2.Location = new System.Drawing.Point(-3, 3);
            this.labelSpeedX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeedX2.Name = "labelSpeedX2";
            this.labelSpeedX2.Size = new System.Drawing.Size(128, 32);
            this.labelSpeedX2.TabIndex = 37;
            this.labelSpeedX2.Text = "Speed X 2";
            this.labelSpeedX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSpeedX2.Visible = false;
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.Enabled = true;
            this.MusicPlayer.Location = new System.Drawing.Point(1395, 85);
            this.MusicPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayer.OcxState")));
            this.MusicPlayer.Size = new System.Drawing.Size(75, 23);
            this.MusicPlayer.TabIndex = 36;
            this.MusicPlayer.Visible = false;
            // 
            // PB_Tim3
            // 
            this.PB_Tim3.BackColor = System.Drawing.Color.Transparent;
            this.PB_Tim3.Image = ((System.Drawing.Image)(resources.GetObject("PB_Tim3.Image")));
            this.PB_Tim3.Location = new System.Drawing.Point(785, 4);
            this.PB_Tim3.Name = "PB_Tim3";
            this.PB_Tim3.Size = new System.Drawing.Size(41, 25);
            this.PB_Tim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Tim3.TabIndex = 19;
            this.PB_Tim3.TabStop = false;
            this.PB_Tim3.Click += new System.EventHandler(this.pictureBoxLive1_Click);
            // 
            // PB_Tim2
            // 
            this.PB_Tim2.BackColor = System.Drawing.Color.Transparent;
            this.PB_Tim2.Image = ((System.Drawing.Image)(resources.GetObject("PB_Tim2.Image")));
            this.PB_Tim2.Location = new System.Drawing.Point(738, 3);
            this.PB_Tim2.Name = "PB_Tim2";
            this.PB_Tim2.Size = new System.Drawing.Size(41, 24);
            this.PB_Tim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Tim2.TabIndex = 18;
            this.PB_Tim2.TabStop = false;
            // 
            // PB_Tim1
            // 
            this.PB_Tim1.BackColor = System.Drawing.Color.Transparent;
            this.PB_Tim1.Image = global::LogicDive.Properties.Resources.heart;
            this.PB_Tim1.Location = new System.Drawing.Point(697, 2);
            this.PB_Tim1.Name = "PB_Tim1";
            this.PB_Tim1.Size = new System.Drawing.Size(41, 25);
            this.PB_Tim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Tim1.TabIndex = 17;
            this.PB_Tim1.TabStop = false;
            // 
            // pictureBoxSound
            // 
            this.pictureBoxSound.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSound.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSound.Image")));
            this.pictureBoxSound.Location = new System.Drawing.Point(944, 2);
            this.pictureBoxSound.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSound.Name = "pictureBoxSound";
            this.pictureBoxSound.Size = new System.Drawing.Size(33, 25);
            this.pictureBoxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSound.TabIndex = 26;
            this.pictureBoxSound.TabStop = false;
            this.pictureBoxSound.Click += new System.EventHandler(this.PictureBoxSound_Click);
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPause.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPause.Image")));
            this.pictureBoxPause.Location = new System.Drawing.Point(916, 2);
            this.pictureBoxPause.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(33, 25);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPause.TabIndex = 25;
            this.pictureBoxPause.TabStop = false;
            this.pictureBoxPause.Visible = false;
            this.pictureBoxPause.Click += new System.EventHandler(this.PictureBoxPause_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox16.Location = new System.Drawing.Point(1, 29);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(979, 21);
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBoxBorder
            // 
            this.pictureBoxBorder.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBorder.Location = new System.Drawing.Point(1, 44);
            this.pictureBoxBorder.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBorder.Name = "pictureBoxBorder";
            this.pictureBoxBorder.Size = new System.Drawing.Size(45, 532);
            this.pictureBoxBorder.TabIndex = 13;
            this.pictureBoxBorder.TabStop = false;
            this.pictureBoxBorder.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(770, 467);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(67, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(770, 431);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(67, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(770, 395);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(67, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Location = new System.Drawing.Point(770, 359);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(67, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(770, 323);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(770, 287);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(67, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(770, 244);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(770, 208);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(67, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(770, 170);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(770, 133);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(770, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(770, 91);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // PB_XeDua
            // 
            this.PB_XeDua.BackColor = System.Drawing.Color.Transparent;
            this.PB_XeDua.Image = global::LogicDive.Properties.Resources.xanh_ngang;
            this.PB_XeDua.Location = new System.Drawing.Point(67, 140);
            this.PB_XeDua.Margin = new System.Windows.Forms.Padding(2);
            this.PB_XeDua.Name = "PB_XeDua";
            this.PB_XeDua.Size = new System.Drawing.Size(80, 47);
            this.PB_XeDua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_XeDua.TabIndex = 0;
            this.PB_XeDua.TabStop = false;
            this.PB_XeDua.Click += new System.EventHandler(this.PB_XeDua_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::LogicDive.Properties.Resources.rd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.labelSpeedX2);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.PB_Tim3);
            this.Controls.Add(this.PB_Tim2);
            this.Controls.Add(this.PB_Tim1);
            this.Controls.Add(this.BTN_NO);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Yes);
            this.Controls.Add(this.LB_HienThi);
            this.Controls.Add(this.prB_HP);
            this.Controls.Add(this.pictureBoxSound);
            this.Controls.Add(this.pictureBoxPause);
            this.Controls.Add(this.LB_Diem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBorder);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PB_XeDua);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đua xe tránh bom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Tim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XeDua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_XeDua;
        private System.Windows.Forms.Timer timerMov;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Timer timerGameTick;
        private System.Windows.Forms.PictureBox pictureBoxBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB_Tim1;
        private System.Windows.Forms.PictureBox PB_Tim2;
        private System.Windows.Forms.PictureBox PB_Tim3;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Diem;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.PictureBox pictureBoxSound;
        private System.Windows.Forms.ProgressBar prB_HP;
        private System.Windows.Forms.Button BTN_Yes;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Button BTN_NO;
        private System.Windows.Forms.Label LB_HienThi;
        private System.Windows.Forms.Label labelInfo;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayer;
        private System.Windows.Forms.Label labelSpeedX2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

