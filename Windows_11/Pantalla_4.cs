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
    public partial class Pantalla_4 : Form
    {
        public Pantalla_4()
        {
            InitializeComponent();
            Cursor = Cursors.Default; 
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			Pantalla_5 img5 = new Pantalla_5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.Controls.Clear();
			this.BackgroundImage = null;
			img5.FormBorderStyle = FormBorderStyle.None;
			this.Controls.Add(img5);
			img5.Show();
        }

		private void lblDate2_Click(object sender, EventArgs e)
		{
			
		}

		private void Pantalla_4_Load(object sender, EventArgs e)
		{
			lblDate1.Text = DateTime.Now.ToShortDateString();
			lblDate2.Text = DateTime.Now.ToShortDateString();
			lblDate3.Text = DateTime.Now.ToShortDateString();
			lblDate4.Text = DateTime.Now.ToShortDateString();
			lblDate6.Text = DateTime.Now.ToShortDateString();
            label1.Text = DateTime.Now.ToShortDateString();
        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lblDesc_Click(object sender, EventArgs e)
		{
			
		}

		private void lstWindows_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstWindows.SelectedIndex == 0 )
			{
				lblDesc.Text = "Descripcion \n Windows 11 Home";
			}

			if (lstWindows.SelectedIndex == 1)
			{
				lblDesc.Text = "Descripcion \n Windows 11 Home Single Language";
			}

			if (lstWindows.SelectedIndex == 2)
			{
				lblDesc.Text = "Descripcion \n Windows 11 Education";
			}

			if (lstWindows.SelectedIndex == 3)
			{
				lblDesc.Text = "Descripcion \n Windows 11 Pro";
			}

			if (lstWindows.SelectedIndex == 4)
			{
				lblDesc.Text = "Descripcion \n Windows 11 Pro Education";
			}

			if (lstWindows.SelectedIndex == 5)
			{
				lblDesc.Text = "Descripcion \n Windows 11 Pro For Workstation";
			}
		}
	}
}
