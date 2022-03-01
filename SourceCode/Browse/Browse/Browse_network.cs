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
using Template;

namespace Browse
{
    public partial class Browse_network : Form
    {
        public Browse_network()
        {
            InitializeComponent();
        }

        public List<String> ListOfComputers()
        {
            List<String> ComputerNames = new List<String>();
            String _ComputerSchema = "Computer";
            System.DirectoryServices.DirectoryEntry _WinNTDirectoryEntries = new System.DirectoryServices.DirectoryEntry("WinNT:");
            foreach (System.DirectoryServices.DirectoryEntry _AvailDomains in _WinNTDirectoryEntries.Children)
            {
                foreach (System.DirectoryServices.DirectoryEntry PCNames in _AvailDomains.Children)
                {
                    if (PCNames.SchemaClassName.ToLower().Contains(_ComputerSchema.ToLower()))
                    {
                        ComputerNames.Add(PCNames.Name);
                        listBox1.Items.Add(PCNames.Name);
                    }
                }
            }
            return ComputerNames;
        }

        private void Browse_network_Load(object sender, EventArgs e)
        {
            ListOfComputers();
        }
    }
}
