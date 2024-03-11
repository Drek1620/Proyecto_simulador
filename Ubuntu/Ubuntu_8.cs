using Proyecto_simulador.Windows_11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_8 : Form
    {
        public Ubuntu_8()
        {
            InitializeComponent();
        }

        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 100)
            {
                c = 0;
                timer1.Stop();
                Ubuntu_9 img = new Ubuntu_9() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                img.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img);
                img.Show();
                prb_Reinicio.Value = 0;
            }
            else
            {
                c++;
                //label1.Text = (8 - c).ToString();
                prb_Reinicio.Value += 1;
            }

            if (c == 25)
            {
                label1.Text = "Copiando archivos...";
            }
            else
            {
                if (c==50)
                {
                    label1.Text = "Configurando el hardware...";
                }
                else
                {
                    if (c==75)
                    {
                        label1.Text = "A punto de terminar la copia de archivos...";
                    }
                }
            }
        }
    }
}
