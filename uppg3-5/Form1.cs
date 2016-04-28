using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "ASCII-tabell";
            InitializeComponent();
            for (int i = 32; i < 256; i++)
            {
                listBox1.Items.Add((char)i + "\t" + i);
            }
        }
    }
}
