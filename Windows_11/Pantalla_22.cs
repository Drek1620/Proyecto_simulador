using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Windows_11
{
    public partial class Pantalla_22 : Form
    {
        public Pantalla_22()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            this.BackgroundImage = Properties.Resources.Imagen_22_2_w11;
            pictureBox1.Visible = true;
            btnAceptar.Visible = false;
            timer1.Start();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c==3)
            {
                timer1.Stop();
                Pantalla_23 img23 = new Pantalla_23() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img23.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img23);
                img23.Show();
            }
            else
                c++;
        }
    }
}
