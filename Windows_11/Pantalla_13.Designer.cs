namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_13
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
            this.btnOmitir = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // btnOmitir
            // 
            this.btnOmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnOmitir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnOmitir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOmitir.BorderRadius = 5;
            this.btnOmitir.BorderSize = 0;
            this.btnOmitir.FlatAppearance.BorderSize = 0;
            this.btnOmitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmitir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnOmitir.ForeColor = System.Drawing.Color.White;
            this.btnOmitir.Location = new System.Drawing.Point(622, 489);
            this.btnOmitir.Name = "btnOmitir";
            this.btnOmitir.Size = new System.Drawing.Size(105, 35);
            this.btnOmitir.TabIndex = 2;
            this.btnOmitir.Text = "Omitir";
            this.btnOmitir.TextColor = System.Drawing.Color.White;
            this.btnOmitir.UseVisualStyleBackColor = false;
            this.btnOmitir.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // Pantalla_13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_13_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnOmitir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_13";
            this.Text = "Pantalla_13";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnOmitir;
    }
}