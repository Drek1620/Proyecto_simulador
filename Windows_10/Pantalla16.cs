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
    public partial class Pantalla16 : Form
    {
        public Pantalla16()
        {
            InitializeComponent();
        }

        private void panPin_Click(object sender, EventArgs e)
        {
            Pantalla17 img17 = new Pantalla17() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img17.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img17);
            img17.Show();
        }
    }
}
