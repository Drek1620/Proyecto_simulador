using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador
{
    public partial class PantallaWindows_10 : Form
    {
        public PantallaWindows_10()
        {
            InitializeComponent();
        }

        private void panInicio_Click(object sender, EventArgs e)
        {
            panInicio.Visible = false;
            panMenu.Visible = true;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panMenu.BackgroundImage = Properties.Resources.Imagen_windows_2;
        }

        private void panApagar_Click(object sender, EventArgs e)
        {

            Cerrar cerrar = new Cerrar();
            cerrar.Cerrado = true;
        }

        private void panApagar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
