using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// make sure that using System.Runtime.InteropServices; is included
using System.Runtime.InteropServices;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;
// make sure that using System.IO; is included
using System.IO;

namespace FileDates_Info
{
    public partial class FormFileDates : Form
    {
        public FormFileDates()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void FileDataInfo(string file) {

            FileInfo info = new FileInfo(file);

            DateTime time = info.CreationTime;

            time = info.LastWriteTime;

            listBox1.Items.Add(time.ToString());

            time = info.LastAccessTime;

           //  MessageBox.Show(time.ToString());

           //  
          //   Console.WriteLine(time.ToString());

            listBox1.Items.Add(time.ToString());
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileDataInfo(Path.GetFullPath(openFileDialog1.FileName));
            }
        }
    }
}
