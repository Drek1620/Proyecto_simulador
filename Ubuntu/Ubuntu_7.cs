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
    public partial class Ubuntu_7 : Form
    {
        private static string usuario;
        public Ubuntu_7()
        {
            InitializeComponent();
        }

        public static string Usuario { get => usuario; set => usuario = value; }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Texts == txtConfirma.Texts)
            {
                Usuario = txtUsuario.Texts;
                Ubuntu_8 img = new Ubuntu_8() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                img.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img);
                img.Show();
            }
            else
            {
                label1.Text = "*Las contraseñas no coinciden. Intentalo de nuevo.";
                txtConfirma.Texts = "";
                txtContraseña.Texts = "";
            }
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Ubuntu_6 img = new Ubuntu_6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }

        private void txtConfirma__TextChanged(object sender, EventArgs e)
        {
            if (txtConfirma.Texts != "" && txtContraseña.Texts != "" && txtUsuario.Texts !="")
            {
                btnInstalar.Enabled = true;
            }
        }

        private void txtContraseña__TextChanged(object sender, EventArgs e)
        {
            if (txtConfirma.Texts != "" && txtContraseña.Texts != "" && txtUsuario.Texts != "")
            {
                btnInstalar.Enabled = true;
            }
        }
    }
}
