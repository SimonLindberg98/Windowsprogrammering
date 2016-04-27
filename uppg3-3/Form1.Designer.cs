namespace uppg3_3
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
            this.celsiusBox = new System.Windows.Forms.TextBox();
            this.fahrenheitBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c2fButton = new System.Windows.Forms.Button();
            this.f2cButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // celsiusBox
            // 
            this.celsiusBox.Location = new System.Drawing.Point(67, 63);
            this.celsiusBox.Name = "celsiusBox";
            this.celsiusBox.Size = new System.Drawing.Size(79, 20);
            this.celsiusBox.TabIndex = 1;
            this.celsiusBox.Click += new System.EventHandler(this.celsiusBox_Click);
            this.celsiusBox.TextChanged += new System.EventHandler(this.celsiusBox_TextChanged);
            // 
            // fahrenheitBox
            // 
            this.fahrenheitBox.Location = new System.Drawing.Point(342, 63);
            this.fahrenheitBox.Name = "fahrenheitBox";
            this.fahrenheitBox.Size = new System.Drawing.Size(79, 20);
            this.fahrenheitBox.TabIndex = 3;
            this.fahrenheitBox.Click += new System.EventHandler(this.fahrenheitBox_Click);
            this.fahrenheitBox.TextChanged += new System.EventHandler(this.fahrenheitBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit";
            // 
            // c2fButton
            // 
            this.c2fButton.Location = new System.Drawing.Point(168, 60);
            this.c2fButton.Name = "c2fButton";
            this.c2fButton.Size = new System.Drawing.Size(75, 23);
            this.c2fButton.TabIndex = 4;
            this.c2fButton.Text = "C -> F";
            this.c2fButton.UseVisualStyleBackColor = true;
            this.c2fButton.Click += new System.EventHandler(this.c2fButton_Click);
            // 
            // f2cButton
            // 
            this.f2cButton.Location = new System.Drawing.Point(249, 60);
            this.f2cButton.Name = "f2cButton";
            this.f2cButton.Size = new System.Drawing.Size(75, 23);
            this.f2cButton.TabIndex = 5;
            this.f2cButton.Text = "F -> C";
            this.f2cButton.UseVisualStyleBackColor = true;
            this.f2cButton.Click += new System.EventHandler(this.f2cButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 149);
            this.Controls.Add(this.f2cButton);
            this.Controls.Add(this.c2fButton);
            this.Controls.Add(this.fahrenheitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.celsiusBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox celsiusBox;
        private System.Windows.Forms.TextBox fahrenheitBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button c2fButton;
        private System.Windows.Forms.Button f2cButton;
    }
}

