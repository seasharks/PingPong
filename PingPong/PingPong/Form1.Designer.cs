﻿namespace PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racket = new System.Windows.Forms.PictureBox();
            this.grenade = new System.Windows.Forms.PictureBox();
            this.scor_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.pause_info = new System.Windows.Forms.Label();
            this.level_of_game = new System.Windows.Forms.Label();
            this.level_counter = new System.Windows.Forms.Label();
            this.experience_bar = new System.Windows.Forms.ProgressBar();
            this.exp_bar_percent = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.pause_img = new System.Windows.Forms.PictureBox();
            this.general_rank_05 = new System.Windows.Forms.PictureBox();
            this.general_rank_04 = new System.Windows.Forms.PictureBox();
            this.general_rank_03 = new System.Windows.Forms.PictureBox();
            this.general_rank_02 = new System.Windows.Forms.PictureBox();
            this.general_rank_01 = new System.Windows.Forms.PictureBox();
            this.background_picture = new System.Windows.Forms.PictureBox();
            this.background_gameover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenade)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_gameover)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Transparent;
            this.racket.Image = ((System.Drawing.Image)(resources.GetObject("racket.Image")));
            this.racket.Location = new System.Drawing.Point(286, 429);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // grenade
            // 
            this.grenade.BackColor = System.Drawing.Color.Transparent;
            this.grenade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grenade.Image = ((System.Drawing.Image)(resources.GetObject("grenade.Image")));
            this.grenade.Location = new System.Drawing.Point(29, 64);
            this.grenade.Name = "grenade";
            this.grenade.Size = new System.Drawing.Size(40, 40);
            this.grenade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grenade.TabIndex = 1;
            this.grenade.TabStop = false;
            // 
            // scor_lbl
            // 
            this.scor_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scor_lbl.AutoSize = true;
            this.scor_lbl.BackColor = System.Drawing.Color.Transparent;
            this.scor_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scor_lbl.Location = new System.Drawing.Point(629, 9);
            this.scor_lbl.Name = "scor_lbl";
            this.scor_lbl.Size = new System.Drawing.Size(80, 25);
            this.scor_lbl.TabIndex = 2;
            this.scor_lbl.Text = "Score: ";
            // 
            // points_lbl
            // 
            this.points_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.points_lbl.AutoSize = true;
            this.points_lbl.BackColor = System.Drawing.Color.Transparent;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_lbl.Location = new System.Drawing.Point(729, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(25, 25);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_lbl.Location = new System.Drawing.Point(292, 206);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(179, 50);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "   YOU LOOSE !\r\nPress Esc to exit!\r\n";
            // 
            // pause_info
            // 
            this.pause_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pause_info.AutoSize = true;
            this.pause_info.BackColor = System.Drawing.Color.Transparent;
            this.pause_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pause_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.pause_info.Location = new System.Drawing.Point(24, 415);
            this.pause_info.Name = "pause_info";
            this.pause_info.Size = new System.Drawing.Size(328, 52);
            this.pause_info.TabIndex = 5;
            this.pause_info.Text = "To pause the game press space!\r\nTo exit press escape!";
            // 
            // level_of_game
            // 
            this.level_of_game.AutoSize = true;
            this.level_of_game.BackColor = System.Drawing.Color.Transparent;
            this.level_of_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.level_of_game.Location = new System.Drawing.Point(12, 10);
            this.level_of_game.Name = "level_of_game";
            this.level_of_game.Size = new System.Drawing.Size(70, 25);
            this.level_of_game.TabIndex = 6;
            this.level_of_game.Text = "Level:";
            // 
            // level_counter
            // 
            this.level_counter.AutoSize = true;
            this.level_counter.BackColor = System.Drawing.Color.Transparent;
            this.level_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.level_counter.Location = new System.Drawing.Point(102, 11);
            this.level_counter.Name = "level_counter";
            this.level_counter.Size = new System.Drawing.Size(24, 25);
            this.level_counter.TabIndex = 7;
            this.level_counter.Text = "0";
            // 
            // experience_bar
            // 
            this.experience_bar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.experience_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.experience_bar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.experience_bar.Location = new System.Drawing.Point(212, 11);
            this.experience_bar.Name = "experience_bar";
            this.experience_bar.Size = new System.Drawing.Size(343, 23);
            this.experience_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.experience_bar.TabIndex = 8;
            // 
            // exp_bar_percent
            // 
            this.exp_bar_percent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exp_bar_percent.AutoSize = true;
            this.exp_bar_percent.BackColor = System.Drawing.Color.Transparent;
            this.exp_bar_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.exp_bar_percent.Location = new System.Drawing.Point(363, 14);
            this.exp_bar_percent.Name = "exp_bar_percent";
            this.exp_bar_percent.Size = new System.Drawing.Size(33, 18);
            this.exp_bar_percent.TabIndex = 9;
            this.exp_bar_percent.Text = "0 %";
            this.exp_bar_percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.background.AutoSize = true;
            this.background.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.pause_img);
            this.background.Controls.Add(this.general_rank_05);
            this.background.Controls.Add(this.general_rank_04);
            this.background.Controls.Add(this.general_rank_03);
            this.background.Controls.Add(this.general_rank_02);
            this.background.Controls.Add(this.general_rank_01);
            this.background.Controls.Add(this.exp_bar_percent);
            this.background.Controls.Add(this.experience_bar);
            this.background.Controls.Add(this.level_counter);
            this.background.Controls.Add(this.level_of_game);
            this.background.Controls.Add(this.pause_info);
            this.background.Controls.Add(this.gameover_lbl);
            this.background.Controls.Add(this.points_lbl);
            this.background.Controls.Add(this.scor_lbl);
            this.background.Controls.Add(this.grenade);
            this.background.Controls.Add(this.racket);
            this.background.Controls.Add(this.background_picture);
            this.background.Controls.Add(this.background_gameover);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.ForeColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(766, 509);
            this.background.TabIndex = 0;
            // 
            // pause_img
            // 
            this.pause_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pause_img.Image = ((System.Drawing.Image)(resources.GetObject("pause_img.Image")));
            this.pause_img.Location = new System.Drawing.Point(349, 159);
            this.pause_img.Name = "pause_img";
            this.pause_img.Size = new System.Drawing.Size(84, 162);
            this.pause_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause_img.TabIndex = 15;
            this.pause_img.TabStop = false;
            // 
            // general_rank_05
            // 
            this.general_rank_05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.general_rank_05.Image = ((System.Drawing.Image)(resources.GetObject("general_rank_05.Image")));
            this.general_rank_05.Location = new System.Drawing.Point(703, 422);
            this.general_rank_05.Name = "general_rank_05";
            this.general_rank_05.Size = new System.Drawing.Size(45, 45);
            this.general_rank_05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.general_rank_05.TabIndex = 14;
            this.general_rank_05.TabStop = false;
            // 
            // general_rank_04
            // 
            this.general_rank_04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.general_rank_04.Image = ((System.Drawing.Image)(resources.GetObject("general_rank_04.Image")));
            this.general_rank_04.Location = new System.Drawing.Point(499, 422);
            this.general_rank_04.Name = "general_rank_04";
            this.general_rank_04.Size = new System.Drawing.Size(45, 45);
            this.general_rank_04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.general_rank_04.TabIndex = 13;
            this.general_rank_04.TabStop = false;
            // 
            // general_rank_03
            // 
            this.general_rank_03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.general_rank_03.Image = ((System.Drawing.Image)(resources.GetObject("general_rank_03.Image")));
            this.general_rank_03.Location = new System.Drawing.Point(652, 422);
            this.general_rank_03.Name = "general_rank_03";
            this.general_rank_03.Size = new System.Drawing.Size(45, 45);
            this.general_rank_03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.general_rank_03.TabIndex = 12;
            this.general_rank_03.TabStop = false;
            // 
            // general_rank_02
            // 
            this.general_rank_02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.general_rank_02.Image = ((System.Drawing.Image)(resources.GetObject("general_rank_02.Image")));
            this.general_rank_02.Location = new System.Drawing.Point(550, 422);
            this.general_rank_02.Name = "general_rank_02";
            this.general_rank_02.Size = new System.Drawing.Size(45, 45);
            this.general_rank_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.general_rank_02.TabIndex = 11;
            this.general_rank_02.TabStop = false;
            // 
            // general_rank_01
            // 
            this.general_rank_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.general_rank_01.Image = ((System.Drawing.Image)(resources.GetObject("general_rank_01.Image")));
            this.general_rank_01.Location = new System.Drawing.Point(601, 422);
            this.general_rank_01.Name = "general_rank_01";
            this.general_rank_01.Size = new System.Drawing.Size(45, 45);
            this.general_rank_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.general_rank_01.TabIndex = 10;
            this.general_rank_01.TabStop = false;
            // 
            // background_picture
            // 
            this.background_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_picture.Image = ((System.Drawing.Image)(resources.GetObject("background_picture.Image")));
            this.background_picture.Location = new System.Drawing.Point(1, 1);
            this.background_picture.Name = "background_picture";
            this.background_picture.Size = new System.Drawing.Size(766, 507);
            this.background_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_picture.TabIndex = 16;
            this.background_picture.TabStop = false;
            // 
            // background_gameover
            // 
            this.background_gameover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background_gameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background_gameover.Image = ((System.Drawing.Image)(resources.GetObject("background_gameover.Image")));
            this.background_gameover.Location = new System.Drawing.Point(1, 1);
            this.background_gameover.Name = "background_gameover";
            this.background_gameover.Size = new System.Drawing.Size(766, 507);
            this.background_gameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_gameover.TabIndex = 18;
            this.background_gameover.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 509);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenade)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_rank_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_gameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox grenade;
        private System.Windows.Forms.Label scor_lbl;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Label pause_info;
        private System.Windows.Forms.Label level_of_game;
        private System.Windows.Forms.Label level_counter;
        private System.Windows.Forms.ProgressBar experience_bar;
        private System.Windows.Forms.Label exp_bar_percent;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox general_rank_01;
        private System.Windows.Forms.PictureBox general_rank_05;
        private System.Windows.Forms.PictureBox general_rank_04;
        private System.Windows.Forms.PictureBox general_rank_03;
        private System.Windows.Forms.PictureBox general_rank_02;
        private System.Windows.Forms.PictureBox pause_img;
        private System.Windows.Forms.PictureBox background_picture;
        private System.Windows.Forms.PictureBox background_gameover;
    }
}

