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
	public partial class Pantalla_7_2 : Form
	{
		public Pantalla_7_2()
		{
			InitializeComponent();
			prb_Actualizar2.Visible = false;
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			
		}

		private void pnl_Eliminar2_Click(object sender, EventArgs e)
		{
			Pantalla_7 img7 = new Pantalla_7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.Controls.Clear();
			this.BackgroundImage = null;
			img7.FormBorderStyle = FormBorderStyle.None;
			this.Controls.Add(img7);
			img7.Show();
		}

		private void pnl_Actualizar2_Click(object sender, EventArgs e)
		{
			prb_Actualizar2.Visible = true;
			timer1_2.Enabled = true;
			prb_Actualizar2.Value = 0;
		}

		private void pnl_Formatear2_Click(object sender, EventArgs e)
		{

			DialogResult R = MessageBox.Show(this, "Se borrara todo el contenido del disco duro", "¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (R == DialogResult.Yes)
			{
				prb_Actualizar2.Visible = true;
				tmr_Formatear2.Enabled = true;
				prb_Actualizar2.Value = 0;
			}
		}

		private void timer1_2_Tick(object sender, EventArgs e)
		{
			if (prb_Actualizar2.Value < 100)
				prb_Actualizar2.Value += 2;
			if (prb_Actualizar2.Value == 100)
			{

				timer1_2.Enabled = false;
				prb_Actualizar2.Visible = false;
				prb_Actualizar2.Value = 0;//aq
				MessageBox.Show(this, "No se han encontrado nuevos dispocitivos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void tmr_Formatear2_Tick_1(object sender, EventArgs e)
		{
			if (prb_Actualizar2.Value < 100)
			{
				prb_Actualizar2.Value += 2;
			}
			if (prb_Actualizar2.Value == 100)
			{
				tmr_Formatear2.Enabled = false;
				prb_Actualizar2.Visible = false;
				prb_Actualizar2.Value = 0;
				MessageBox.Show(this, "Se ha formateado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void btnSiguiente_Click_1(object sender, EventArgs e)
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
