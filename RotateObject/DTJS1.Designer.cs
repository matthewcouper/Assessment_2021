namespace RotateObject
{
    partial class DTJS1
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
            this.tmrSpaceship = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSpaceship
            // 
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.BurlyWood;
            this.PnlGame.Controls.Add(this.lblTime);
            this.PnlGame.Controls.Add(this.label10);
            this.PnlGame.Controls.Add(this.label9);
            this.PnlGame.Controls.Add(this.label8);
            this.PnlGame.Controls.Add(this.label7);
            this.PnlGame.Controls.Add(this.label6);
            this.PnlGame.Controls.Add(this.label5);
            this.PnlGame.Controls.Add(this.txtLives);
            this.PnlGame.Controls.Add(this.label4);
            this.PnlGame.Controls.Add(this.lblScore);
            this.PnlGame.Controls.Add(this.label3);
            this.PnlGame.Controls.Add(this.label2);
            this.PnlGame.Controls.Add(this.txtName);
            this.PnlGame.Controls.Add(this.label1);
            this.PnlGame.Controls.Add(this.menuStrip1);
            this.PnlGame.Location = new System.Drawing.Point(0, 0);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(473, 450);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(214, 415);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 19);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(193, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "time left";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(141, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "the second installment.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 31);
            this.label8.TabIndex = 11;
            this.label8.Text = "dont think. just shoot.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "dont think. just shoot.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "dont think. just shoot.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "dont think. just shoot.";
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.Location = new System.Drawing.Point(309, 415);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(29, 19);
            this.txtLives.TabIndex = 7;
            this.txtLives.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "lives";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(417, 416);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 19);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "player";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 418);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "dont think. just shoot.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Font = new System.Drawing.Font("Cooper Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(50, 22);
            this.MnuStart.Text = "start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Font = new System.Drawing.Font("Cooper Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(46, 22);
            this.MnuStop.Text = "stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // tmrPlanet
            // 
            this.tmrPlanet.Enabled = true;
            this.tmrPlanet.Interval = 1;
            this.tmrPlanet.Tick += new System.EventHandler(this.tmrPlanet_Tick);
            // 
            // tmrShoot
            // 
            this.tmrShoot.Enabled = true;
            this.tmrShoot.Interval = 1;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // DTJS1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "DTJS1";
            this.Text = "level one";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpaceship;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.Timer tmrPlanet;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
    }
}

