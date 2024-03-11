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
    public partial class Pantalla7_1 : Form
    {
        public Pantalla7_1()
        {
            InitializeComponent();
        }

        private void panAceptar_Click(object sender, EventArgs e)
        {
            Pantalla7_2 img7_2 = new Pantalla7_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img7_2.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img7_2);
            img7_2.Show();
        }


        private void panCancelar_Click(object sender, EventArgs e)
        {
            Pantalla7 img7 = new Pantalla7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img7.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img7);
            img7.Show();
        }
    }
}
