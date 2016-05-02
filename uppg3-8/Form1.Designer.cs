namespace uppg3_8
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
            this.prePriceBox = new System.Windows.Forms.TextBox();
            this.endPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.momsFalse = new System.Windows.Forms.RadioButton();
            this.momsTrue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userInput = new System.Windows.Forms.RadioButton();
            this.moms25 = new System.Windows.Forms.RadioButton();
            this.moms12 = new System.Windows.Forms.RadioButton();
            this.moms5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pris utan moms:";
            // 
            // prePriceBox
            // 
            this.prePriceBox.Location = new System.Drawing.Point(27, 46);
            this.prePriceBox.Name = "prePriceBox";
            this.prePriceBox.Size = new System.Drawing.Size(100, 20);
            this.prePriceBox.TabIndex = 1;
            // 
            // endPriceBox
            // 
            this.endPriceBox.BackColor = System.Drawing.SystemColors.Control;
            this.endPriceBox.Location = new System.Drawing.Point(393, 46);
            this.endPriceBox.Name = "endPriceBox";
            this.endPriceBox.Size = new System.Drawing.Size(100, 20);
            this.endPriceBox.TabIndex = 3;
            this.endPriceBox.TextChanged += new System.EventHandler(this.endPriceBox_TextChanged);
            this.endPriceBox.Enter += new System.EventHandler(this.endPriceBox_Enter);
            this.endPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endPriceBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pris med moms:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(312, 44);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Beräkna";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.momsFalse);
            this.groupBox1.Controls.Add(this.momsTrue);
            this.groupBox1.Location = new System.Drawing.Point(133, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moms";
            // 
            // momsFalse
            // 
            this.momsFalse.AutoSize = true;
            this.momsFalse.Location = new System.Drawing.Point(7, 44);
            this.momsFalse.Name = "momsFalse";
            this.momsFalse.Size = new System.Drawing.Size(41, 17);
            this.momsFalse.TabIndex = 1;
            this.momsFalse.TabStop = true;
            this.momsFalse.Text = "Nej";
            this.momsFalse.UseVisualStyleBackColor = true;
            this.momsFalse.CheckedChanged += new System.EventHandler(this.momsFalse_CheckedChanged);
            // 
            // momsTrue
            // 
            this.momsTrue.AutoSize = true;
            this.momsTrue.Location = new System.Drawing.Point(7, 20);
            this.momsTrue.Name = "momsTrue";
            this.momsTrue.Size = new System.Drawing.Size(36, 17);
            this.momsTrue.TabIndex = 0;
            this.momsTrue.TabStop = true;
            this.momsTrue.Text = "Ja";
            this.momsTrue.UseVisualStyleBackColor = true;
            this.momsTrue.CheckedChanged += new System.EventHandler(this.momsTrue_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userInput);
            this.groupBox2.Controls.Add(this.moms25);
            this.groupBox2.Controls.Add(this.moms12);
            this.groupBox2.Controls.Add(this.moms5);
            this.groupBox2.Location = new System.Drawing.Point(223, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 111);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Momssats";
            // 
            // userInput
            // 
            this.userInput.AutoSize = true;
            this.userInput.Location = new System.Drawing.Point(7, 91);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(69, 17);
            this.userInput.TabIndex = 3;
            this.userInput.TabStop = true;
            this.userInput.Text = "Välj egen";
            this.userInput.UseVisualStyleBackColor = true;
            this.userInput.CheckedChanged += new System.EventHandler(this.userInput_CheckedChanged);
            // 
            // moms25
            // 
            this.moms25.AutoSize = true;
            this.moms25.Location = new System.Drawing.Point(7, 68);
            this.moms25.Name = "moms25";
            this.moms25.Size = new System.Drawing.Size(45, 17);
            this.moms25.TabIndex = 2;
            this.moms25.TabStop = true;
            this.moms25.Text = "25%";
            this.moms25.UseVisualStyleBackColor = true;
            this.moms25.CheckedChanged += new System.EventHandler(this.moms25_CheckedChanged);
            // 
            // moms12
            // 
            this.moms12.AutoSize = true;
            this.moms12.Location = new System.Drawing.Point(7, 44);
            this.moms12.Name = "moms12";
            this.moms12.Size = new System.Drawing.Size(45, 17);
            this.moms12.TabIndex = 1;
            this.moms12.TabStop = true;
            this.moms12.Text = "12%";
            this.moms12.UseVisualStyleBackColor = true;
            this.moms12.CheckedChanged += new System.EventHandler(this.moms12_CheckedChanged);
            // 
            // moms5
            // 
            this.moms5.AutoSize = true;
            this.moms5.Location = new System.Drawing.Point(7, 19);
            this.moms5.Name = "moms5";
            this.moms5.Size = new System.Drawing.Size(39, 17);
            this.moms5.TabIndex = 0;
            this.moms5.TabStop = true;
            this.moms5.Text = "5%";
            this.moms5.UseVisualStyleBackColor = true;
            this.moms5.CheckedChanged += new System.EventHandler(this.moms5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 152);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.endPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prePriceBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prePriceBox;
        private System.Windows.Forms.TextBox endPriceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton momsFalse;
        private System.Windows.Forms.RadioButton momsTrue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton moms25;
        private System.Windows.Forms.RadioButton moms12;
        private System.Windows.Forms.RadioButton moms5;
        private System.Windows.Forms.RadioButton userInput;
    }
}

