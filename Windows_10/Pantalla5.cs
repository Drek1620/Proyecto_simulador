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
    public partial class Pantalla5 : Form
    {
        public Pantalla5()
        {
            InitializeComponent();
              
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (chk_terminos.Checked == true)
            {
                Pantalla6 img6 = new Pantalla6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img6.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img6);
                img6.Show();
            }
            else
            {
                if (chk_terminos.Checked == false)
                {
                    MessageBox.Show(this, "Por Favor acepte los terminos y condiciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
           
        }

        private void pbl_Regresar_Click(object sender, EventArgs e)
        {
            Pantalla4 img4 = new Pantalla4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img4.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img4);
            img4.Show();
        }

        private void chk_terminos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_terminos.Checked == true)
            {
                btnSiguiente.Enabled = true;
            }
            else
                btnSiguiente.Enabled = false;
        }
    }
}
