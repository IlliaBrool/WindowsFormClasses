using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Johnny Bravo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dIvideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dIvideToolStripMenuItem.Checked = true;
            addToolStripMenuItem.Checked = false;
            subToolStripMenuItem.Checked = false;
            multiplyToolStripMenuItem.Checked = false;
            divideToolStripMenuItem1.Checked = false;
            substractToolStripMenuItem.Checked = false;
            divideToolStripMenuItem1.Checked = false;
            divRadioButton4.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            button2.Enabled = false;
            clearResultsToolStripMenuItem.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            if (e.KeyChar == '.' && (textBox1.Text.IndexOf('.') != -1))
            {
                e.Handled = true;
            }


            else
            if (!char.IsDigit(e.KeyChar)
                &&
                (e.KeyChar != '\b')
                &&
                (e.KeyChar != '.')

                ) e.Handled = true;
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(textBox1.Text, out a)
                &&
                double.TryParse(textBox2.Text, out b))
                button1.Enabled = true;
            else button1.Enabled = false;
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            if (addRadioButton1.Checked)
                richTextBox1.Text += (a + b).ToString() + "\r\n";
            button2.Enabled = true;
            
        }
    }
}
