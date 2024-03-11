using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_11 : Form
    {
        public Ubuntu_11()
        {
            InitializeComponent();
        }

        private void pan_Inicio_Click(object sender, EventArgs e)
        {
            pan_Inicio.Visible = false;
            pan_Menu.Visible = true;
            pan_Apagar.Visible = true;
        }

        private void pan_Apagar_Click(object sender, EventArgs e)
        {
            Cerrar cerrar = new Cerrar();
            cerrar.Cerrado = true;
        }
    }
}
