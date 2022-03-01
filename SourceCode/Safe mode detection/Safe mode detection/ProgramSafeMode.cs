using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Safe_mode_detection
{
    static class ProgramSafeMode
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSafeMode());
        }
    }
}
