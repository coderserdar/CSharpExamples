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

// make sure that using System.Net; is included
using System.Net;

// make sure that using System.IO;  is included
using System.IO; 

namespace Template
{
    public partial class FormSourceCodeUrl : Form
    {
        public FormSourceCodeUrl()
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
            string Url = textBox2.Text;
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Url);
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            StreamReader Stream = new StreamReader(Response.GetResponseStream());
            richTextBox1.Text = Stream.ReadToEnd();
            Stream.Close();
        }
    }
}
