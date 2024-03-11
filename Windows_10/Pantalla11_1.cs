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
    public partial class Pantalla11_1 : Form
    {
        public Pantalla11_1()
        {
            InitializeComponent();
        }

        private void panOmitir_Click(object sender, EventArgs e)
        {
            Pantalla12 img12 = new Pantalla12() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img12.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img12);
            img12.Show();
        }

    }
}
