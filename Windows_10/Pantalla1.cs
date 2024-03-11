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
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Este es el codigo para mandar a llamar la otra imagen de pantalla2
            Pantalla2 img2 = new Pantalla2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img2.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img2);
            img2.Show();
            DialogResult = DialogResult.OK;
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {
            cbo_Formato_Fec_Hor.SelectedIndex= 0;
            cbo_idioma_Ins.SelectedIndex = 0;
            cbo_Teclado.SelectedIndex= 0;   
        }
    }
}
