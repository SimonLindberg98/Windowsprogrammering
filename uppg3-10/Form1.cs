using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_10
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Slumptalsstatistik";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int num, maxNum1 = 0, minNum1 = 100, total = 0;
            double avgNum1;

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(num = rand.Next(1, 101));
                total += num;
                if (num > maxNum1)
                {
                    maxNum1 = num;
                }
                if (num < minNum1)
                {
                    minNum1 = num;
                }
            }

            avgNum1 = total / (double)10;

            minNum.Text = "" + minNum1;
            maxNum.Text = "" + maxNum1;
            avgNum.Text = "" + avgNum1;
        }
    }
}
