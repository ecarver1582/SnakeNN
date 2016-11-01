namespace SnakeNN
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
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.textStatic_Score = new System.Windows.Forms.TextBox();
            this.text_score = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // gameWindow
            // 
            this.gameWindow.Location = new System.Drawing.Point(13, 13);
            this.gameWindow.Name = "gameWindow";
            this.gameWindow.Size = new System.Drawing.Size(540, 497);
            this.gameWindow.TabIndex = 0;
            this.gameWindow.TabStop = false;
            // 
            // textStatic_Score
            // 
            this.textStatic_Score.Location = new System.Drawing.Point(587, 13);
            this.textStatic_Score.Name = "textStatic_Score";
            this.textStatic_Score.Size = new System.Drawing.Size(100, 22);
            this.textStatic_Score.TabIndex = 1;
            this.textStatic_Score.Text = "Score";
            // 
            // text_score
            // 
            this.text_score.Location = new System.Drawing.Point(694, 13);
            this.text_score.Name = "text_score";
            this.text_score.Size = new System.Drawing.Size(100, 22);
            this.text_score.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 515);
            this.Controls.Add(this.text_score);
            this.Controls.Add(this.textStatic_Score);
            this.Controls.Add(this.gameWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWindow;
        private System.Windows.Forms.TextBox textStatic_Score;
        private System.Windows.Forms.TextBox text_score;
        private System.Windows.Forms.Timer gameTimer;
    }
}

