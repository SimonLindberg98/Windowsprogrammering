using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Socialdemokraterna";
            label4.Text = "Stefan Löfven";
            label5.Text = "";
            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Moderaterna";
            label4.Text = "Anna Kinberg-Batra";
            label5.Text = "";
            label6.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Sverigedemokraterna";
            label4.Text = "Jimmie Åkesson";
            label5.Text = "";
            label6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "Miljöpartiet";
            label4.Text = "Gustav Fridolin";
            label5.Text = "Åsa Romson";
            label6.Text = "Språkrör:";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Centerpartiet";
            label4.Text = "Annie Lööf";
            label5.Text = "";
            label6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Vänsterpartiet";
            label4.Text = "Jonas Sjöstedt";
            label5.Text = "";
            label6.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Liberalerna";
            label4.Text = "Jan Björklund";
            label5.Text = "";
            label6.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "Partiledare: ";
            label3.Text = "Kristdemokraterna";
            label4.Text = "Ebba Busch Thor";
            label5.Text = "";
            label6.Text = "";
        }
    }
}
