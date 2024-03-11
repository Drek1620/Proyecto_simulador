using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Windows_11
{
    public partial class Pantalla_18 : Form
    {
        public Pantalla_18()
        {
            InitializeComponent();
        }
        Pantalla_17_1 Objp = new Pantalla_17_1();


        private void btnSesion_Click(object sender, EventArgs e)
        {
            Pantalla_19 img19 = new Pantalla_19() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img19.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img19);
            img19.Show();
           
        }

        private void Pantalla_18_Load(object sender, EventArgs e)
        {
            rjtxtContraseña.Focus();
            lblEnviar.Text = "Enviar el codigo por correo a " + Pantalla_17_1.Correo.ToString();
            lblCorreo.Text = Pantalla_17_1.Correo.ToString();
            btnSesion.Enabled = false;
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void rjtxtContraseña__TextChanged(object sender, EventArgs e)
        {
            if (rjtxtContraseña.Texts != "")
            {
                btnSesion.Enabled = true;
            }
            else
            {
                btnSesion.Enabled = false;
            }
        }
    }
}
