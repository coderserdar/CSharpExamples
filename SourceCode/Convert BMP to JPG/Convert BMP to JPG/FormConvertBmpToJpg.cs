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
// make sure that using System.IO; for read and write bytes
using System.IO;
// make sure that using System.Drawing.Imaging; for drawin image
using System.Drawing.Imaging;

namespace Convert_BMP_to_JPG
{
    public partial class FormConvertBmpToJpg : Form
    {
        public FormConvertBmpToJpg()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set Filename to blank
            openFileDialog1.FileName = "";
            // fileter onyl bmp files
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp";            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] raw = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                Path.GetDirectoryName(openFileDialog1.FileName);
                using (Image img = Image.FromStream(new MemoryStream(raw)))
                {
                    img.Save(openFileDialog1.InitialDirectory + openFileDialog1.FileName.Replace(".bmp", ".jpg"), ImageFormat.Jpeg);
                }
            }
        }
    }
}
