using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppg1_9
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void kastaButton_Click(object sender, EventArgs e)
        {

            int t1, t2, t3, t4, t5;
            do
            {
                t1 = rand.Next(1, 7);
                t2 = rand.Next(1, 7);
                t3 = rand.Next(1, 7);
                t4 = rand.Next(1, 7);
                t5 = rand.Next(1, 7);
                counter++;
                kastResultat.Items.Add("" +t1 + t2 + t3 + t4 + t5);
            }
            while (t1 != t2 || t1 != t3 || t1 != t4 || t1 != t5);
            antalKastTextBox.Text = counter.ToString();

        }
    }
}
