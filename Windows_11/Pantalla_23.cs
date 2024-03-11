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
    public partial class Pantalla_23 : Form
    {
        public Pantalla_23()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 3)
            {
                label1.Visible = false;
                label2.Visible = true;
            }
            else
            {
                if (c == 6)
                {

                    label2.Text = "Esto podría tardar algunos minutos.";
                    this.BackgroundImage = Properties.Resources.Fondo_luz;
                }
                else
                {
                    if(c == 10)
                    {
                        timer1.Stop();
                        c= 0;
                        Pantalla_24 img24 = new Pantalla_24() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        this.Controls.Clear();
                        this.BackgroundImage = null;
                        img24.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(img24);
                        img24.Show();
                    }
                }
            }
            c++;
        }
    }
}
