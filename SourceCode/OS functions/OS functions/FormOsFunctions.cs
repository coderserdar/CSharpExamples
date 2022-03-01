using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // make sure that using System.Runtime.InteropServices; is included
using System.Diagnostics;   // make sure that using System.Diagnostics; is included

namespace OS_functions
{
    public partial class FormOsFunctions : Form
    {
        public FormOsFunctions()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int operationFlag, int operationReason);

        private void button1_Click(object sender, EventArgs e)
        {
            // Log off  the System 
            ExitWindowsEx(0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Shut Down the System
            ExitWindowsEx(1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Restart the System 
            ExitWindowsEx(2, 0);
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
}
