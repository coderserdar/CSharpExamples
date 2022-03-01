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

using WCF.ServiceReference1;

namespace Template
{
    public partial class FormWcf : Form
    {
        public FormWcf()
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
            WCF.ServiceReference1.Service1Client t = new WCF.ServiceReference1.Service1Client();
            MyNewObject n = new MyNewObject();
            n.Hello = textBox2.Text;
            t.SayHelloFromWCF(n);
            textBox1.Text = n.Hello;
        }
    }
}
