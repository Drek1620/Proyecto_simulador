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
    public partial class Descripcion : Form
    {
        public Descripcion()
        {
            InitializeComponent();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Pantalla_1 pantalla_1 = new Pantalla_1();
            this.Hide();
            pantalla_1.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
