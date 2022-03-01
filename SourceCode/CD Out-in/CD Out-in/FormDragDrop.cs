using System;
using System.Diagnostics;
// make sure that using System.Runtime.InteropServices; is included
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CD_Out_in
{
    public partial class frmExamples : Form
    {
        // DLLImport calling every .dll's winmm.dll, and function mciSendStringA
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]

        /*
        Here is are implementation of function "mciSendStringA", and we call it "msciSendString", be sure that you have same arguments in prototype like original function have
        */
        public static extern int msciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        public frmExamples()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // in case that you use virtual drives please make sure your
            // physical CD/DVD drive is listed first
            // this opens cd/dvd
            msciSendString("set CDAudio door open", "", 127, IntPtr.Zero);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // this closes the cd/dvd
            try
            {
                msciSendString("set CDAudio door closed", "", 0, IntPtr.Zero);
            }
            catch (Exception ena)
            {
                MessageBox.Show(ena.ToString());
                throw;
            }

        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
}
