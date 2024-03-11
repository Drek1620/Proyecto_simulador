using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_simulador.Ubuntu
{
    public partial class Ubuntu_2 : Form
    {
        public Ubuntu_2()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 10;

        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            Ubuntu_3 img = new Ubuntu_3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.FromArgb(233, 84, 32) : Color.White);

            e.Graphics.FillRectangle(backgroundColorBrush, e.Bounds);
            Brush myBrush = new SolidBrush(Color.Black);
            const int PaddingLeft = 5;
            string text = (string)listBox1.Items[e.Index];
            SizeF textSize = e.Graphics.MeasureString(text, listBox1.Font);
            SolidBrush brush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);


            e.Graphics.DrawString(text, listBox1.Font, brush,
                e.Bounds.Left + PaddingLeft, e.Bounds.Top );
            e.DrawFocusRectangle();

        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            Prueba img = new Prueba() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Controls.Clear();
            img.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(img);
            img.Show();
        }
    }
}
