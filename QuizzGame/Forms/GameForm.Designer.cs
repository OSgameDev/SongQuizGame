namespace QuizGame.Forms
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
            this.LivesLabel = new System.Windows.Forms.Label();
            this.FirstLettersOfSongNameWords = new System.Windows.Forms.Label();
            this.NameOfArtist = new System.Windows.Forms.Label();
            this.SongGuess = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LivesLabel.ForeColor = System.Drawing.Color.Lime;
            this.LivesLabel.Location = new System.Drawing.Point(38, 16);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(97, 32);
            this.LivesLabel.TabIndex = 0;
            this.LivesLabel.Text = "Lives: 2";
            // 
            // FirstLettersOfSongNameWords
            // 
            this.FirstLettersOfSongNameWords.AutoSize = true;
            this.FirstLettersOfSongNameWords.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstLettersOfSongNameWords.ForeColor = System.Drawing.Color.White;
            this.FirstLettersOfSongNameWords.Location = new System.Drawing.Point(151, 87);
            this.FirstLettersOfSongNameWords.Name = "FirstLettersOfSongNameWords";
            this.FirstLettersOfSongNameWords.Size = new System.Drawing.Size(386, 32);
            this.FirstLettersOfSongNameWords.TabIndex = 0;
            this.FirstLettersOfSongNameWords.Text = "First Letter of each word: S L T S";
            this.FirstLettersOfSongNameWords.Click += new System.EventHandler(this.FirstLettersOfSongNameWords_Click);
            // 
            // NameOfArtist
            // 
            this.NameOfArtist.AutoSize = true;
            this.NameOfArtist.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameOfArtist.ForeColor = System.Drawing.Color.White;
            this.NameOfArtist.Location = new System.Drawing.Point(151, 149);
            this.NameOfArtist.Name = "NameOfArtist";
            this.NameOfArtist.Size = new System.Drawing.Size(192, 32);
            this.NameOfArtist.TabIndex = 0;
            this.NameOfArtist.Text = "Name of artist :";
            // 
            // SongGuess
            // 
            this.SongGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SongGuess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SongGuess.Location = new System.Drawing.Point(151, 236);
            this.SongGuess.Name = "SongGuess";
            this.SongGuess.Size = new System.Drawing.Size(318, 33);
            this.SongGuess.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(151, 312);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(318, 44);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Try your luck";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(240, 390);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(139, 44);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.ForeColor = System.Drawing.Color.Lime;
            this.ScoreLabel.Location = new System.Drawing.Point(258, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(106, 32);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // LostLabel
            // 
            this.LostLabel.AutoSize = true;
            this.LostLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LostLabel.ForeColor = System.Drawing.Color.Red;
            this.LostLabel.Location = new System.Drawing.Point(490, 16);
            this.LostLabel.Name = "LostLabel";
            this.LostLabel.Size = new System.Drawing.Size(89, 32);
            this.LostLabel.TabIndex = 0;
            this.LostLabel.Text = "Lost: 0";
            this.LostLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(626, 457);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SongGuess);
            this.Controls.Add(this.NameOfArtist);
            this.Controls.Add(this.FirstLettersOfSongNameWords);
            this.Controls.Add(this.LostLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.LivesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Label FirstLettersOfSongNameWords;
        private System.Windows.Forms.Label NameOfArtist;
        private System.Windows.Forms.TextBox SongGuess;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label LostLabel;
    }
}