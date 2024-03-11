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
    public partial class Pantalla7 : Form
    {
        public Pantalla7()
        {
            InitializeComponent();
            prb_Actualizar.Visible= false;
            numericUpDown1.Visible= false;  
            btn_Aceptar.Visible= false; 
            lbl_Gb.Visible=false;   
            btn_Cancelar.Visible= false; 
            lbl_Tamaño.Visible=false;
           
        }
 

        private void pnlNuevo_Click(object sender, EventArgs e)
        {          
            numericUpDown1.Visible = true;
            btn_Aceptar.Visible = true;
            lbl_Gb.Visible=true;  
            btn_Cancelar.Visible=true;  
            lbl_Tamaño.Visible = true;  

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prb_Actualizar.Value < 100)
                prb_Actualizar.Value+=2;
            if(prb_Actualizar.Value == 100)
            {
                timer1.Enabled = false;
                prb_Actualizar.Visible = false;
                prb_Actualizar.Value = 0;
                MessageBox.Show(this, "No se han encontrado nuevos dispocitivos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                        
        }

        private void pnl_Actualizar_Click(object sender, EventArgs e)
        {
            prb_Actualizar.Visible = true;
            timer1.Enabled = true;
            prb_Actualizar.Value = 0;
          
        }
        private void pnl_Formatear_Click(object sender, EventArgs e)
        {
            DialogResult R =  MessageBox.Show(this, "Se borrara todo el contenido del disco duro", "¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (R == DialogResult.Yes)
            {
                prb_Actualizar.Visible = true;
                tmr_Formatear.Enabled = true;
                prb_Actualizar.Value = 0;
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

        private void pnl_Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "No se puede eliminar esta unidad", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Pantalla7_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value>0)
            {
                Pantalla7_1 img7_1 = new Pantalla7_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            btn_Aceptar.Visible = false;
            lbl_Gb.Visible = false;
            btn_Cancelar.Visible = false;
            lbl_Tamaño.Visible = false; 
            numericUpDown1.Value = 0;
        }
    }
}
