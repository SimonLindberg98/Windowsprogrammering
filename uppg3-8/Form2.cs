using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Egen moms";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void customMoms_TextChanged(object sender, EventArgs e)
        {
            if(customMoms.Text.Length > 0)
            {
                try
                {
                    Form1.momsMultiplier = double.Parse(customMoms.Text);
                    Form1.momsMultiplier = Form1.momsMultiplier / 100;
                }
                catch
                {
                    MessageBox.Show("Skriv endast in momssatsen med siffror!");
                    customMoms.Clear();
                    
                }
            }
        }
    }
}
