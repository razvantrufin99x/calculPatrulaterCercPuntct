using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculPatrulater
{
    public partial class dotControl : UserControl
    {
        public dotControl()
        {
            InitializeComponent();
        }

        public bool ismd = false;
        private void dotControl_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void dotControl_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void dotControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void dotControl_Load(object sender, EventArgs e)
        {

        }
    }
}
