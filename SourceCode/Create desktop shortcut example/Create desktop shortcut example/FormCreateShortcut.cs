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
// make sure include reference Windows Script Host Object 
// make sure that using IWshRuntimeLibrary; is included
using IWshRuntimeLibrary;
using System.IO;

namespace Create_desktop_shortcut_example
{
    public partial class FormCreateShortcut : Form
    {
        public FormCreateShortcut()
        {
            InitializeComponent();
        }

        private void ShortToDesktop(string linkName)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

        private void lblLink_Click(object sender, EventArgs e)
        {

            Process.Start("www.vclexamples.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShortToDesktop(System.AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
