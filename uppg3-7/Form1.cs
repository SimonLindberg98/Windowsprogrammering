using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_7
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            if (formattedNumBox.Text.Length > 1)
            {
                MessageBox.Show("Skriv endast in ditt nummer i den vänstra rutan!");
                formattedNumBox.Clear();
                numBox.Clear();
            }
            else
            {
                if(numBox.Text.Length == 5)
                {
                    formattedNumBox.Text = numBox.Text.Substring(0, 3) + " " + numBox.Text.Substring(3, 2);
                }
                else if(numBox.Text.Length == 6)
                {
                    formattedNumBox.Text = numBox.Text.Substring(0, 2) + " " + numBox.Text.Substring(2, 2) + " " + numBox.Text.Substring(4, 2);
                }
                else if(numBox.Text.Length  == 7)
                {
                    formattedNumBox.Text = numBox.Text.Substring(0, 3) + " " + numBox.Text.Substring(3, 2) + " " + numBox.Text.Substring(5, 2);
                }
            }
        }
    }
}
