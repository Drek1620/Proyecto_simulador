using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_9 : Form
    {
        public Ubuntu_9()
        {
            InitializeComponent();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            Ubuntu_Carga img = new Ubuntu_Carga() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }
    }
}
