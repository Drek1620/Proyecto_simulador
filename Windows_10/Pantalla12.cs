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
    public partial class Pantalla12 : Form
    {
        public Pantalla12()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 3)
            {
                this.BackgroundImage = Proyecto_simulador.Properties.Resources.Imagen_12_1;
                c++;
            }
            else
            {
                if (c == 6)
                {
                    this.BackgroundImage = Proyecto_simulador.Properties.Resources.Imagen_12_2;
                    c++;
                }
                else
                {
                    if (c == 9)
                    {
                        this.BackgroundImage = Proyecto_simulador.Properties.Resources.Imagen_12_3;
                        c++;
                    }
                    else
                    {
                        if (c==12)
                        {
                            c = 0;
                            timer1.Stop();
                            Pantalla13 img13 = new Pantalla13() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                            this.Controls.Clear();
                            this.BackgroundImage = null;
                            img13.FormBorderStyle = FormBorderStyle.None;
                            this.Controls.Add(img13);
                            img13.Show();
                        }else
                            c++;
                    }
                        
                }
            }
        }
    }
}
