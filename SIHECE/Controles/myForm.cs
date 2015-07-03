using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIHECE
{
    public partial class myForm : Form
    {
        private Point pos = Point.Empty;
        private bool move = false;

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        public bool BotonMinimizar
        {
            get { return btnMinimizar.Visible; }
            set { btnMinimizar.Visible = value; }
        }
        public bool BotonMaximizar
        {
            get { return btnMaximizar.Visible; }
            set { btnMaximizar.Visible = value; }
        }
        public Image Icono
        {
            get { return ptbIcono.Image; }
            set { ptbIcono.Image = value; }
        }

        public myForm()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; ;
            }
        }

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.BotonMaximizar == true)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized; ;
                }
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void lblTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.Location = new Point((this.Left + e.X - pos.X), (this.Top + e.Y - pos.Y));
            }
        }
    }
}
