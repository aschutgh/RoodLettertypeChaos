﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoodLettertypeChaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_MouseClick(object sender, MouseEventArgs e)
        //{

        //}

        private void convertButton_MouseClick(object sender, MouseEventArgs e)
        {
            //ransomLetter.Text = "";
            //ransomLetter.SelectionFont = new Font("Verdana", 16, FontStyle.Bold);
            //ransomLetter.AppendText(textBox1.Text);

            bool alternate = false;

            foreach (char c in textBox1.Text)
            {
                if (alternate == false)
                {
                    ransomLetter.SelectionFont = new Font("Verdana", 16, FontStyle.Bold);
                    ransomLetter.AppendText(c.ToString());
                    alternate = true;
                }
                else if (alternate == true)
                {
                    ransomLetter.SelectionFont = new Font("Verdana", 16, FontStyle.Regular);
                    ransomLetter.AppendText(c.ToString());
                    alternate = false;
                }
            }
        }
    }
}
