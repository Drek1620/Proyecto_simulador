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
    public partial class Pantalla9 : Form
    {
        public Pantalla9()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c == 8)
            {
                c = 0;
                timer1.Stop();
                Pantalla10 img10 = new Pantalla10() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img10.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img10);
                img10.Show();
                prb_Reinicio.Value = 0;
                
            }
            else
            {
                c++;
                label1.Text = (8-c).ToString();
                prb_Reinicio.Value += 12;
            }
           
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pantalla10 img10 = new Pantalla10() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img10.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img10);
            img10.Show();
            prb_Reinicio.Value = 0;

        }
    }
}
