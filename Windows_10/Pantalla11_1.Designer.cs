namespace Proyecto_simulador
{
    partial class Pantalla11_1
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
            this.panOmitir = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panOmitir
            // 
            this.panOmitir.BackColor = System.Drawing.Color.Transparent;
            this.panOmitir.Location = new System.Drawing.Point(650, 511);
            this.panOmitir.Name = "panOmitir";
            this.panOmitir.Size = new System.Drawing.Size(131, 34);
            this.panOmitir.TabIndex = 2;
            this.panOmitir.Click += new System.EventHandler(this.panOmitir_Click);
            // 
            // Pantalla11_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_11_1;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panOmitir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla11_1";
            this.Text = "Pantalla11_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panOmitir;
    }
}