using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FIXME: fontfamilies niet via Form1 constructor doorgeven???
// Ik weet (nog) niet wat correct is...

namespace RoodLettertypeChaos
{
    public partial class Form1 : Form
    {
        public Form1(FontFamily[] ffamily)
        {
            InitializeComponent();
            FFamily = ffamily;
        }

        public FontFamily[] FFamily { get; set; }

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
            Random rand = new Random();
            ransomLetter.Text = "";

            foreach (char c in textBox1.Text)
            {

                ransomLetter.SelectionFont = new Font(FFamily[rand.Next(0, FFamily.Length - 1)].Name, 16, FontStyle.Regular);
                ransomLetter.AppendText(c.ToString());
            }
            
            //ransomLetter.SelectionFont = new Font(FFamily[4].Name, 16, FontStyle.Bold);
            //ransomLetter.AppendText(textBox1.Text);
        }
    }
}
