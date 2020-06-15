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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CountriesLabel = new System.Windows.Forms.Label();
            this.FlagLabel = new System.Windows.Forms.Label();
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
            this.flagBoxOne.Click += new System.EventHandler(this.flagBoxOne_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Testclick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlagLabel);
            this.Controls.Add(this.CountriesLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CountriesLabel;
        private System.Windows.Forms.Label FlagLabel;
    }
}

