using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
// make sure that using System.Drawing.Imaging; is included
using System.Drawing.Imaging;

namespace Color_to_Gray
{
    public partial class FormColorToGray : Form
    {
        Bitmap bit;
        Image file;
        public FormColorToGray()
        {
            InitializeComponent();
        }

        Bitmap grayScaleBP = new System.Drawing.Bitmap(2, 2, System.Drawing.Imaging.PixelFormat.Format16bppGrayScale);

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.vclexamples.com/");
        } 
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            pictureBox1.Image = bit; 
            for (int x = 0; x < bit.Width; x++)
            {
                for (int y = 0; y < bit.Height; y++)
                {
                    Color originalColor = bit.GetPixel(x, y);
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    bit.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = bit; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            
            if (dr == DialogResult.OK)
            {   
                file = Image.FromFile(openFileDialog1.FileName.ToString());
                pictureBox1.Image = file;
                bit = new Bitmap(openFileDialog1.FileName.ToString());
            }

        }
    }
}
