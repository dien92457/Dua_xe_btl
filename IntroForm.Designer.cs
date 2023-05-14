namespace LogicDive
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.labelScore = new System.Windows.Forms.Label();
            this.BTN_BD1 = new System.Windows.Forms.Button();
            this.BTN_HD1 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.MusicPlayerIntro = new AxWMPLib.AxWindowsMediaPlayer();
            this.BTN_HD2 = new System.Windows.Forms.Button();
            this.BTN_BD2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayerIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Yellow;
            this.labelScore.Location = new System.Drawing.Point(47, 5);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(462, 239);
            this.labelScore.TabIndex = 25;
            this.labelScore.Text = "Đua xe tránh chướng ngại vật";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_BD1
            // 
            this.BTN_BD1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BTN_BD1.FlatAppearance.BorderSize = 4;
            this.BTN_BD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BD1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BD1.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_BD1.Location = new System.Drawing.Point(67, 192);
            this.BTN_BD1.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_BD1.Name = "BTN_BD1";
            this.BTN_BD1.Size = new System.Drawing.Size(126, 36);
            this.BTN_BD1.TabIndex = 33;
            this.BTN_BD1.Text = "Start 1";
            this.BTN_BD1.UseVisualStyleBackColor = true;
            this.BTN_BD1.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // BTN_HD1
            // 
            this.BTN_HD1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BTN_HD1.FlatAppearance.BorderSize = 4;
            this.BTN_HD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HD1.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HD1.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_HD1.Location = new System.Drawing.Point(67, 232);
            this.BTN_HD1.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_HD1.Name = "BTN_HD1";
            this.BTN_HD1.Size = new System.Drawing.Size(126, 36);
            this.BTN_HD1.TabIndex = 34;
            this.BTN_HD1.Text = "How to play";
            this.BTN_HD1.UseVisualStyleBackColor = true;
            this.BTN_HD1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // MusicPlayerIntro
            // 
            this.MusicPlayerIntro.Enabled = true;
            this.MusicPlayerIntro.Location = new System.Drawing.Point(713, 12);
            this.MusicPlayerIntro.Margin = new System.Windows.Forms.Padding(2);
            this.MusicPlayerIntro.Name = "MusicPlayerIntro";
            this.MusicPlayerIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MusicPlayerIntro.OcxState")));
            this.MusicPlayerIntro.Size = new System.Drawing.Size(75, 23);
            this.MusicPlayerIntro.TabIndex = 37;
            this.MusicPlayerIntro.Visible = false;
            // 
            // BTN_HD2
            // 
            this.BTN_HD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HD2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HD2.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_HD2.Location = new System.Drawing.Point(341, 230);
            this.BTN_HD2.Name = "BTN_HD2";
            this.BTN_HD2.Size = new System.Drawing.Size(147, 36);
            this.BTN_HD2.TabIndex = 38;
            this.BTN_HD2.Text = "How to play";
            this.BTN_HD2.UseVisualStyleBackColor = true;
            this.BTN_HD2.Click += new System.EventHandler(this.BTN_HD2_Click);
            // 
            // BTN_BD2
            // 
            this.BTN_BD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BD2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BD2.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_BD2.Location = new System.Drawing.Point(341, 188);
            this.BTN_BD2.Name = "BTN_BD2";
            this.BTN_BD2.Size = new System.Drawing.Size(147, 36);
            this.BTN_BD2.TabIndex = 38;
            this.BTN_BD2.Text = "Start 2";
            this.BTN_BD2.UseVisualStyleBackColor = true;
            this.BTN_BD2.Click += new System.EventHandler(this.BTN_BD2_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LogicDive.Properties.Resources.bk3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 326);
            this.Controls.Add(this.BTN_BD2);
            this.Controls.Add(this.BTN_HD2);
            this.Controls.Add(this.MusicPlayerIntro);
            this.Controls.Add(this.BTN_HD1);
            this.Controls.Add(this.BTN_BD1);
            this.Controls.Add(this.labelScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đua xe";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayerIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button BTN_BD1;
        private System.Windows.Forms.Button BTN_HD1;
        private System.Windows.Forms.Timer timerUpdate;
        private AxWMPLib.AxWindowsMediaPlayer MusicPlayerIntro;
        private System.Windows.Forms.Button BTN_HD2;
        private System.Windows.Forms.Button BTN_BD2;
    }
}