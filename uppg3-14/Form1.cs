using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unevenButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i+=2)
            {
                listBox1.Items.Add("" + i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(1);
            for (int i = 2; i < 1000000; i=i*2)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
