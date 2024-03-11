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
    public partial class Pantalla17 : Form
    {
        public Pantalla17()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool verificacion = false;
            if (txtPin.Texts == txtPin2.Texts)
            {
                verificacion = true;
            }

            if (txtPin.Texts != "" && txtPin2.Texts != "" && verificacion == true)
            {
                Pantalla18 img18 = new Pantalla18() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img18.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img18);
                img18.Show();
            }
            else
            if (verificacion == false)
            {
                label1.Text = "*Los pines no son iguales";

            }
            else
            if (txtPin.Texts == "" && txtPin2.Texts == "")
            {
                label1.Text="*Ingrese un PIN";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Pantalla18 img18 = new Pantalla18() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img18.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img18);
            img18.Show();
        }
    }
}
