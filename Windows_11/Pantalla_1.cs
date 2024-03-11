using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_simulador.Windows_11
{
    public partial class Pantalla_1 : Form
    {
        Cerrar cerrar = new Cerrar();
        public Pantalla_1()
        {
            InitializeComponent();
            cerrar.Cerrado = false;
            hilo1 = new Thread(new ThreadStart(SeCierra));
            hilo1.Start();
        }
        Thread hilo1;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            Pantalla_2 img2 = new Pantalla_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img2.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img2);
            img2.Show();
        }

        public void SeCierra()
        {

            while (cerrar.Cerrado == false)
            {
                cerrar = new Cerrar();
            }
            DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

        private void Pantalla_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            hilo1.Abort();
        }

        private void Pantalla_1_Load(object sender, EventArgs e)
        {
            cboIdioma.SelectedIndex = 54;
            cboTeclado.SelectedIndex = 0;
            cboForm.SelectedIndex = 55;
        }
    }
}
