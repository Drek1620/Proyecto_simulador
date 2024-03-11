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
    public partial class Pantalla6 : Form
    {
        public Pantalla6()
        {
            InitializeComponent();
        }
        //aqui nomas es un panel transparente que funciona como botton 
        private void pnlSigiuiente_Click(object sender, EventArgs e) 
        {
           
            Pantalla7 img7 = new Pantalla7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img7.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img7);
            img7.Show();
        }

        private void pbl_Regresar_Click(object sender, EventArgs e)
        {
            Pantalla5 img5 = new Pantalla5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img5.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img5);
            img5.Show();
        }
    }
}
