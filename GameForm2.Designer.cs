namespace LogicDive
{
    partial class GameForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PB_NC = new System.Windows.Forms.PictureBox();
            this.PB_XD2 = new System.Windows.Forms.PictureBox();
            this.PB_BUM = new System.Windows.Forms.PictureBox();
            this.PB_V = new System.Windows.Forms.PictureBox();
            this.PB_XD1 = new System.Windows.Forms.PictureBox();
            this.PB_DD2 = new System.Windows.Forms.PictureBox();
            this.PB_DD1 = new System.Windows.Forms.PictureBox();
            this.LB_D = new System.Windows.Forms.Label();
            this.BTN_BD = new System.Windows.Forms.Button();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_NC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DD1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PB_NC);
            this.panel1.Controls.Add(this.PB_XD2);
            this.panel1.Controls.Add(this.PB_BUM);
            this.panel1.Controls.Add(this.PB_V);
            this.panel1.Controls.Add(this.PB_XD1);
            this.panel1.Controls.Add(this.PB_DD2);
            this.panel1.Controls.Add(this.PB_DD1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 519);
            this.panel1.TabIndex = 2;
            // 
            // PB_NC
            // 
            this.PB_NC.Image = global::LogicDive.Properties.Resources.xanh_doc;
            this.PB_NC.Location = new System.Drawing.Point(292, 354);
            this.PB_NC.Name = "PB_NC";
            this.PB_NC.Size = new System.Drawing.Size(50, 100);
            this.PB_NC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_NC.TabIndex = 2;
            this.PB_NC.TabStop = false;
            // 
            // PB_XD2
            // 
            this.PB_XD2.BackColor = System.Drawing.Color.Black;
            this.PB_XD2.Image = ((System.Drawing.Image)(resources.GetObject("PB_XD2.Image")));
            this.PB_XD2.Location = new System.Drawing.Point(327, 63);
            this.PB_XD2.Name = "PB_XD2";
            this.PB_XD2.Size = new System.Drawing.Size(50, 100);
            this.PB_XD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_XD2.TabIndex = 1;
            this.PB_XD2.TabStop = false;
            this.PB_XD2.Tag = "carRight";
            // 
            // PB_BUM
            // 
            this.PB_BUM.Image = global::LogicDive.Properties.Resources.explosion;
            this.PB_BUM.Location = new System.Drawing.Point(121, 371);
            this.PB_BUM.Name = "PB_BUM";
            this.PB_BUM.Size = new System.Drawing.Size(64, 64);
            this.PB_BUM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BUM.TabIndex = 1;
            this.PB_BUM.TabStop = false;
            // 
            // PB_V
            // 
            this.PB_V.Image = ((System.Drawing.Image)(resources.GetObject("PB_V.Image")));
            this.PB_V.Location = new System.Drawing.Point(173, 169);
            this.PB_V.Name = "PB_V";
            this.PB_V.Size = new System.Drawing.Size(216, 99);
            this.PB_V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_V.TabIndex = 1;
            this.PB_V.TabStop = false;
            // 
            // PB_XD1
            // 
            this.PB_XD1.BackColor = System.Drawing.Color.Black;
            this.PB_XD1.Image = global::LogicDive.Properties.Resources.carOrange1;
            this.PB_XD1.Location = new System.Drawing.Point(139, 41);
            this.PB_XD1.Name = "PB_XD1";
            this.PB_XD1.Size = new System.Drawing.Size(50, 100);
            this.PB_XD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_XD1.TabIndex = 1;
            this.PB_XD1.TabStop = false;
            this.PB_XD1.Tag = "carLeft";
            // 
            // PB_DD2
            // 
            this.PB_DD2.Image = global::LogicDive.Properties.Resources.roadTrack;
            this.PB_DD2.Location = new System.Drawing.Point(-3, -3);
            this.PB_DD2.Name = "PB_DD2";
            this.PB_DD2.Size = new System.Drawing.Size(475, 519);
            this.PB_DD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_DD2.TabIndex = 0;
            this.PB_DD2.TabStop = false;
            // 
            // PB_DD1
            // 
            this.PB_DD1.Image = global::LogicDive.Properties.Resources.roadTrack;
            this.PB_DD1.Location = new System.Drawing.Point(0, -519);
            this.PB_DD1.Name = "PB_DD1";
            this.PB_DD1.Size = new System.Drawing.Size(475, 519);
            this.PB_DD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_DD1.TabIndex = 0;
            this.PB_DD1.TabStop = false;
            // 
            // LB_D
            // 
            this.LB_D.AutoSize = true;
            this.LB_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_D.ForeColor = System.Drawing.Color.Gold;
            this.LB_D.Location = new System.Drawing.Point(-2, 525);
            this.LB_D.Name = "LB_D";
            this.LB_D.Size = new System.Drawing.Size(62, 16);
            this.LB_D.TabIndex = 2;
            this.LB_D.Text = "Điểm : 0";
            // 
            // BTN_BD
            // 
            this.BTN_BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BD.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BD.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_BD.Location = new System.Drawing.Point(174, 515);
            this.BTN_BD.Name = "BTN_BD";
            this.BTN_BD.Size = new System.Drawing.Size(134, 32);
            this.BTN_BD.TabIndex = 2;
            this.BTN_BD.Text = "Chơi lại";
            this.BTN_BD.UseVisualStyleBackColor = true;
            this.BTN_BD.Click += new System.EventHandler(this.BTN_BD_Click);
            // 
            // GameTime
            // 
            this.GameTime.Interval = 20;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // GameForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(479, 549);
            this.Controls.Add(this.BTN_BD);
            this.Controls.Add(this.LB_D);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm2_KeyUp);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.GameForm2_Layout);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_NC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_XD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_DD1;
        private System.Windows.Forms.PictureBox PB_XD2;
        private System.Windows.Forms.PictureBox PB_XD1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_BUM;
        private System.Windows.Forms.PictureBox PB_DD2;
        private System.Windows.Forms.Label LB_D;
        private System.Windows.Forms.Button BTN_BD;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.PictureBox PB_V;
        private System.Windows.Forms.PictureBox PB_NC;
    }
}