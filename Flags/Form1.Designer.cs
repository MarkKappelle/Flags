namespace Flags
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
            this.flagBoxOne = new System.Windows.Forms.PictureBox();
            this.CountriesLabel = new System.Windows.Forms.Label();
            this.FlagLabel = new System.Windows.Forms.Label();
            this.buttonGameStart = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.Label();
            this.HighscoreBox = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagBoxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // flagBoxOne
            // 
            this.flagBoxOne.Location = new System.Drawing.Point(227, 36);
            this.flagBoxOne.Name = "flagBoxOne";
            this.flagBoxOne.Size = new System.Drawing.Size(229, 174);
            this.flagBoxOne.TabIndex = 0;
            this.flagBoxOne.TabStop = false;
            // 
            // CountriesLabel
            // 
            this.CountriesLabel.AutoSize = true;
            this.CountriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountriesLabel.Location = new System.Drawing.Point(12, 12);
            this.CountriesLabel.Name = "CountriesLabel";
            this.CountriesLabel.Size = new System.Drawing.Size(99, 24);
            this.CountriesLabel.TabIndex = 3;
            this.CountriesLabel.Text = "Countries";
            // 
            // FlagLabel
            // 
            this.FlagLabel.AutoSize = true;
            this.FlagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagLabel.Location = new System.Drawing.Point(223, 9);
            this.FlagLabel.Name = "FlagLabel";
            this.FlagLabel.Size = new System.Drawing.Size(51, 24);
            this.FlagLabel.TabIndex = 4;
            this.FlagLabel.Text = "Flag";
            // 
            // buttonGameStart
            // 
            this.buttonGameStart.Location = new System.Drawing.Point(508, 36);
            this.buttonGameStart.Name = "buttonGameStart";
            this.buttonGameStart.Size = new System.Drawing.Size(75, 23);
            this.buttonGameStart.TabIndex = 5;
            this.buttonGameStart.Text = "Start Game";
            this.buttonGameStart.UseVisualStyleBackColor = true;
            this.buttonGameStart.Click += new System.EventHandler(this.StartGame);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(589, 36);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(152, 23);
            this.buttonA.TabIndex = 6;
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.AnswerClick);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(589, 65);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(152, 23);
            this.buttonB.TabIndex = 7;
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.AnswerClick);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(589, 94);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(152, 23);
            this.buttonC.TabIndex = 8;
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.AnswerClick);
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreBox.Location = new System.Drawing.Point(505, 152);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(38, 13);
            this.scoreBox.TabIndex = 10;
            this.scoreBox.Text = "Score:";
            // 
            // HighscoreBox
            // 
            this.HighscoreBox.AutoSize = true;
            this.HighscoreBox.Location = new System.Drawing.Point(505, 175);
            this.HighscoreBox.Name = "HighscoreBox";
            this.HighscoreBox.Size = new System.Drawing.Size(58, 13);
            this.HighscoreBox.TabIndex = 11;
            this.HighscoreBox.Text = "Highscore:";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(505, 66);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 18);
            this.labelAnswer.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.HighscoreBox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonGameStart);
            this.Controls.Add(this.FlagLabel);
            this.Controls.Add(this.CountriesLabel);
            this.Controls.Add(this.flagBoxOne);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.form_load);
            ((System.ComponentModel.ISupportInitialize)(this.flagBoxOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flagBoxOne;
        private System.Windows.Forms.Label CountriesLabel;
        private System.Windows.Forms.Label FlagLabel;
        private System.Windows.Forms.Button buttonGameStart;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Label HighscoreBox;
        private System.Windows.Forms.Label labelAnswer;
    }
}

