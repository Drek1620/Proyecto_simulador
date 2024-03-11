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
    public partial class Pantalla14 : Form
    {
        public Pantalla14()
        {
            InitializeComponent();
        }
        private static string correo;
        public static string Correo { get => correo; set => correo = value; }
        Pantalla15 img15 = new Pantalla15() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Correo = txt_Correo.Texts;   
            
            this.Controls.Clear();
            this.BackgroundImage = null;
            img15.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img15);
            img15.Show();
            

            
        }

        private void Pantalla14_Load(object sender, EventArgs e)
        {
            
        }
    }
}
