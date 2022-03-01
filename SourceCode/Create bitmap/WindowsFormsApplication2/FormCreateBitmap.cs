using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// make sure that using System.Linq.Expressions; is included
using System.Linq.Expressions;
// make sure that using System.Diagnostics; is included
using System.Diagnostics;

namespace CreateBitmap
{
    public partial class FormCreateBitmap : Form
    {
        public FormCreateBitmap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        static string GetNameOf<T>(Expression<Func<T>> property)
        {
            return (property.Body as MemberExpression).Member.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // draw resources on form
            CreateGraphics().DrawImage(Properties.Resources.Koala, new Point(44, 10));
            // make new bit object
            Bitmap bit = new Bitmap(Properties.Resources.Koala);
            // find name of resources
            var name = GetNameOf(() => Properties.Resources.Koala);
            // save image to "C:" directory
            bit.Save("C:\\" + name + ".jpg");
            MessageBox.Show(name + " is saved to C:");
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com"); 
        }
    }
}
