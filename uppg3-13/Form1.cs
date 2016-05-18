using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_13
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Register";
            AcceptButton = addUserButton;
            if(userListBox.SelectedIndex == -1)
            {
                delUserButton.Enabled = false;
            }
            else
            {
                delUserButton.Enabled = true;
            }
            
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if(newUserBox.Text.Length > 0)
            {
                userListBox.Items.Add(newUserBox.Text);
                counter++;
                numOfUsers.Text = "" + counter;
                newUserBox.Clear();
                userListBox.Sorted = true;
            }
            
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListBox.SelectedIndex == -1)
            {
                delUserButton.Enabled = false;
            }
            else
            {
                delUserButton.Enabled = true;
            }
        }

        private void delUserButton_Click(object sender, EventArgs e)
        {
            userListBox.Items.RemoveAt(userListBox.SelectedIndex);
            counter--;
            numOfUsers.Text = "" + counter;
        }

        private void newUserBox_Click(object sender, EventArgs e)
        {
            userListBox.ClearSelected();
        }
    }
}
