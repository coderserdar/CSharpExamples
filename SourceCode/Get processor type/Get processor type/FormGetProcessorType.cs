using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Get_processor_type
{
    public partial class FormGetProcessorType : Form
    {
        public FormGetProcessorType()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER") );            
        }
    }
}
