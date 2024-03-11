using Proyecto_simulador.Windows_11;
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
    public partial class Pantalla15 : Form
    {
        public Pantalla15()
        {
            InitializeComponent();
        }

        Pantalla_14 Objp = new Pantalla_14();

        private void panSiguiente_Click(object sender, EventArgs e)
        {
            
                Pantalla16 img16 = new Pantalla16() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img16.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img16);
                img16.Show();
            
        }

        private void Pantalla15_Load(object sender, EventArgs e)
        {
           label1.Text ="Enviar el codigo por correo a "+Pantalla14.Correo.ToString();
           label2.Text = "Escribe la contraseña de " + Pantalla14.Correo.ToString();

        }

        private void pnl_Atras_Click(object sender, EventArgs e)
        {
            Pantalla14 img14 = new Pantalla14() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img14.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img14);
            img14.Show();
        }

        private void txt_contraseña__TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.BackColor = Color.White;
        }
    }
}
