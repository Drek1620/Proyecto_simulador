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
    public partial class Pantalla_21 : Form
    {
        public Pantalla_21()
        {
            InitializeComponent();
        }
        //aqui los dos botones llevan a la siguiente pantalla
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pantalla_22 img22 = new Pantalla_22() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img22.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img22);
            img22.Show();
        }
    }
}
