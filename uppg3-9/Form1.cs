using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_9
{
    public partial class Form1 : Form
    {
        int userInput, randNum = 43, counter = 0, cluesNum = 0;
        bool needHelp = false, hot = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clues_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            needHelp = true;
            helpLabel.Text = "Hjälp:";
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out userInput);
            if(userInput == randNum)
            {
                Result.Text = "Korrekt!";
                helpLabel.Text = "";
                clues.Text = "";
                needHelp = false;
            }
            else if(userInput < randNum)
            {
                Result.Text = "För lågt!";
                textBox1.Clear();
                textBox1.Focus();

            }
            else if(userInput > randNum)
            {
                Result.Text = "För högt!";
                textBox1.Clear();
                textBox1.Focus();

            }

            if (needHelp == true)
            {
                if (userInput == randNum)
                {
                    clues.Text = "Korrekt!";
                    cluesNum = 0;
                }
                if (userInput > randNum)
                {
                    if (hot == false)
                    {
                        if (userInput - randNum < 15)
                        {
                            clues.Text = "Nu är det varmt";
                            hot = true;
                            cluesNum = userInput - randNum;
                        }
                        else
                        {
                            clues.Text = "Kallt";
                        }
                    }
                    else
                    {
                        if (cluesNum < userInput - randNum)
                        {
                            clues.Text = "Kallare";
                        }
                        else if (cluesNum > userInput - randNum)
                        {
                            clues.Text = "Varmare";
                        }
                    }


                }
                else
                {
                    if (hot == false)
                    {
                        if (randNum - userInput < 15)
                        {
                            clues.Text = "Nu är det varmt";
                            hot = true;
                            cluesNum = randNum - userInput;
                        }
                        else
                        {
                            clues.Text = "Kallt";
                        }
                    }
                    else
                    {
                        if (cluesNum < randNum - userInput)
                        {
                            clues.Text = "Kallare";
                        }
                        else if (cluesNum > randNum - userInput)
                        {
                            clues.Text = "Varmare";
                        }
                    }
                }
            }

            counter++;
            numTries.Text = "" + counter;

        }

    }
}
