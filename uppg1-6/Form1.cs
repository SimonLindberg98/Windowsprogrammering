using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg1_6
{
    public partial class Form1 : Form
    {
        int userInput;
        string ortOutput;

            
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int.TryParse(textBox1.Text, out userInput);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (userInput)
            {
                case 0910: ortOutput = "Skellefteå";
                           break;
                case 0911: ortOutput = "Piteå";
                    break;
                case 0912: ortOutput = "Byske";
                    break;
                case 0913: ortOutput = "Lövånger";
                    break;
                case 0914: ortOutput = "Burträsk";
                    break;
                case 0915: ortOutput = "Bastuträsk";
                    break;
                default: ortOutput = "Det riktnummret känns inte igen.";
                    break;
            }
            label1.Text = ortOutput;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
