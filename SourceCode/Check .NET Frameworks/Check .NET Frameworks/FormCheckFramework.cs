using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;
// make sure that using Microsoft.Win32.SafeHandles; is included
using Microsoft.Win32.SafeHandles;
// make sure that using Microsoft.Win32; is included
using Microsoft.Win32;

namespace Check.NET_Frameworks
{
    public partial class FormCheckFramework : Form
    {
        public FormCheckFramework()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
        void Keys(RegistryKey hk, string relPath)
        {
            if (relPath != "")
                relPath += "/";

            foreach (var keyname in hk.GetSubKeyNames())
            {
                var key = hk.OpenSubKey(keyname, false);

                var keySP = key.GetValue("SP");
                var keyVersion = key.GetValue("Version");
                if (keyVersion != null)
                    listBox1.Items.Add(relPath + keyname +
                      ": Version " + keyVersion.ToString() +
                      ((keySP != null) ? " SP " + keySP.ToString() : "") +
                      (1.Equals(key.GetValue("Install")) ? " installed" : ""));

                Keys(key, relPath + keyname);

                key.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var hkNDP = Registry.LocalMachine.OpenSubKey(
  @"SOFTWARE\Microsoft\NET Framework Setup\NDP", false);
            Keys(hkNDP, "");
            hkNDP.Close();
        }
    }
}
