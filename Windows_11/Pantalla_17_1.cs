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
    public partial class Pantalla_17_1 : Form
    {
        private static string correo;
        public Pantalla_17_1()
        {
            InitializeComponent();
        }

        public static string Correo { get => correo; set => correo = value; }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            Correo = rjtxtCorreo.Texts;
            Pantalla_18 img18 = new Pantalla_18() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img18.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img18);
            img18.Show();
        }

        private void Pantalla_17_1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
