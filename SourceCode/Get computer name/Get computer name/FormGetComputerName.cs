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

namespace Get_computer_name
{
    public partial class FormGetComputerName : Form
    {
        public FormGetComputerName()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer name: " + System.Environment.MachineName.ToString(), "GetComputername");
        }
    }
}
