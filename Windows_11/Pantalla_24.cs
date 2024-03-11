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
    public partial class Pantalla_24 : Form
    {
        public Pantalla_24()
        {
            InitializeComponent();
        }

        private void panInicio_Click(object sender, EventArgs e)
        {
            panInicio.Enabled = false;
            panMenu.Visible = true;
            panApagado.Visible = true;
        }

        private void panApagado_Click(object sender, EventArgs e)
        {
            Cerrar cerrar = new Cerrar();
            cerrar.Cerrado = true;
        }

        private void panApagado_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
