using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // make sure that using System.Runtime.InteropServices; is included
using System.Diagnostics;   // make sure that using System.Diagnostics; is included

namespace GetDiskFreeSpace_example
{
    public partial class FormGetFreeSpace : Form
    {
        public FormGetFreeSpace()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong avail = 0, total = 0, totalfree = 0;
            // read size
            GetDiskSizeTotal(comboBox1.SelectedItem.ToString(), out  avail, out total, out  totalfree);
            // write size in label
            label1.Text = "Avaliable disk space (for this user): " + ConvertBytesToMegabytes(avail).ToString() + " MB";
            label2.Text = "Total disk space: " + ConvertBytesToMegabytes(GetDiskSizeTotal(comboBox1.SelectedItem.ToString(), out avail, out total, out totalfree)) + " MB";
            label3.Text = "Free disk space: " + ConvertBytesToMegabytes(avail).ToString() + " MB";
        }
        
        ulong ConvertBytesToMegabytes(ulong bytes)
        {
            return (bytes / 1024) / 1024;        
        }

        public ulong GetDiskSizeTotal(string volumeName, out ulong avail, out ulong total, out ulong totalfree)
        {
            MyClass.GetDiskFreeSpaceEx(volumeName, out avail, out total, out totalfree);
            return total;
        }

        public ulong GetDiskSize(string volumeName)
        {
            ulong avail = 0;
            ulong total = 0;
            ulong totalfree = 0;
            MyClass.GetDiskFreeSpaceEx(volumeName, out avail, out total, out totalfree);
            return total;
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }
    }
    public class MyClass
    {
        // import from kernel32.dll function GetDiskFreeSpaceEx (total amount)
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
          out ulong lpFreeBytesAvailable,
          out ulong lpTotalNumberOfBytes,
          out ulong lpTotalNumberOfFreeBytes);

        // import from kernel32.dll function GetDiskFreeSpaceEx
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetDiskFreeSpace(ulong GetDiskFreeSpace, out ulong lpSectorsPerCluster, out ulong lpBytesPerSector, out ulong lpNumberOfFreeClusters, out ulong lpTotalNumberOfClusters);
    }
}
