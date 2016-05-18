namespace uppg3_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numTries = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpLabel = new System.Windows.Forms.Label();
            this.clues = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gissa ett tal mellan 1 och 100:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gissa!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal försök:";
            // 
            // numTries
            // 
            this.numTries.AutoSize = true;
            this.numTries.Location = new System.Drawing.Point(124, 80);
            this.numTries.Name = "numTries";
            this.numTries.Size = new System.Drawing.Size(13, 13);
            this.numTries.TabIndex = 4;
            this.numTries.Text = "0";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(328, 75);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Hjälp";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Location = new System.Drawing.Point(51, 152);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(0, 13);
            this.helpLabel.TabIndex = 6;
            // 
            // clues
            // 
            this.clues.AutoSize = true;
            this.clues.Location = new System.Drawing.Point(91, 152);
            this.clues.Name = "clues";
            this.clues.Size = new System.Drawing.Size(0, 13);
            this.clues.TabIndex = 7;
            this.clues.Click += new System.EventHandler(this.clues_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(51, 114);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 198);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.clues);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.numTries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numTries;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label clues;
        private System.Windows.Forms.Label Result;
    }
}

