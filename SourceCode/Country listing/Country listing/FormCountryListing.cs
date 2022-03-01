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
using System.Globalization;

namespace Country_listing
{
    public partial class FormCountryListing : Form
    {
        List<string> cultureList = new List<string>();
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        RegionInfo region;

        public FormCountryListing()
        {
            InitializeComponent();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            Process.Start("www.vclexamples.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (CultureInfo culture in cultures)
            {
                region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                    comboBox1.Items.Add(region.EnglishName + " (" + region.ISOCurrencySymbol + ")");
                   //  cultureList.Add(region.ISOCurrencySymbol);
                    // comboBox1.Items.Add(region.ISOCurrencySymbol);
                }
            }
        }
    }
}
