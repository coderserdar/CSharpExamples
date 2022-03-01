using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Browse;

// make sure that using System.Diagnostics; is included
using System.Diagnostics;

namespace Template
{
    public partial class FormBrowse : Form
    {
        public FormBrowse()
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

        private void button2_Click(object sender, EventArgs e)
        {            
            using (Browse_network bf = new Browse_network())
            {
                bf.ShowDialog(this);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }
    }
}
