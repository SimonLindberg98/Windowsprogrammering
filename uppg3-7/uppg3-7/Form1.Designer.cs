namespace uppg3_7
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
            this.numBox = new System.Windows.Forms.TextBox();
            this.formButton = new System.Windows.Forms.Button();
            this.formNumBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefonnummer";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(43, 48);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(91, 20);
            this.numBox.TabIndex = 1;
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(150, 46);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(75, 23);
            this.formButton.TabIndex = 2;
            this.formButton.Text = "Formatera";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // formNumBox
            // 
            this.formNumBox.Location = new System.Drawing.Point(240, 48);
            this.formNumBox.Name = "formNumBox";
            this.formNumBox.Size = new System.Drawing.Size(100, 20);
            this.formNumBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Formaterat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formNumBox);
            this.Controls.Add(this.formButton);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.TextBox formNumBox;
        private System.Windows.Forms.Label label2;
    }
}

