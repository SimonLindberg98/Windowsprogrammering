namespace uppg3_4
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
            this.teckenBox = new System.Windows.Forms.TextBox();
            this.asciiBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t2aButton = new System.Windows.Forms.Button();
            this.a2tButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tecken";
            // 
            // teckenBox
            // 
            this.teckenBox.Location = new System.Drawing.Point(54, 69);
            this.teckenBox.Name = "teckenBox";
            this.teckenBox.Size = new System.Drawing.Size(91, 20);
            this.teckenBox.TabIndex = 1;
            this.teckenBox.TextChanged += new System.EventHandler(this.teckenBox_TextChanged);
            // 
            // asciiBox
            // 
            this.asciiBox.Location = new System.Drawing.Point(314, 67);
            this.asciiBox.Name = "asciiBox";
            this.asciiBox.Size = new System.Drawing.Size(91, 20);
            this.asciiBox.TabIndex = 3;
            this.asciiBox.TextChanged += new System.EventHandler(this.asciiBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ASCII-kod (32-255)";
            // 
            // t2aButton
            // 
            this.t2aButton.Location = new System.Drawing.Point(151, 66);
            this.t2aButton.Name = "t2aButton";
            this.t2aButton.Size = new System.Drawing.Size(75, 23);
            this.t2aButton.TabIndex = 4;
            this.t2aButton.Text = "=>";
            this.t2aButton.UseVisualStyleBackColor = true;
            this.t2aButton.Click += new System.EventHandler(this.t2aButton_Click);
            // 
            // a2tButton
            // 
            this.a2tButton.Location = new System.Drawing.Point(233, 65);
            this.a2tButton.Name = "a2tButton";
            this.a2tButton.Size = new System.Drawing.Size(75, 23);
            this.a2tButton.TabIndex = 5;
            this.a2tButton.Text = "<=";
            this.a2tButton.UseVisualStyleBackColor = true;
            this.a2tButton.Click += new System.EventHandler(this.a2tButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 136);
            this.Controls.Add(this.a2tButton);
            this.Controls.Add(this.t2aButton);
            this.Controls.Add(this.asciiBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teckenBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teckenBox;
        private System.Windows.Forms.TextBox asciiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button t2aButton;
        private System.Windows.Forms.Button a2tButton;
    }
}

