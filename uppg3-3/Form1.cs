using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_3
{
    public partial class Form1 : Form
    {
        string celsius, fahrenheit;
        double celsiusNum, fahrenheitNum;

        private void celsiusBox_TextChanged(object sender, EventArgs e)
        {
            if(celsiusBox.Text.Length > 0)
            {
                celsius = celsiusBox.Text;
            }
        }

        private void fahrenheitBox_TextChanged(object sender, EventArgs e)
        {
            if (fahrenheitBox.Text.Length > 0)
            {
                fahrenheit = fahrenheitBox.Text;
            }
        }

        private void c2fButton_Click(object sender, EventArgs e)
        {
            try
            {
                celsiusNum = double.Parse(celsius);
                fahrenheitNum = (((9 * celsiusNum) / 5) + 32);
                fahrenheit = fahrenheitNum.ToString("0.##");
                fahrenheitBox.Text = fahrenheit;
            }
            catch
            {

            }
        }

        private void celsiusBox_Click(object sender, EventArgs e)
        {
            celsiusBox.SelectAll();
        }

        private void fahrenheitBox_Click(object sender, EventArgs e)
        {
            fahrenheitBox.SelectAll();
        }

        private void f2cButton_Click(object sender, EventArgs e)
        {
            try
            {
                fahrenheitNum = double.Parse(fahrenheit);
                celsiusNum = ((fahrenheitNum - 32) * ((double)5 / 9));
                celsius = celsiusNum.ToString("0.##");
                celsiusBox.Text = celsius;
            }
            catch
            {
                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
