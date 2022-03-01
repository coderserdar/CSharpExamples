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
// make sure that using System.Security.Principal; is included
using System.Security.Principal; 

namespace Admin_Check
{
    public partial class FormAdminCheck : Form
    {
        public FormAdminCheck()
        {
            InitializeComponent();
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return  principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if user is admin or not
            string admin = IsAdministrator() ? "User is admin!" : "User is not admin.";
            MessageBox.Show(admin);
        }
        #region basic function for app

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
