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

// make sure that using System.Drawing.Printing; is included
using System.Drawing.Printing;

namespace Template
{
    public partial class FormPrint : Form
    {
        private Font Verdana11FontSize;
        private StreamReader Reader;

        public FormPrint()
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
            string filename = textBox1.Text.ToString();
            Reader = new StreamReader(filename);
            Verdana11FontSize = new Font("Verdana", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            pd.Print();
            if (Reader != null)
                Reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text.ToString();
            Reader = new StreamReader(filename);
            Verdana11FontSize = new Font("Verdana", 10);
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            pd.Print();
            if (Reader != null)
                Reader.Close();
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs PrinterArgs)
        {
            Graphics g = PrinterArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = PrinterArgs.MarginBounds.Left;
            float topMargin = PrinterArgs.MarginBounds.Top;
            string line = null;

            linesPerPage = PrinterArgs.MarginBounds.Height /
            Verdana11FontSize.GetHeight(g);
            while (count < linesPerPage && ((line = Reader.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                Verdana11FontSize.GetHeight(g));
                g.DrawString(line, Verdana11FontSize, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                count++;
            }

            if (line != null)
            {
                PrinterArgs.HasMorePages = true;
            }
            else
            {
                PrinterArgs.HasMorePages = false;
            }
        }

    }
}
