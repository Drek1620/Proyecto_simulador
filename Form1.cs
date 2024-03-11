using Proyecto_simulador.Ubuntu;
using Proyecto_simulador.Windows_11;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void windows10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void windows11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descripcion frm= new Descripcion();
            frm.ShowDialog();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.Show();
        }

        private void ubuntuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Des_Ubuntu des_Ubuntu = new Des_Ubuntu();
            des_Ubuntu.ShowDialog();
        }
    }
}
