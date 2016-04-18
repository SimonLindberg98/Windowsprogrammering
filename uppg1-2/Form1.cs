using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Röd";
            label2.Text = "Grön";
            label3.Text = "Blå";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Red";
            label2.Text = "Green";
            label3.Text = "Blue";
        }
    }
}
