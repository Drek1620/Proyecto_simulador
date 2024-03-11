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

namespace Proyecto_simulador.Windows_11
{
    public partial class Pantalla_8 : Form
    {
        public Pantalla_8()
        {
            InitializeComponent();
        }
        int c = 0;
        int p = 0;
        //Esta pantalla esta funcionando con un timer pero si se le puede poner hilos pues mejor
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 0)
            {
                label1.Text = "(" + p + "%)";
            }
            else
            {
                if (c == 1)
                {
                    label2.Visible = true;
                    panel1.Visible = false;
                    label2.Text = "(" + p + "%)";

                }
                else
                {
                    if (c == 2)
                    {
                        timer1.Interval = 50;
                        label3.Visible = true;
                        panel2.Visible = false;
                        label3.Text = "(" + p + "%)";
                    }
                    else
                    {
                        if (c == 3)
                        {
                            label4.Visible = true;
                            panel3.Visible = false;
                            label4.Text = "(" + p + "%)";
                        }
                        else
                        {
                            if (c == 4)
                            {
                                label5.Visible = true;
                                panel4.Visible = false;
                                label5.Text = "(" + p + "%)";
                            }
                            else
                            {
                                panel5.Visible = false;
                                Thread.Sleep(500);
                                c = 0;
                                timer1.Stop();
                                Pantalla_9 img9 = new Pantalla_9() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                                this.Controls.Clear();
                                this.BackgroundImage = null;
                                img9.FormBorderStyle = FormBorderStyle.None;
                                this.Controls.Add(img9);
                                img9.Show();
                            }
                        }
                    }
                }
            }
            if (p == 100)
            {
                p = 0;
                c++;
            }
            p++;
        }
    }
}
