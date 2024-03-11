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

namespace Proyecto_simulador
{
    public partial class Pantalla_Carga : Form
    {
        public Pantalla_Carga()
        {
            InitializeComponent();
            cerrar.Cerrado = false;
            hilo1 = new Thread(new ThreadStart(SeCierra));
            hilo1.Start();
        }
        Cerrar cerrar = new Cerrar();
        int c = 0;
        Thread hilo1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c==4)
            {
                
               
                Pantalla1 img1 = new Pantalla1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel1.Controls.Clear();
                img1.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(img1);
                img1.Show();
                timer1.Stop(); 
            }
            else
                c++;
        }

        public void SeCierra()
        {

            while (cerrar.Cerrado == false)
            {
                cerrar = new Cerrar();
            }
            DialogResult = DialogResult.OK;
        }

        private void Pantalla_Carga_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            hilo1.Abort();
        }
    }
}
