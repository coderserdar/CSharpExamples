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
// make sure that using System.Drawing.Imaging; is included
using System.Drawing.Imaging;

namespace Screen_Capture
{
    public partial class FormScreenCapture : Form
    {
        public FormScreenCapture()
        {
            InitializeComponent();
        }
        private string tempfile = "C://tempfile_.jpg";

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com"); 
        }

        private void ScreanCapture()
        {
            if (Directory.Exists(Path.GetDirectoryName(tempfile)))
            {
                pictureBox1.Image = null;
                File.Delete(tempfile);
            }
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save(tempfile, ImageFormat.Jpeg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreanCapture();
            FileStream fs = new FileStream(tempfile, FileMode.Open);
            // pictureBox1.Image = new Bitmap(tempfile);
            pictureBox1.Image = new Bitmap(fs);
            fs.Close();            
        }
    }
}
