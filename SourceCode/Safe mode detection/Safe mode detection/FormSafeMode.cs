using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Safe_mode_detection
{
    public partial class FormSafeMode : Form
    {
        public FormSafeMode()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SystemInformation.BootMode != BootMode.Normal)
            {
                MessageBox.Show("System is running in safe mode");
            }
            else
            {
                MessageBox.Show("System is running in normal boot mode");
            }
        }
    }
}
