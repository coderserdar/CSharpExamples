using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;   // make sure that using System.Net; is included
using System.Diagnostics;   // make sure that using System.Diagnostics; is included

namespace HTTP_Download_WinRar_example
{
    public partial class FormHttpWinRar : Form
    {
        public FormHttpWinRar()
        {
            InitializeComponent();
        }

        WebClient webClient = new WebClient();

        private void button1_Click(object sender, EventArgs e)
        {
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webclient_DownloadFileCompleted);
            // start download
            webClient.DownloadFileAsync(new Uri(textBox1.Text), @"C:\\MYRAR.EXE");          
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        void webclient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Saved as C:\\MYRAR.EXE", "Httpdownload");
        }

    }
}
