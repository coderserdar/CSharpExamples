using System;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Template
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
        }

        int StartPos = 0;
        string TextToShow = "Catch me if you can :)";
        int Position = 20;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(TextToShow, new Font("Arial", Position), new SolidBrush(Color.Black), StartPos, 35);
            StartPos += 10;
            if (StartPos >= this.Width) StartPos = TextToShow.Length * Position * -1;
        }

    }
}
