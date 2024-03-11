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
    public partial class Pantalla_12 : Form
    {
        public Pantalla_12()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox1.ItemHeight = 50;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Pantalla_13 img13 = new Pantalla_13() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            this.BackgroundImage = null;
            img13.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img13);
            img13.Show();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = new SolidBrush(Color.FromArgb(84, 84, 85));
            /*if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(0, 103, 192));*/
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.White;
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 64, 64)), e.Bounds);
            }

            const int PaddingLeft = 5;
            string text = (string)listBox1.Items[e.Index];
            SizeF textSize = e.Graphics.MeasureString(text, listBox1.Font);
            Brush brush = e.State.HasFlag(DrawItemState.Selected) ?
                SystemBrushes.HighlightText : SystemBrushes.WindowText;

            e.DrawBackground();
            e.Graphics.DrawString(text, listBox1.Font, brush,
                e.Bounds.Left + PaddingLeft, e.Bounds.Top + (listBox1.ItemHeight - textSize.Height) / 2);
            e.DrawFocusRectangle();
        }
    }
}
