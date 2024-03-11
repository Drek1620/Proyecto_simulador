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
    public partial class Pantalla3 : Form
    {
        public Pantalla3()
        {
            InitializeComponent();
            timer1.Start();
            
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (c==4)
            {
                c=0;
                timer1.Stop();
                Pantalla4 img4 = new Pantalla4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img4.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img4);
                img4.Show();
            }
            else
            {
                c++;
            }

            
        }
    }
}
