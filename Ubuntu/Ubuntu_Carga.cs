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
    public partial class Ubuntu_Carga : Form
    {
        public Ubuntu_Carga()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 4)
            {


                Ubuntu_10 img2 = new Ubuntu_10() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                img2.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img2);
                img2.Show();
                timer1.Stop();
            }
            else
                c++;
        }
    }
}
