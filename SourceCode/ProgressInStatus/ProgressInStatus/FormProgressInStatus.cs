using System;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;
using System.Windows.Forms;

namespace Template
{
    public partial class FormProgressInStatus : Form
    {
        public FormProgressInStatus()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
        #region basic function for app
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

        private void FormProgressInStatus_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < toolStripProgressBar1.Maximum; i++)
            {
                toolStripProgressBar1.Value += 1;

                if (toolStripProgressBar1.Value == 80)
                {
                    return;
                }
            }
        }
    }
}
