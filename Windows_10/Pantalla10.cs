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
    public partial class Pantalla10 : Form
    {
        public Pantalla10()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c==3)
            {
                this.BackgroundImage = Proyecto_simulador.Properties.Resources.Imagen_10_1;
                pictureBox1.Visible = true;
                c++;
            }
            else
            {
                if (c==7)
                {
                    pictureBox1.Visible = false;
                    this.BackgroundImage = Proyecto_simulador.Properties.Resources.Imagen_10_2;
                    pictureBox2.Visible = true;
                    c++;
                }
                else
                {
                    if (c==11)
                    {
                        c = 0;
                        timer1.Stop();
                        Pantalla11 img11 = new Pantalla11() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        this.Controls.Clear();
                        this.BackgroundImage = null;
                        img11.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(img11);
                        img11.Show();
                    }
                    else
                        c++;
                }
            }
        }
    }
}
