using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_simulador
{
    public partial class Pantalla4 : Form
    {
        public Pantalla4()
        {
            InitializeComponent();
            this.Cursor = Cursors.Default;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Pantalla5 img5 = new Pantalla5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img5.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img5);
            img5.Show();
        }


        private void Pantalla4_Load(object sender, EventArgs e)
        {
            lbl_Win_Home.Text =DateTime.Now.ToShortDateString();
            lbl_Win_HomSiLe.Text =DateTime.Now.ToShortDateString();
            lbl_Win_Ed.Text =DateTime.Now.ToShortDateString();
            lbl_Win_10.Text =DateTime.Now.ToShortDateString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                lblDesc.Text = "Descripcion \n Windows 10 Home";
            }

            if (listBox1.SelectedIndex == 1)
            {
                lblDesc.Text = "Descripcion \n Windows 10 Home Single Language";
            }

            if (listBox1.SelectedIndex == 2)
            {
                lblDesc.Text = "Descripcion \n Windows 10 Education";
            }

            if (listBox1.SelectedIndex == 3)
            {
                lblDesc.Text = "Descripcion \n Windows 10 Pro";
            }

        }
    }
}
