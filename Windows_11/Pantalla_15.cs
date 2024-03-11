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
    public partial class Pantalla_15 : Form
    {
        string nombre;
        public Pantalla_15()
        {
            InitializeComponent();
        }

        public string Nombre { get => nombre; set => nombre = value; }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Nombre = rjtxtNombre.Texts;
            Pantalla_16 img16 = new Pantalla_16() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img16.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img16);
            img16.Show();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Pantalla_16 img16 = new Pantalla_16() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img16.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img16);
            img16.Show();
        }

        private void Pantalla_15_Load(object sender, EventArgs e)
        {
            rjtxtNombre.Focus();
        }
    }
}
