namespace Proyecto_simulador
{
    partial class Pantalla6
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
            this.pnlSigiuiente = new System.Windows.Forms.Panel();
            this.pbl_Regresar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSigiuiente
            // 
            this.pnlSigiuiente.BackColor = System.Drawing.Color.Transparent;
            this.pnlSigiuiente.Location = new System.Drawing.Point(186, 247);
            this.pnlSigiuiente.Name = "pnlSigiuiente";
            this.pnlSigiuiente.Size = new System.Drawing.Size(413, 92);
            this.pnlSigiuiente.TabIndex = 0;
            this.pnlSigiuiente.Click += new System.EventHandler(this.pnlSigiuiente_Click);
            // 
            // pbl_Regresar
            // 
            this.pbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.pbl_Regresar.Location = new System.Drawing.Point(152, 86);
            this.pbl_Regresar.Name = "pbl_Regresar";
            this.pbl_Regresar.Size = new System.Drawing.Size(29, 30);
            this.pbl_Regresar.TabIndex = 6;
            this.pbl_Regresar.Click += new System.EventHandler(this.pbl_Regresar_Click);
            // 
            // Pantalla6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_6;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pbl_Regresar);
            this.Controls.Add(this.pnlSigiuiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla6";
            this.Text = "Pantalla6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSigiuiente;
        private System.Windows.Forms.Panel pbl_Regresar;
    }
}