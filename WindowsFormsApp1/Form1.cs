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
            divRadioButton4.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            button2.Enabled = false;
            clearResultsToolStripMenuItem.Enabled = false;
        }
    }
}
