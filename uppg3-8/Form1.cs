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
    public partial class Form1 : Form
    {
        double price, finalPrice, moms;
        public static double momsMultiplier;
        
            
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            this.Text = "Momskalkylator";
            
        }

        private void momsTrue_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void momsFalse_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            moms5.Checked = moms12.Checked = moms25.Checked = userInput.Checked = false;
            momsMultiplier = 0;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double.TryParse(prePriceBox.Text, out price);
            moms = price * momsMultiplier;
            finalPrice = price + moms;
            endPriceBox.Text = finalPrice.ToString();
        }

        private void userInput_CheckedChanged(object sender, EventArgs e)
        {
            if(userInput.Checked == true)
            {
                Form f2 = new Form2();

                f2.ShowDialog();
            }
            
        }

        private void moms5_CheckedChanged(object sender, EventArgs e)
        {
            momsMultiplier = 0.05;
        }

        private void endPriceBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void endPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void endPriceBox_Enter(object sender, EventArgs e)
        {
            
                MessageBox.Show("Skriv endast in priset i den vänstra rutan!");
                endPriceBox.Clear();
                prePriceBox.Focus();
            
        }

        private void moms12_CheckedChanged(object sender, EventArgs e)
        {
            momsMultiplier = 0.12;
        }

        private void moms25_CheckedChanged(object sender, EventArgs e)
        {
            momsMultiplier = 0.25;
        }
    }
}
