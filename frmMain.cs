﻿using System.Windows.Forms;
using System.Drawing;

namespace class_hierarchy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = bmp;
        }
    }
}
