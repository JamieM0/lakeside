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
    public partial class MainMenu : Form
    {
        bool draggingWindow=false;
        Point dragCursorPoint;
        Point dragFormPoint;

        public MainMenu()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            draggingWindow = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingWindow)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            draggingWindow = false;
        }
    }
}
