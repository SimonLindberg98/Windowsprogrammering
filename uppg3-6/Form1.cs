using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_6
{
    public partial class Form1 : Form
    {
        int year, month, day, dayError = 0;
        public Form1()
        {
            this.Text = "Månadsnamn";
            InitializeComponent();
        }

        private void monthButton_Click(object sender, EventArgs e)
        {
            //Byggde in så att det inte får vara för många dagar i en viss månad
            dayError = 0;

            switch (month)
            {
                case 01:
                    if(day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Januari");
                    break;
                case 02:
                    if (day > 28)
                    {
                        //Räknar ut om det är skottår
                        int.TryParse(dateBox.Text.Substring(0, 4), out year);
                        if (dateBox.Text.Substring(2, 2) == "00")
                        {
                            if(year % 400 == 0)
                            {
                                if (day > 29)
                                {
                                    dayError = 1;
                                    break;
                                }
                            }
                            else
                            {
                                dayError = 1;
                                break;
                            }
                        }
                        else if(year % 4 == 0)
                        {
                            if(day > 29)
                            {
                                dayError = 1;
                                break;
                            }
                        }
                        else
                        {
                            dayError = 1;
                            break;
                        }
                        
                    }
                    MessageBox.Show("Februari");
                    break;
                case 03:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Mars");
                    break;
                case 04:
                    if (day > 30)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("April");
                    break;
                case 05:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Maj");
                    break;
                case 06:
                    if (day > 30)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Juni");
                    break;
                case 07:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Juli");
                    break;
                case 08:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Augusti");
                    break;
                case 09:
                    if (day > 30)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("September");
                    break;
                case 10:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("Oktober");
                    break;
                case 11:
                    if (day > 30)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("November");
                    break;
                case 12:
                    if (day > 31)
                    {
                        dayError = 1;
                        break;
                    }
                    MessageBox.Show("December");
                    break;
            }
            if(dayError == 1)
            {
                MessageBox.Show("dd i datumet du skrev in är ogiltigt, försök igen");
                dateBox.Text = dateBox.Text.Remove(6, 2);

            }

            
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            if(dateBox.Text.Length > 8)
            {
                MessageBox.Show("Skriv in datumet med formatet ååååmmdd! Försök igen");
                dateBox.Clear();
            }
            else if(dateBox.Text.Length == 8)
            {
                int.TryParse(dateBox.Text.Substring(4, 2), out month);
                int.TryParse(dateBox.Text.Substring(6, 2), out day);
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Månaden måste vara mellan 01 och 12");
                }
            }
            
        }
    }
}
