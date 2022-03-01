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

namespace TrayIcon_example
{
    public partial class FormTrayIcon : Form
    {
        NotifyIcon notify = new NotifyIcon();

        public FormTrayIcon()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Application working...";
            notifyIcon1.BalloonTipTitle = "TrayIcon example application";
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void hideAplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void c_CheckStateChanged(object sender, EventArgs e)
        {
            if (c.CheckState == CheckState.Checked)
            {
                notifyIcon1.Visible = true;

            }
            if (c.CheckState == CheckState.Unchecked)
            {
                notifyIcon1.Visible = false;
            }
        }
    }
}
