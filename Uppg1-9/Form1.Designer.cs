namespace Uppg1_9
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
            this.kastaButton = new System.Windows.Forms.Button();
            this.kastResultat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.antalKastTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kastaButton
            // 
            this.kastaButton.Location = new System.Drawing.Point(47, 51);
            this.kastaButton.Name = "kastaButton";
            this.kastaButton.Size = new System.Drawing.Size(105, 31);
            this.kastaButton.TabIndex = 0;
            this.kastaButton.Text = "Kasta";
            this.kastaButton.UseVisualStyleBackColor = true;
            this.kastaButton.Click += new System.EventHandler(this.kastaButton_Click);
            // 
            // kastResultat
            // 
            this.kastResultat.FormattingEnabled = true;
            this.kastResultat.Location = new System.Drawing.Point(192, 51);
            this.kastResultat.Name = "kastResultat";
            this.kastResultat.Size = new System.Drawing.Size(120, 186);
            this.kastResultat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Antal kast:";
            // 
            // antalKastTextBox
            // 
            this.antalKastTextBox.Location = new System.Drawing.Point(192, 258);
            this.antalKastTextBox.Name = "antalKastTextBox";
            this.antalKastTextBox.Size = new System.Drawing.Size(120, 20);
            this.antalKastTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 309);
            this.Controls.Add(this.antalKastTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kastResultat);
            this.Controls.Add(this.kastaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kastaButton;
        private System.Windows.Forms.ListBox kastResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox antalKastTextBox;
    }
}

