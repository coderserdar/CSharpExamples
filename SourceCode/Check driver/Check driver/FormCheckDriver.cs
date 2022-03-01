using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// make sure that is included reference System.Management
// make sure that using System.Management; is included
using System.Management;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;

namespace Check_driver
{
    public partial class FormCheckDriver : Form
    {
        public FormCheckDriver()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
        private void GetDrivers()
        {
            System.Management.SelectQuery query = new System.Management.SelectQuery("Win32_SystemDriver");
            System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(query);
            af.Items.Clear();
            foreach (System.Management.ManagementObject ManageObject in searcher.Get())
            {
                af.Items.Add("Name: " + ManageObject["Name"] + " StartMode: " + ManageObject["StartMode"] + " State: " + ManageObject["State"] + " Description: " + ManageObject["Description"] + " PathName: " + ManageObject["PathName"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetDrivers();
        }

    }
}
