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
    public partial class Pantalla_5 : Form
    {
        public Pantalla_5()
        {
            InitializeComponent(); 

		}

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
			if (chkTerminos.Checked == true)
			{
				Pantalla_6 img6 = new Pantalla_6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
				this.Controls.Clear();
				this.BackgroundImage = null;
				img6.FormBorderStyle = FormBorderStyle.None;
				this.Controls.Add(img6);
				img6.Show();
			}
			else
			{
				if (chkTerminos.Checked == false)
				{
					MessageBox.Show(this, "Por Favor acepte los terminos y condiciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
        }

        private void chkTerminos_CheckedChanged(object sender, EventArgs e)
        {
			if (chkTerminos.Checked==true)
			{
                btnSiguiente.Enabled = true;
            }
			else
                btnSiguiente.Enabled = false;
        }
    }
}
