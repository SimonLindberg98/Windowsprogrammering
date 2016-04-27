using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_4
{
    public partial class Form1 : Form
    {
        string tecken, kod;
        int numKod;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Teckenkoder";
        }

        private void teckenBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tecken = teckenBox.Text;
                if(tecken.Length > 1)
                {
                    MessageBox.Show("Skriv bara in ett tecken åt gången! Försök igen");
                    teckenBox.Clear();
                }
            }
            catch
            {

            }
            
        }

        private void asciiBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kod = asciiBox.Text;
                int.TryParse(kod, out numKod);
                
            }
            catch
            {

            }
        }

        private void t2aButton_Click(object sender, EventArgs e)
        {
            char firstTecken = tecken[0];
            asciiBox.Text = "" + (int)firstTecken;
        }

        private void a2tButton_Click(object sender, EventArgs e)
        {
            if (numKod < 32 || numKod > 255)
            {
                MessageBox.Show("Talet måste vara mellan 32 och 255! Försök igen");
                asciiBox.Clear();
            }
            else
            {
                teckenBox.Text = "" + (char)numKod;
            }
            
        }
    }
}
