using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Modern_UI
{
    public partial class Form1 : Form
    {
        //form drag move 
        private bool mouseDown;
        private Point lastLocation;

        //form radius
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            //form radius
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //drag move
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //drag move
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //drag move
            mouseDown = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pctrclose.Image = Properties.Resources.closeiconhover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pctrclose.Image = Properties.Resources.closeicon;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pctrminimize.Image = Properties.Resources.minimizeiconhover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pctrminimize.Image = Properties.Resources.minimizeicon;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
