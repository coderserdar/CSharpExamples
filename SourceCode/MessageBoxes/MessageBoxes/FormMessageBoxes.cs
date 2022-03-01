using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   // make sure that using System.Diagnostics; is included

namespace MessageBoxes
{
    public partial class FormMessageBoxes : Form
    {
        public FormMessageBoxes()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBox1.Items)
            {
                if (comboBox1.SelectedIndex == 0)
                {   // no icon
                    MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK); break;
                }
                if (comboBox1.SelectedIndex == 1)
                {   // info icon ...
                    MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                }
                if (comboBox1.SelectedIndex == 2)
                {   // question icon
                    MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Question); break;
                }
                if (comboBox1.SelectedIndex == 3)
                {   // warning icon
                    MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                }
                if (comboBox1.SelectedIndex == 4)
                {   // error icon
                    MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                }
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Choose Yes or No", "MsgBox result", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Your choice: YES", "MessageBoxExample", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (d == DialogResult.No)
            {
                MessageBox.Show("Your choice: NO", "MessageBoxExample", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        } 
    }
}
