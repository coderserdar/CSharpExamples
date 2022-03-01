using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// make sure that using System.Drawing.Drawing2D; is included
using System.Drawing.Drawing2D;

// make sure that using System.Diagnostics; is included
using System.Diagnostics; 

namespace Template
{
    public partial class FormPanelGradient : Form
    {
        public FormPanelGradient()
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
            Brush brush = new LinearGradientBrush(panel1.ClientRectangle, Color.Black, Color.White, LinearGradientMode.ForwardDiagonal);
            panel1.CreateGraphics().FillRectangle(brush, panel1.ClientRectangle);
        }
    }
}

