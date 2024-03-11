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
    public partial class Pantalla_16 : Form
    {
        public Pantalla_16()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 3)
            {
                timer1.Stop();
                Pantalla_17 img17 = new Pantalla_17() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img17.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img17);
                img17.Show();
            }
            else
                c++;
        }
    }
}
