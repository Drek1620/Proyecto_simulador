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
    public partial class Pantalla19 : Form
    {
        public Pantalla19()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            label1.Visible= false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Pantalla20 img20 = new Pantalla20() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img20.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img20);
            img20.Show();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Pantalla20 img20 = new Pantalla20() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img20.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img20);
            img20.Show();
        }

        bool band = false;
        bool band2 = false;
        bool band3 = false;
        bool band4 = false;
        bool band5 = false;
        bool band6 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            

            if( band == false)
            {
                label1.Visible = true;
                band = true;
            }
            else
            if (band == true)
            {
                label1.Visible = false;
                band = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (band2 == false)
            {
                label2.Visible = true;
                band2 = true;
            }
            else
            if (band2 == true)
            {
                label2.Visible = false;
                band2 = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (band3 == false)
            {
                label3.Visible = true;
                band3 = true;
            }
            else
            if (band3 == true)
            {
                label3.Visible = false;
                band3 = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (band4 == false)
            {
                label4.Visible = true;
                band4 = true;
            }
            else
            if (band4 == true)
            {
                label4.Visible = false;
                band4 = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (band5 == false)
            {
                label5.Visible = true;
                band5 = true;
            }
            else
            if (band5 == true)
            {
                label5.Visible = false;
                band5 = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (band6 == false)
            {
                label6.Visible = true;
                band6 = true;
            }
            else
            if (band6 == true)
            {
                label6.Visible = false;
                band6 = false;
            }

        }
    }
}
