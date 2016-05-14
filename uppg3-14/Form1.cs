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
        int unevenNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void unevenButton_Click(object sender, EventArgs e)
        {
            for (int i = unevenNum; i < 100; i++)
            {
                listBox1.Items.Add("" + unevenNum);
            }
        }
    }
}
