using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Des_Ubuntu : Form
    {
        public Des_Ubuntu()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ubuntu_1 ubuntu_1 = new Ubuntu_1();

            this.Hide();

            ubuntu_1.ShowDialog();
        }
    }
}
