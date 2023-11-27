using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lakeside
{
    public partial class frmPodBooking : Form
    {
        DateTime current = DateTime.Now.Date;
        DayOfWeek firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).DayOfWeek;

        Panel pnlCalBase;
        Panel[] dayPanels;

        public frmPodBooking()
        {
            InitializeComponent();
            InitialiseCalendar();
        }

        private void InitialiseCalendar()
        {
            
            for(int i=0; i<DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month); i++)
            {
                AddDateDisplay(i);
            }
        }

        private void AddDateDisplay(int dayID)
        {
            firstDayOfMonth
        }
    }
}
