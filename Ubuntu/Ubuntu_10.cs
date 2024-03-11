using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_10 : Form
    {
        public Ubuntu_10()
        {
            InitializeComponent();
            label1.Text = Ubuntu_7.Usuario;
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            Ubuntu_11 img2 = new Ubuntu_11() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img2.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img2);
            img2.Show();
        }
    }
}
