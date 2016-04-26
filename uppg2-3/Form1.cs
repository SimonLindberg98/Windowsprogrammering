using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg2_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label3.Text = "" + Height;
            label4.Text = "" + Width;
            this.Text = "Testa ändra storlek på rutan!";
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            label3.Text = "" + Height;
            label4.Text = "" + Width;
        }

    }
}
