namespace Proyecto_simulador
{
    partial class PantallaWindows_10
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.panApagar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInicio
            // 
            this.panInicio.BackColor = System.Drawing.Color.Transparent;
            this.panInicio.Location = new System.Drawing.Point(0, 564);
            this.panInicio.Name = "panInicio";
            this.panInicio.Size = new System.Drawing.Size(40, 37);
            this.panInicio.TabIndex = 0;
            this.panInicio.Click += new System.EventHandler(this.panInicio_Click);
            // 
            // panMenu
            // 
            this.panMenu.AutoSize = true;
            this.panMenu.BackColor = System.Drawing.Color.Transparent;
            this.panMenu.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_windows_1__2_;
            this.panMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panMenu.Controls.Add(this.panApagar);
            this.panMenu.Location = new System.Drawing.Point(0, 71);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(506, 529);
            this.panMenu.TabIndex = 1;
            this.panMenu.Visible = false;
            // 
            // panApagar
            // 
            this.panApagar.Location = new System.Drawing.Point(3, 465);
            this.panApagar.Name = "panApagar";
            this.panApagar.Size = new System.Drawing.Size(34, 32);
            this.panApagar.TabIndex = 0;
            this.panApagar.Click += new System.EventHandler(this.panApagar_Click);
            this.panApagar.Paint += new System.Windows.Forms.PaintEventHandler(this.panApagar_Paint);
            this.panApagar.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presione el boton de windows y el simbolo de apagar\r\n para terminar la simulacion" +
    "";
            // 
            // PantallaWindows_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_windows10;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaWindows_10";
            this.Text = "PantallaWindows_10";
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panInicio;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panApagar;
        private System.Windows.Forms.Label label1;
    }
}