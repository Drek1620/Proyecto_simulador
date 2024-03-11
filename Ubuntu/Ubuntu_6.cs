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
    public partial class Ubuntu_6 : Form
    {
        public Ubuntu_6()
        {
            InitializeComponent();
        }
        Ubuntu_7 img2 = new Ubuntu_7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private void btnInstalar_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            img2.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img2);
            img2.Show();
        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            Ubuntu_5 img = new Ubuntu_5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }
    }
}
