using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_2
{
    public partial class Form1 : Form
    {
        string name, surName, birthdate;

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                surName = surnameBox.Text.Substring(0, 2);
            }
            catch
            {

            }
        }

        private void birthdateBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                birthdate = birthdateBox.Text;
            }
            catch
            {

            }
            

        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            if (birthdate.Length == 6)
            {
                birthdate = birthdate.Substring(2, 4);
                MessageBox.Show(name.ToLower() + surName.ToLower() + birthdate);
            }
            else if (birthdate.Length == 8)
            {
                birthdate = birthdate.Substring(4, 4);
                MessageBox.Show(name.ToLower() + surName.ToLower() + birthdate);
            }
            else
            {
                MessageBox.Show("Skriv in ditt födelsedatum som ååmmdd eller ååååmmdd !");
            }
            
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                name = nameBox.Text.Substring(0, 1);
            }
            catch
            {

            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

       
    }
}
