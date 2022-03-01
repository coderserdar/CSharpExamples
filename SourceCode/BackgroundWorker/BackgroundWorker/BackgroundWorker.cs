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

namespace BackgroundWorker
{
    public partial class FormBackgroundWorker : Form
    {
        public FormBackgroundWorker()
        {
            InitializeComponent();

            Shown += new EventHandler(FormBackgroundWorker_Shown);

            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);

            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
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

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        void FormBackgroundWorker_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

    }
}
