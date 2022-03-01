using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // IO it is needed for working with File object
using System.Diagnostics;   // make sure that using System.Diagnostics; is included


namespace Drag_and_drop
{
    public partial class FormDragAndDrop : Form
    {
        public FormDragAndDrop()
        {
            InitializeComponent();

            // put AllowDrop to true
            this.AllowDrop = true;
            // declare and initialize new DragEventHandler
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            #region disable maximizing
// Define the border style of the form to a dialog box.
            FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;
#endregion
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // define DragEvents Effect to copy
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // when the File is Dropped fill the array (files) with DragEventsArgs data's
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                // replace basic file location of one slash to double slash
                textBox1.Text = File.ReadAllText(file.ToString().Replace("\\", "\\\\"));
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
}
