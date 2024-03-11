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

namespace Proyecto_simulador
{
    public partial class Pantalla21 : Form
    {
        public Pantalla21()
        {
            InitializeComponent();
        }
        int g = 69;
        int r = 122;
        int t = 0;
        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p==0)
            {
                Thread.Sleep(2000);
                label1.Visible = false;
                label2.Visible = true;
                p++;
            }else
            {
                timer1.Interval = 100;
                if (t % 2 == 0)
                {
                    this.BackColor = Color.FromArgb(0, 77 - g, 136 - r);
                    if (g >= 1)
                    {
                        g--;
                    }
                    if (r >= 1)
                    {
                        r--;
                    }
                    if (g == 0 && r == 0)
                    {
                        t++;
                    }
                }
                else
                {
                    this.BackColor = Color.FromArgb(0, 77 - g, 136 - r);
                    if (g <= 68)
                    {
                        g++;
                    }
                    if (r <= 121)
                    {
                        r++;
                    }
                    if (g == 69 && r == 122)
                    {
                        t++;

                    }
                }
            }
            p++;
            if (p==300) 
            {
                timer1.Stop();
                PantallaWindows_10 imgW = new PantallaWindows_10() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                imgW.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(imgW);
                imgW.Show();

            }
            
        }
    }
}
