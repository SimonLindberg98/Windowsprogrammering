using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_8
{
    public partial class Form1 : Form
    {
        int startValue;
        int stopValue;
        int incrementValue;
        int sum;
        double product = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out startValue);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out stopValue);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out incrementValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0;
            product = 1;
            listBox1.Items.Clear();
            for (int i = startValue; i < stopValue +1; i += incrementValue)
            {
                listBox1.Items.Add(i);
                textBox4.Text = (sum += i).ToString();
                textBox5.Text = (product = product * i).ToString();
                
            }
            

        }
    }
}
