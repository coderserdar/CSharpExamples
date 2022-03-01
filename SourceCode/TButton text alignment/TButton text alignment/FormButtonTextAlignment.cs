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

namespace TButton_text_alignment
{
    public partial class FormButtonTextAlignment : Form
    {
        public FormButtonTextAlignment()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}
