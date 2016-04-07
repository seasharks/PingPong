using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int speed_left = 10; //speed of the ball
        public int speed_top = 10;
        public int points = 0; //score points
        public int level_number = 1;
        public bool isPaused = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();  //Hide the Cursor
            this.FormBorderStyle = FormBorderStyle.None;    //remove any border
            this.TopMost = true;  //bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //make it fullscreen
            racket.Top = background.Bottom - (background.Bottom / 10); //set the position of racket
            gameover_lbl.Left = (background.Width / 2) - (gameover_lbl.Width / 2); //Position to center
            gameover_lbl.Top = (background.Height / 2) - (gameover_lbl.Height / 2);
            gameover_lbl.Visible = false; //hide
            general_rank_01.Visible = false;
            general_rank_02.Visible = false;
            general_rank_03.Visible = false;
            general_rank_04.Visible = false;
            general_rank_05.Visible = false;
            pause_img.Visible = false;
            background_picture.Visible = true;
            background_gameover.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2); //set the center of the racket to the position of the cursor
            grenade.Left += speed_left;     //move the ball
            grenade.Top += speed_top;

            if (grenade.Bottom >= racket.Top && grenade.Bottom <= racket.Bottom && grenade.Left >= racket.Left && grenade.Right <= racket.Right) //racket collision
            {
                speed_top = -speed_top;         //change Direction
                points += 1;
                points_lbl.Text = points.ToString();

                experience_bar.Value += 20;

                if (experience_bar.Value == 100)
                {
                    experience_bar.Value = 0;
                    speed_top += 2;
                    speed_left += 2;
                    level_number += 1;
                    level_counter.Text = level_number.ToString();

                    if (level_number == 10)
                    {
                        general_rank_01.Visible = true;
                    }
                    if (level_number == 20)
                    {
                        general_rank_02.Visible = true;
                    }
                    if (level_number == 30)
                    {
                        general_rank_03.Visible = true;
                    }
                    if (level_number == 40)
                    {
                        general_rank_04.Visible = true;
                    }
                    if (level_number == 50)
                    {
                        general_rank_05.Visible = true;
                    }
                }

                exp_bar_percent.Text = experience_bar.Value + @" %";

            }

            if (grenade.Left <= background.Left)
            {
                speed_left = -speed_left;
            }

            if (grenade.Right >= background.Right)
            {
                speed_left = -speed_left;
            }

            if (grenade.Top <= background.Top)
            {
                speed_top = -speed_top;
            }

            if (grenade.Bottom >= background.Bottom)
            {
                timer1.Enabled = false; //stop the game when ball is out
                gameover_lbl.Text = gameover_lbl.Text + "\nYour final score is: " + points_lbl.Text;
                background_picture.Visible = false;
                background_gameover.Visible = true;
                gameover_lbl.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } //press escape to quit
            if (e.KeyCode == Keys.Space) //pause game
            {
                if (isPaused == false)
                {
                    isPaused = true;
                    timer1.Stop();
                    pause_img.Visible = true;
                }
                else if (isPaused && !gameover_lbl.Visible)
                {
                    isPaused = false;
                    timer1.Start();
                    pause_img.Visible = false;
                }
            }
        }

    }
}
