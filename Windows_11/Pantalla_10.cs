using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_simulador.Windows_11
{
    public partial class Pantalla_10 : Form
    {
        public Pantalla_10()
        {
            InitializeComponent();
        }
        int c = 0;
        int p = 0;

        int b = 241;
        int g = 241;
        int r = 241;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p == 1)
            {
                this.BackColor = Color.FromArgb(241-r, 241 - g, 241 - b);
                if (g >= 1)
                {
                    g--;
                }
                if (r >= 1)
                {
                    r--;
                }
                if (b >= 1)
                {
                    b--;
                }
                if (g == 0 && r == 0 && b == 0)
                {
                    Thread.Sleep(2000);
                    timer1.Stop();
                    c = 0;
                    p= 0;
                    Pantalla_11 img11 = new Pantalla_11() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    this.Controls.Clear();
                    this.BackgroundImage = null;
                    img11.FormBorderStyle = FormBorderStyle.None;
                    this.Controls.Add(img11);
                    img11.Show();
                }
            }
            if (c == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                this.BackgroundImage = Properties.Resources.Imagen_10_2_w11;
            }
            else
            {
                if (c==7)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    p = 1;
                    timer1.Interval = 10;
                    this.BackgroundImage = null;
                }
            }
            

            c++;
            
        }
    }
}
