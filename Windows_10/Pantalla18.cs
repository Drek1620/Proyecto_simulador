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
    public partial class Pantalla18 : Form
    {
        public Pantalla18()
        {
            InitializeComponent();
        }

        private void panAceptar_Click(object sender, EventArgs e)
        {
            Pantalla19 img19 = new Pantalla19() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img19.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img19);
            img19.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
