using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg4_1
{
    public partial class Form1 : Form
    {
        int low, high;
        Random rand = new Random();
        int[] v;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                int r = rand.Next(1, 1001);
                listBox1.Items.Add(r);
                v = new int[] {r}; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out low);
            int.TryParse(textBox2.Text, out high);

            for (int i = 0; i < 100; i++)
            {
                if(v[i] < high && v[i] s low)
                {
                    listBox2.Items.Add(v[i]);
                }
            }
        }
    }
}
