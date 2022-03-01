using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // IO it is needed for working with File object
using System.Diagnostics;   // make sure that using System.Diagnostics; is included
// make sure that you add reference Microsoft.VisualBasic

namespace Total_Physical_Memory
{
    public partial class FormTotalPhysicalMemory : Form
    {
        public FormTotalPhysicalMemory()
        {
            InitializeComponent();
        }

        static ulong GetTotalPhysicalMemory()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }

        static long ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024) / 1024;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConvertBytesToMegabytes((long)GetTotalPhysicalMemory()).ToString() + " MB");
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
}
