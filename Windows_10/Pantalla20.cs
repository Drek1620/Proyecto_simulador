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
    public partial class Pantalla20 : Form
    {
        public Pantalla20()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pantalla21 img21 = new Pantalla21() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img21.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img21);
            img21.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Pantalla21 img21 = new Pantalla21() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img21.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img21);
            img21.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
