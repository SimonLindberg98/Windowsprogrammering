using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_1
{
    public partial class Form1 : Form
    {
        string name;
        string surName;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Presentation";
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            name = nameBox.Text;
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            surName = surnameBox.Text;
        }

        private void presentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is " + surName + ", " + name + " " + surName);
        }
    }
}
