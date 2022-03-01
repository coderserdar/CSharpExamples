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

using System.Threading;

namespace Template
{
    public partial class FormFirewall : Form
    {        
        public FormFirewall()
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
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe"; firewall.StartInfo.WorkingDirectory = @"\windows\system32\";
            firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=enable";
            firewall.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe";    firewall.StartInfo.WorkingDirectory = @"\windows\system32\";
            firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=disable";
            firewall.Start();
        }
    }
}
