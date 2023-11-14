using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lakeside
{
    public partial class frmAddGuest : Form
    {
        public frmAddGuest()
        {
            InitializeComponent();
            cmbCountry.DataSource = GetCountryList();
            cmbCountry.Text = "United Kingdom";
        }

        public static List<string> GetCountryList()
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }
            cultureList.Sort();
            return cultureList;
        }
    }
}
