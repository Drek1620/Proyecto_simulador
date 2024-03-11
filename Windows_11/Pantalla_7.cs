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
    public partial class Pantalla_7 : Form
    {
		public Pantalla_7()
		{
			InitializeComponent();
			prb_Actualizar1.Visible = false;
			numericUpDown1_1.Visible = false;
			btn_Aceptar1.Visible = false;
			lbl_Gb1.Visible = false;
			btn_Cancelar1.Visible = false;
			lbl_Tamaño1.Visible = false;

		}

		private void pnlNuevo1_Click(object sender, EventArgs e)
		{
			numericUpDown1_1.Visible = true;
			btn_Aceptar1.Visible = true;
			lbl_Gb1.Visible = true;
			btn_Cancelar1.Visible = true;
			lbl_Tamaño1.Visible = true;
		}

		private void btnSiguiente1_Click(object sender, EventArgs e)
        {
           
        }

		private void timer1_1_Tick(object sender, EventArgs e)
		{
			if (prb_Actualizar1.Value < 100)
				prb_Actualizar1.Value += 2;
			if (prb_Actualizar1.Value == 100)
			{
				timer1_1.Enabled = false;
				prb_Actualizar1.Visible = false;
				prb_Actualizar1.Value = 0;
				MessageBox.Show(this, "No se han encontrado nuevos dispocitivos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	

		private void pnl_Formatear1_Click(object sender, EventArgs e)
		{
			DialogResult R = MessageBox.Show(this, "Se borrara todo el contenido del disco duro", "¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (R == DialogResult.Yes)
			{
				prb_Actualizar1.Visible = true;
				tmr_Formatear1.Enabled = true;
				prb_Actualizar1.Value = 0;
			}
		}

		private void tmr_Formatear1_Tick(object sender, EventArgs e)
		{
			if (prb_Actualizar1.Value < 100)
			{
				prb_Actualizar1.Value += 2;
			}
			if (prb_Actualizar1.Value == 100)
			{
				tmr_Formatear1.Enabled = false;
				prb_Actualizar1.Visible = false;
				prb_Actualizar1.Value = 0;
				MessageBox.Show(this, "Se ha formateado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void pnl_Eliminar1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this, "No se puede eliminar esta unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btn_Aceptar1_Click(object sender, EventArgs e)
		{
			if (numericUpDown1_1.Value > 0)
			{
				Pantalla_7_1 img7_1 = new Pantalla_7_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
				this.Controls.Clear();
				this.BackgroundImage = null;
				img7_1.FormBorderStyle = FormBorderStyle.None;
				this.Controls.Add(img7_1);
				img7_1.Show();
			}
			else
			{
				MessageBox.Show("Ingresa un valor adecuado");
			}
		}

		private void btn_Cancelar1_Click(object sender, EventArgs e)
		{
			numericUpDown1_1.Visible = false;
			btn_Aceptar1.Visible = false;
			lbl_Gb1.Visible = false;
			btn_Cancelar1.Visible = false;
			lbl_Tamaño1.Visible = false;
			numericUpDown1_1.Value = 0;
		}

		private void pnl_Actualizar1_Click(object sender, EventArgs e)
		{
			prb_Actualizar1.Visible = true;
			timer1_1.Enabled = true;
			prb_Actualizar1.Value = 0;
		}

		private void btnSiguiente1_Click_1(object sender, EventArgs e)
		{
			Pantalla_8 img8 = new Pantalla_8() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.Controls.Clear();
			this.BackgroundImage = null;
			img8.FormBorderStyle = FormBorderStyle.None;
			this.Controls.Add(img8);
			img8.Show();
		}
	}
}
