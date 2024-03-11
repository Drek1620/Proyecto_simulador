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
    public partial class Pantalla_19 : Form
    {
        public Pantalla_19()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Imagen_19_2_w11;
            btnSiguiente.Visible = false;
            btnAceptar.Visible = true;
            lblNoidenticas.Visible = true;
            rjtxtContr1.Visible = true;
            rjtxtcontr2.Visible = true;
            checkBox1.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rjtxtContr1.Texts == rjtxtcontr2.Texts)
            {
                Pantalla_20 img20 = new Pantalla_20() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img20.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img20);
                img20.Show();
            }
            else
            {
                lblNoidenticas.Text = "Las contraseñas no coinciden. Intentalo de nuevo.";
                rjtxtContr1.Texts = " ";
                rjtxtcontr2.Texts = " ";
            }
        }

        private void Pantalla_19_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                rjtxtContr1.PasswordChar = false;
                rjtxtcontr2.PasswordChar = false;
            }
            else
            {
                rjtxtContr1.PasswordChar = true;
                rjtxtcontr2.PasswordChar = true;
            }
            
        }

        private void rjtxtcontr2__TextChanged(object sender, EventArgs e)
        {
            if (rjtxtcontr2.Texts != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                if (rjtxtcontr2.Texts == "")
                {
                    btnAceptar.Enabled = false;
                }
            }
                   
        }
    }
}
