namespace CarGame
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LevelPlayer = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.GameSpeed = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LevelPlayer);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.Car1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.road2);
            this.panel1.Controls.Add(this.road1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 535);
            this.panel1.TabIndex = 0;
            // 
            // LevelPlayer
            // 
            this.LevelPlayer.Image = global::CarGame.Properties.Resources.bronze;
            this.LevelPlayer.Location = new System.Drawing.Point(80, 206);
            this.LevelPlayer.Name = "LevelPlayer";
            this.LevelPlayer.Size = new System.Drawing.Size(250, 100);
            this.LevelPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LevelPlayer.TabIndex = 7;
            this.LevelPlayer.TabStop = false;
            this.LevelPlayer.Tag = "CarRight";
            this.LevelPlayer.Visible = false;
            // 
            // car2
            // 
            this.car2.Image = global::CarGame.Properties.Resources.carYellow;
            this.car2.Location = new System.Drawing.Point(333, 41);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(50, 99);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car2.TabIndex = 6;
            this.car2.TabStop = false;
            this.car2.Tag = "CarRight";
            // 
            // Car1
            // 
            this.Car1.Image = global::CarGame.Properties.Resources.carGreen;
            this.Car1.Location = new System.Drawing.Point(80, 39);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(50, 101);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Car1.TabIndex = 5;
            this.Car1.TabStop = false;
            this.Car1.Tag = "CarLeft";
            // 
            // player
            // 
            this.player.Image = global::CarGame.Properties.Resources.CarRed;
            this.player.Location = new System.Drawing.Point(207, 406);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // road2
            // 
            this.road2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.road2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.road2.Image = global::CarGame.Properties.Resources.roadTrack;
            this.road2.Location = new System.Drawing.Point(0, 0);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(440, 535);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 2;
            this.road2.TabStop = false;
            // 
            // road1
            // 
            this.road1.Image = global::CarGame.Properties.Resources.roadTrack;
            this.road1.Location = new System.Drawing.Point(0, -535);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(440, 535);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 0;
            this.road1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.lblScorePlayer);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 167);
            this.panel2.TabIndex = 1;
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScorePlayer.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer.ForeColor = System.Drawing.Color.White;
            this.lblScorePlayer.Location = new System.Drawing.Point(0, 0);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(441, 109);
            this.lblScorePlayer.TabIndex = 1;
            this.lblScorePlayer.Text = "Score";
            this.lblScorePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(441, 55);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // GameSpeed
            // 
            this.GameSpeed.Interval = 20;
            this.GameSpeed.Tick += new System.EventHandler(this.GameSpeed_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(441, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameSpeed;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox LevelPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScorePlayer;
    }
}

