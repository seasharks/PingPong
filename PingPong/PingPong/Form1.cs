#region File Header

/*[ Compilation unit ----------------------------------------------------------

   Component       : Form1

   Name            : sea_sharks

   Last Author     : Benedek Balazs

   Language        : C#

   Creation Date   : 2016-04-08

   Description     : Storing event hanlers and program initializer.


           Copyright (C) Codecool Kft 2015-2016 All Rights Reserved

-----------------------------------------------------------------------------*/
/*] END */

#endregion File Header

#region Used Namespaces ---------------------------------------------------------------------------

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

#endregion Used Namespaces ----------------------------------------------------------------------------------

namespace PingPong
{
    public partial class Form1 : Form
    {
        public int SpeedLeft = 5; //speed of the ball
        public int SpeedTop = 5;
        public int Points = 0; //score Points
        public int LevelNumber = 1;
        public bool IsPaused = false;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();  //Hide the Cursor
            this.FormBorderStyle = FormBorderStyle.None;    //removes any border
            this.TopMost = true;  //brings the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds; //set window to fullscreen

            #region Setting tool visibility -----------------------------------------------------------------

            gameover_label.Visible = false;
            general_rank_01.Visible = false;
            general_rank_02.Visible = false;
            general_rank_03.Visible = false;
            general_rank_04.Visible = false;
            general_rank_05.Visible = false;
            pause_img.Visible = false;
            background_picture.Visible = true;
            background_gameover.Visible = false;

            #endregion Setting tool visibility --------------------------------------------------------------

            #region Setting tool transparency ---------------------------------------------------------------

            level_of_game.Parent = background_picture;
            level_of_game.BackColor = Color.Transparent;
            level_counter.Parent = background_picture;
            level_counter.BackColor = Color.Transparent;
            score_label.Parent = background_picture;
            score_label.BackColor = Color.Transparent;
            points_label.Parent = background_picture;
            points_label.BackColor = Color.Transparent;
            instructions_label.Parent = background_picture;
            instructions_label.BackColor = Color.Transparent;
            racket.Parent = background_picture;
            racket.BackColor = Color.Transparent;
            grenade.Parent = background_picture;
            grenade.BackColor = Color.Transparent;
            general_rank_01.Parent = background_picture;
            general_rank_01.BackColor = Color.Transparent;
            general_rank_02.Parent = background_picture;
            general_rank_02.BackColor = Color.Transparent;
            general_rank_03.Parent = background_picture;
            general_rank_03.BackColor = Color.Transparent;
            general_rank_04.Parent = background_picture;
            general_rank_04.BackColor = Color.Transparent;
            general_rank_05.Parent = background_picture;
            general_rank_05.BackColor = Color.Transparent;
            pause_img.Parent = background_picture;
            pause_img.BackColor = Color.Transparent;
            exp_bar_percent.Parent = background_picture;
            exp_bar_percent.BackColor = Color.Transparent;

            #endregion Setting tool transparency ------------------------------------------------------------

        }

        #region Setting timer and ball and racket movement -------------------------------------------------- 

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2); //set the center of the racket to the position of the cursor
            grenade.Left += SpeedLeft;     //move the ball
            grenade.Top += SpeedTop;

            if (grenade.Bottom >= racket.Top && grenade.Bottom <= racket.Bottom && grenade.Left >= racket.Left && grenade.Right <= racket.Right) //racket collision
            {
                SpeedTop = -SpeedTop;         //change Direction
                Points += 1;
                points_label.Text = Points.ToString();

                experience_bar.Value += 20;

                if (experience_bar.Value == 100)
                {
                    experience_bar.Value = 0;
                    SpeedTop -= 1;
                    SpeedLeft -= 1;
                    LevelNumber += 1;
                    level_counter.Text = LevelNumber.ToString();

                    if (LevelNumber == 2)
                    {
                        general_rank_01.Visible = true;
                    }
                    if (LevelNumber == 4)
                    {
                        general_rank_02.Visible = true;
                    }
                    if (LevelNumber == 6)
                    {
                        general_rank_03.Visible = true;
                    }
                    if (LevelNumber == 8)
                    {
                        general_rank_04.Visible = true;
                    }
                    if (LevelNumber == 10)
                    {
                        general_rank_05.Visible = true;
                    }
                }

                exp_bar_percent.Text = experience_bar.Value + " %";

            }

            if (grenade.Left <= background.Left)
            {
                SpeedLeft = -SpeedLeft;
            }

            if (grenade.Right >= background.Right)
            {
                SpeedLeft = -SpeedLeft;
            }

            if (grenade.Top <= background.Top)
            {
                SpeedTop = -SpeedTop;
            }

            if (grenade.Bottom >= background.Bottom) // in case of game over
            {
                timer.Enabled = false; //stop the game when ball is out
                gameover_label.Text = gameover_label.Text + "\nYour final score is: " + points_label.Text;

                background_picture.Visible = false;
                background_gameover.Visible = true;
                gameover_label.Visible = true;

                gameover_label.Parent = background_gameover;
                gameover_label.BackColor = Color.Transparent;
            }

        }

        #endregion Setting timer and ball and racket movement -----------------------------------------------

        #region Setting escape and pause --------------------------------------------------------------------

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); //press escape to quit
            }
            if (e.KeyCode == Keys.Space)
            {
                if (IsPaused == false) // game pause on
                {
                    IsPaused = true;
                    timer.Stop();
                    pause_img.Visible = true;
                }
                else if (IsPaused && !gameover_label.Visible) // game pause off
                {
                    IsPaused = false;
                    timer.Start();
                    pause_img.Visible = false;
                }
            }
        }

        #endregion Setting escape and pause -----------------------------------------------------------------

    }
}
