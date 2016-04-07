namespace PingPong
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
            this.score = new System.Windows.Forms.Label();
            this.scoreCounter = new System.Windows.Forms.Label();
            this.levelCounter = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.lifeCounter = new System.Windows.Forms.Label();
            this.levelBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(12, 27);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 0;
            this.score.Text = "Score";
            // 
            // scoreCounter
            // 
            this.scoreCounter.AutoSize = true;
            this.scoreCounter.Location = new System.Drawing.Point(12, 40);
            this.scoreCounter.Name = "scoreCounter";
            this.scoreCounter.Size = new System.Drawing.Size(13, 13);
            this.scoreCounter.TabIndex = 1;
            this.scoreCounter.Text = "0";
            // 
            // levelCounter
            // 
            this.levelCounter.AutoSize = true;
            this.levelCounter.Location = new System.Drawing.Point(242, 9);
            this.levelCounter.Name = "levelCounter";
            this.levelCounter.Size = new System.Drawing.Size(42, 13);
            this.levelCounter.TabIndex = 2;
            this.levelCounter.Text = "Level 1";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Location = new System.Drawing.Point(477, 27);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(24, 13);
            this.life.TabIndex = 3;
            this.life.Text = "Life";
            // 
            // lifeCounter
            // 
            this.lifeCounter.AutoSize = true;
            this.lifeCounter.Location = new System.Drawing.Point(477, 40);
            this.lifeCounter.Name = "lifeCounter";
            this.lifeCounter.Size = new System.Drawing.Size(24, 13);
            this.lifeCounter.TabIndex = 4;
            this.lifeCounter.Text = "3/3";
            // 
            // levelBar
            // 
            this.levelBar.Location = new System.Drawing.Point(73, 30);
            this.levelBar.Name = "levelBar";
            this.levelBar.Size = new System.Drawing.Size(385, 23);
            this.levelBar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.levelBar);
            this.Controls.Add(this.lifeCounter);
            this.Controls.Add(this.life);
            this.Controls.Add(this.levelCounter);
            this.Controls.Add(this.scoreCounter);
            this.Controls.Add(this.score);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreCounter;
        private System.Windows.Forms.Label levelCounter;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label lifeCounter;
        private System.Windows.Forms.ProgressBar levelBar;
    }
}

