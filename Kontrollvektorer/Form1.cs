using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrollvektorer
{
    public partial class Form1 : Form
    {
        Label[] v;
        public Form1()
        {
            InitializeComponent();

            v = new Label[] { label1, label2, label3, label4, label5, label6 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i].Text = "Hej " + i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i].Text = "Label " + i;
            }
        }
    }
}
