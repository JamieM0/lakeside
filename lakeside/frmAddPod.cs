using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lakeside;
using lakeside.DAL;
using lakeside.Models;

namespace lakeside
{
    public partial class frmAddPod : Form
    {
        public frmAddPod()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddPod().Show();
        }

        private void btnAddPod_Click(object sender, EventArgs e)
        {
            Pod p = new Pod()
        }
    }
}
