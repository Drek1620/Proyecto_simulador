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
    public partial class Pantalla_14 : Form
    {
        public Pantalla_14()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c==2)
            {
                this.BackgroundImage = Properties.Resources.Imagen_14_2_w11;
            }
            else
            {
                if(c==5)
                {
                    this.BackgroundImage = Properties.Resources.Imagen_14_3_w11;
                }
                else
                {
                    if (c==8)
                    {
                        this.BackgroundImage = Properties.Resources.Imagen_14_4_w11;
                    }
                    else
                    {
                        if (c==11)
                        {
                            timer1.Stop();
                            c = 0;
                            Pantalla_15 img15 = new Pantalla_15() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                            this.Controls.Clear();
                            this.BackgroundImage = null;
                            img15.FormBorderStyle = FormBorderStyle.None;
                            this.Controls.Add(img15);
                            img15.Show();
                        }
                    }
                }
            }
            c++;
        }
    }
}
