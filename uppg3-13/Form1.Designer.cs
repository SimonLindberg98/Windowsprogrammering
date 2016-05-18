namespace uppg3_13
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.newUserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.delUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(128, 25);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(127, 82);
            this.userListBox.TabIndex = 0;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // newUserBox
            // 
            this.newUserBox.Location = new System.Drawing.Point(9, 26);
            this.newUserBox.Name = "newUserBox";
            this.newUserBox.Size = new System.Drawing.Size(100, 20);
            this.newUserBox.TabIndex = 1;
            this.newUserBox.Click += new System.EventHandler(this.newUserBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn:";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(9, 53);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 23);
            this.addUserButton.TabIndex = 3;
            this.addUserButton.Text = "Lägg till";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // delUserButton
            // 
            this.delUserButton.Location = new System.Drawing.Point(9, 82);
            this.delUserButton.Name = "delUserButton";
            this.delUserButton.Size = new System.Drawing.Size(100, 23);
            this.delUserButton.TabIndex = 4;
            this.delUserButton.Text = "Ta bort";
            this.delUserButton.UseVisualStyleBackColor = true;
            this.delUserButton.Click += new System.EventHandler(this.delUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Användare:";
            // 
            // numOfUsers
            // 
            this.numOfUsers.AutoSize = true;
            this.numOfUsers.Location = new System.Drawing.Point(183, 10);
            this.numOfUsers.Name = "numOfUsers";
            this.numOfUsers.Size = new System.Drawing.Size(0, 13);
            this.numOfUsers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 129);
            this.Controls.Add(this.numOfUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserBox);
            this.Controls.Add(this.userListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.TextBox newUserBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button delUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numOfUsers;
    }
}

