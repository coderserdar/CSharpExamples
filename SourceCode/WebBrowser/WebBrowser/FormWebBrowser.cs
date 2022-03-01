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
    public partial class FormWebBrowser : Form
    {
        public FormWebBrowser()
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
            webBrowser1.GoBack();
            textBox1.Text = webBrowser1.Url.ToString();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
            textBox1.Text = webBrowser1.Url.ToString();
        }
    }
}
