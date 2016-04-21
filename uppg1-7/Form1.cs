using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_7
{
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double bmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out height);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out weight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmi = (weight / (height * height));
            label5.Text = bmi.ToString();
            
            if(bmi < 15)
            {
                label6.Text = "Mager";
            }
            else if(bmi > 15 && bmi < 20)
            {
                label6.Text = "Underviktig";
            }
            else if(bmi > 20 && bmi < 25)
            {
                label6.Text = "Normal";
            }
            else if(bmi > 25 && bmi < 30)
            {
                label6.Text = "Överviktig";
            }
            else if(bmi > 30 && bmi < 40)
            {
                label6.Text = "Fet";
            }
            else if(bmi > 40)
            {
                label6.Text = "Kraftigt fet";
            }
        }
    }
}
