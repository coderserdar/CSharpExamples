using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// make sure that using System.Diagnostics; is included
using System.Diagnostics; 

namespace Template
{
    public partial class FormCalculator : Form
    {

        public double value_1;
        public double value_2;
        public double result;
        public string equal;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
        #region basic function for app
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } 
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "+";
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "/";
        }

        private void buttonMinuse_Click(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "-";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "+";
        }

        private void buttonMinuse_Click_1(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "-";
        }

        private void buttonMultiple_Click_1(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "*";
        }

        private void buttonDivide_Click_1(object sender, EventArgs e)
        {
            value_1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            equal = "/";
        }

        private void buttonEqual_Click_1(object sender, EventArgs e)
        {
            switch (equal)
            {
                case ("+"):
                    value_2 = double.Parse(textBox1.Text);
                    result = value_1 + value_2;
                    textBox1.Text = result.ToString();
                    break;

                case ("-"):
                    value_2 = double.Parse(textBox1.Text);
                    result = value_1 - value_2;
                    textBox1.Text = result.ToString();
                    break;

                case ("*"):
                    value_2 = double.Parse(textBox1.Text);
                    result = value_1 * value_2;
                    textBox1.Text = result.ToString();
                    break;

                case ("/"):
                    value_2 = double.Parse(textBox1.Text);
                    result = value_1 / value_2;
                    textBox1.Text = result.ToString();
                    break;
            }
        }
    }
}
