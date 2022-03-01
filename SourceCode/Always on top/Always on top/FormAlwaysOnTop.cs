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

namespace Always_on_top
{
    public partial class FormAlwaysOnTop : Form
    {
        public FormAlwaysOnTop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TopMost = true;            
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
}
