using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Undersökning";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Text = "Ja";
            button2.Text = "Nej";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "Ja";
            button1.Text = "Nej";
        }
    }
}
