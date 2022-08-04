using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "GAME STARTED!";

            button1.Enabled = false;
            button2.Enabled = Enabled;
            label1.Text = "Multiply by 2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = Enabled;
            label1.Text = "Add 10";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = Enabled;
            label1.Text = "Divide by 2";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = Enabled;
            label1.Text = "Subtract your number";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button6.Visible = Enabled;
            label1.Text = "Multiply by 3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button7.Visible = Enabled;
            label1.Text = "Subtract 5";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = Enabled;
            label1.Text = "Add 1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            button9.Visible = Enabled;
            label1.Text = "Is the result 11?";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GOODBY!", ":))");
            Close();
        }
    }
}