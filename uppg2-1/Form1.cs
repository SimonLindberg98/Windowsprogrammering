﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppg2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Knappklick!";
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Ner!";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "Upp!";
        }
    }
}
