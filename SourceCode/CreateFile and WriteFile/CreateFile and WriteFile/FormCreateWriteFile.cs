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
// make sure that using System.IO; is included
using System.IO;


namespace CreateFile_and_WriteFile
{
    public partial class FormCreateWriteFile : Form
    {
        public FormCreateWriteFile()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "c:\\CreateFileExample.txt";
            using (var fs = File.Create(filepath)) 
            {
                foreach (var a in richTextBox1.Text)
                {
                    fs.WriteByte((byte)a);
                }
            }
            if (File.Exists(filepath))
            {
                Process.Start(filepath);
            }
        }
    }
}
