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

// make sure that using System.Threading; is included
using System.Threading;

namespace Template
{
    public partial class FormThreads : Form
    {
        public FormThreads()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Thread first_thread = new Thread(new ThreadStart(first_thread_procedure));
            Thread second_thread = new Thread(new ThreadStart(second_thread_procedure));
            first_thread.Start();
            second_thread.Start();
            first_thread.Join();
        }
        public void first_thread_procedure()
        {
            Thread.Sleep(500);
            MessageBox.Show("Hello from first thread :) ... ");
        }

        public void second_thread_procedure()
        {
            Thread.Sleep(1000);
            MessageBox.Show("Hello from second thread :) ... ");
        }
    }
}
