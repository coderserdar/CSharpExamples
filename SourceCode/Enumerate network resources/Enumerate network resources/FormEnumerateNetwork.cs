using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// make sure to indlude reference System.Management; and using System.Management; is included

using System.Management;

// make sure that using System.Diagnostics; is included
using System.Diagnostics;
using Enumerate_network_resources;

namespace Enumerate_network_resources
{
    public partial class FormEnumerateNetwork : Form
    {
        public FormEnumerateNetwork()
        {
            InitializeComponent();
        }        

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com"); 
        }

        public List<String> ListOfComputers()
        {
            List<String> ComputersNames = new List<String>();
            String Computers = "Computer";
            System.DirectoryServices.DirectoryEntry _WinNTDirectoryEntries = new System.DirectoryServices.DirectoryEntry("WinNT:");
            foreach (System.DirectoryServices.DirectoryEntry _AvailDomains in _WinNTDirectoryEntries.Children)
            {
                foreach (System.DirectoryServices.DirectoryEntry _PCNameEntry in _AvailDomains.Children)
                {
                    if (_PCNameEntry.SchemaClassName.ToLower().Contains(Computers.ToLower()))
                    {
                        ComputersNames.Add(_PCNameEntry.Name);
                        listBox1.Items.Add(_PCNameEntry.Name.ToString());
                    }
                }
            }
            return ComputersNames;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfComputers();
        }
    }
}
