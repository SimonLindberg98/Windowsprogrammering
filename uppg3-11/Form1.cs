using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_11
{
    public partial class Form1 : Form
    {
        string tecken;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            string text = textRuta.Text;
            
            tecken = teckenBox.Text.Substring(0, teckenBox.Text.Length);
            

            for (int i = 0; i < text.Length; i++)
            {
                if(text.Substring(i).Length >= teckenBox.Text.Length)
                {
                    if (text.Substring(i, teckenBox.Text.Length) == tecken)
                    {
                        counter++;
                    }
                }
            }
            amountOfChar.Text = "" + counter;
        }
    }
}
