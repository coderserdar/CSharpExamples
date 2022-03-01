using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// make sure you have include using System.Runtime.InteropServices; for dllimport
using System.Runtime.InteropServices;
// make sure you have include using System.Diagnostics; for link to website
using System.Diagnostics;
// make sure you have include using System.Threading; for new thread (notepad)
using System.Threading;

namespace Send_Messages_and_Keys_example
{
    public partial class FormSendMessages : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChild, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, string lParam);
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public FormSendMessages()
        {
            InitializeComponent();
        }

        public Process process;    

        int SendKeystrokesToNotepad(string text)
        {   
            process = Process.Start("notepad.exe"); 
            Thread.Sleep(500);
            IntPtr notepad, edit;
            notepad = FindWindow("notepad", null);
            if (notepad == null)
            {
                return 0;
            }
            edit = FindWindowEx(notepad, new IntPtr(0), "Edit", null);
            if (edit == null)
            {
                return 0;
            }
            // 0x00C2 is macro which is replace for EM_REPLACESEL
            SendMessage(edit, 0x00C2, 0, text);
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // call method
            SendKeystrokesToNotepad(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            process.Kill();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("www.vclexamples.com");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("The process of notepad which you start don't exist!");	
            }
        }
    }
}
