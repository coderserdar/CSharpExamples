using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutex_example
{
    public partial class FormMutex : Form
    {
        public FormMutex()
        {
            InitializeComponent();
            if (!IsSingleInstance())
            {
                label1.Text = "There are more instance!";
            }
            else
            {
                label1.Text = "Only one instance!" ;
            }
            // Put label in center
            label1.Location = new Point(this.Size.Width / 2 - this.label1.Width / 2, this.Size.Height / 2 - this.label1.Height);
        }
        // Declare Mutex object
        public Mutex mutex;
        public bool IsSingleInstance()
        {
            try
            {
                // Open existing mutex
                Mutex.OpenExisting("Mutex");
            }
            catch
            {
                // Run new instance if app don't exist    
                mutex = new Mutex(true, "Mutex");

                // App start normally 
                return true;
            }
            // Return false is app is already opened
            return false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Keep label on center
            label1.Location = new Point(this.Size.Width / 2 - this.label1.Width / 2, this.Size.Height / 2 - this.label1.Height);
        } 
    }
}
