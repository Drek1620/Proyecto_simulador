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
    public partial class Pantalla11 : Form
    {
        public Pantalla11()
        {
            InitializeComponent();
            lst_Teclado.Visible= false; 
            lst_Teclado.ItemHeight = 50;
            listBox1.SelectedIndex = 19;
            listBox1.ItemHeight = 50;
        }
        int c = 0;
        //Aqui se me olvido agregar una imagen y la agregue al final pero solo la agrege de esta manera
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                c = 0;
                Pantalla11_1 img11_1 = new Pantalla11_1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.Controls.Clear();
                this.BackgroundImage = null;
                img11_1.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(img11_1);
                img11_1.Show();
            }
            else
            {
                listBox1.Visible= false;    
                lst_Teclado.Visible=true;
                lst_Teclado.SelectedIndex = 3;
                this.BackgroundImage = Properties.Resources.Imagen_11_2;
                c++;
            }
                
        }

        private void lst_Teclado_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.White;
            const int PaddingLeft = 5;
            string text = (string)lst_Teclado.Items[e.Index];
            SizeF textSize = e.Graphics.MeasureString(text, lst_Teclado.Font);
            Brush brush = e.State.HasFlag(DrawItemState.Selected) ?
                SystemBrushes.HighlightText : SystemBrushes.WindowText;

            e.DrawBackground();
            e.Graphics.DrawString(text, lst_Teclado.Font, myBrush,
                e.Bounds.Left + PaddingLeft, e.Bounds.Top + (lst_Teclado.ItemHeight - textSize.Height) / 2);
            e.DrawFocusRectangle();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.White;
            const int PaddingLeft = 5;
            string text = (string)listBox1.Items[e.Index];
            SizeF textSize = e.Graphics.MeasureString(text, listBox1.Font);
            Brush brush = e.State.HasFlag(DrawItemState.Selected) ?
                SystemBrushes.HighlightText : SystemBrushes.WindowText;

            e.DrawBackground();
            e.Graphics.DrawString(text, listBox1.Font, myBrush,
                e.Bounds.Left + PaddingLeft, e.Bounds.Top + (listBox1.ItemHeight - textSize.Height) / 2);
            e.DrawFocusRectangle();

        }
    }
}
