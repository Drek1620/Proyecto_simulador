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
    public partial class Ubuntu_4 : Form
    {
        public Ubuntu_4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage==null)
            {
                pictureBox1.BackgroundImage = Properties.Resources.no_check;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackgroundImage == null)
            {
                pictureBox2.BackgroundImage = Properties.Resources.check;
            }
            else
            {
                pictureBox2.BackgroundImage = null;
            }
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            Ubuntu_5 img = new Ubuntu_5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Ubuntu_3 img = new Ubuntu_3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }
    }
}
