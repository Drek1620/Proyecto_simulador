namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_24
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panInicio = new System.Windows.Forms.Panel();
            this.panApagado = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInicio
            // 
            this.panInicio.BackColor = System.Drawing.Color.Transparent;
            this.panInicio.Location = new System.Drawing.Point(273, 562);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(48, 38);
            this.panInicio.TabIndex = 0;
            this.panInicio.Click += new System.EventHandler(this.panInicio_Click);
            // 
            // panApagado
            // 
            this.panApagado.Location = new System.Drawing.Point(462, 472);
            this.panApagado.Name = "panApagado";
            this.panApagado.Size = new System.Drawing.Size(45, 39);
            this.panApagado.TabIndex = 0;
            this.panApagado.Visible = false;
            this.panApagado.Click += new System.EventHandler(this.panApagado_Click);
            this.panApagado.Paint += new System.Windows.Forms.PaintEventHandler(this.panApagado_Paint);
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.Transparent;
            this.panMenu.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_24_3_w11_;
            this.panMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panMenu.Controls.Add(this.panApagado);
            this.panMenu.Location = new System.Drawing.Point(106, 37);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(579, 562);
            this.panMenu.TabIndex = 1;
            this.panMenu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Presione el boton de windows y el simbolo de apagar\r\n para terminar la simulacion" +
    "";
            // 
            // Pantalla_24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_24_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panInicio);
            this.Controls.Add(this.panMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_24";
            this.Text = "a";
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.Panel panApagado;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label label1;
    }
}