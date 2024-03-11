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
    public partial class Pantalla_17 : Form
    {
        public Pantalla_17()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Pantalla_17_1 img17_1 = new Pantalla_17_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img17_1.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img17_1);
            img17_1.Show();
        }
    }
}
