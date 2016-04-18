using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_4
{
    public partial class Form1 : Form
    {
        int birthyear;
        int year2000 = 2000;
        int age;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text,out birthyear))
            {
                age = year2000 - birthyear;
                label2.Text = "År 2000 fyllde du " + age.ToString() + " år";
            }
            else
            {
                label2.Text = "";
            }
        }
    }
}
