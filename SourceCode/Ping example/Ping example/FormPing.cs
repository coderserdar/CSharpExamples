using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// make sure that using System.Runtime.InteropServices; is included
using System.Diagnostics;
// make sure that using System.Net.NetworkInformation; is included
using System.Net.NetworkInformation;
// make sure that using System.Threading; is included for method Sleep
using System.Threading;

namespace Ping_example
{
    public partial class FormPing : Form
    {
        public FormPing()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; ++i)
            {
                // Thread.Sleep(500);
                using (Ping p = new Ping())
                {
                    // label1.Text = p.Send("www.google.com").RoundtripTime.ToString() + "ms";
                    listView1.Items.Add(p.Send("www.google.com").RoundtripTime.ToString() + "ms\n");
                }
            }

        }
    }
}
