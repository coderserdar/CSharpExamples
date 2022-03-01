using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
// make sure that using System.Runtime.InteropServices; is included
using System.Runtime.InteropServices;
// make sure that using System.Reflection; is included
using System.Reflection;

namespace ShellAbout_dialog
{
    public partial class FormShellAbout : Form
    {
        [DllImport("shell32.dll")]

        static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        public FormShellAbout()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "AppName " + Assembly.GetExecutingAssembly().GetName().Version.ToString(), "", IntPtr.Zero);
        }
    }
}
