using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            for (int i = 0; i < text.Length; i++)
            {
                if(text.Substring(i,1) == " ")
                {
                    text = text.Replace(" ", string.Empty);
                }
            }

            if(IsPalindrome(text) == true)
            {
                if(text.Length == 0)
                {
                    yesNoLabel.Text = "Falskt";
                }
                else
                {
                    yesNoLabel.Text = "Sant";
                }
            }
            else
            {
                yesNoLabel.Text = "Falskt";
            }
        }

        

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
