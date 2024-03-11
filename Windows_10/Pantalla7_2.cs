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
    public partial class Pantalla7_2 : Form
    {
        public Pantalla7_2()
        {
            InitializeComponent();
            prb_Actualizar.Visible= false; 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Pantalla8 img8 = new Pantalla8() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img8.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img8);
            img8.Show();
        }

        private void pnl_Eliminar_Click(object sender, EventArgs e)
        {
            Pantalla7 img7 = new Pantalla7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img7.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img7);
            img7.Show();
        }

        private void pnl_Actualizar_Click(object sender, EventArgs e)
        {
            prb_Actualizar.Visible = true;
            timer1.Enabled = true;
            prb_Actualizar.Value = 0;
        }

        private void pnl_Formatear_Click(object sender, EventArgs e)
        {

            DialogResult R = MessageBox.Show(this, "Se borrara todo el contenido del disco duro", "¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (R == DialogResult.Yes)
            {
                prb_Actualizar.Visible = true;
                tmr_Formatear.Enabled = true;
                prb_Actualizar.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prb_Actualizar.Value < 100)
                prb_Actualizar.Value += 2;
            if (prb_Actualizar.Value == 100)
            {

                timer1.Enabled = false;
                prb_Actualizar.Visible = false;
                prb_Actualizar.Value = 0;//aq
                MessageBox.Show(this, "No se han encontrado nuevos dispocitivos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tmr_Formatear_Tick(object sender, EventArgs e)
        {
            if (prb_Actualizar.Value < 100)
            {
                prb_Actualizar.Value += 2;
            }
            if (prb_Actualizar.Value == 100)
            {
                tmr_Formatear.Enabled = false;
                prb_Actualizar.Visible = false;
                prb_Actualizar.Value = 0;
                MessageBox.Show(this, "Se ha formateado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pbl_Regresar_Click(object sender, EventArgs e)
        {
            Pantalla6 img6 = new Pantalla6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img6.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img6);
            img6.Show();
        }
    }
}
