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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Pantalla_Carga imagen1;

        private void rButton1_Click_1(object sender, EventArgs e)
        {
            imagen1 = new Pantalla_Carga();

            this.Hide();

            imagen1.ShowDialog();
        }
    }
}
