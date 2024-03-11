using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_1 : Form
    {
        public Ubuntu_1()
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
            if (c == 4)
            {

               
                Ubuntu_2 img2 = new Ubuntu_2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel1.Controls.Clear();
                img2.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(img2);
                img2.Show();
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

        private void Ubuntu_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            hilo1.Abort();
        }
    }
}
