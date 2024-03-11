namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_17_1
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
            this.btnSiguiente = new Proyecto_simulador.RButton();
            this.rjtxtCorreo = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiguiente.BorderRadius = 5;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(624, 490);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(102, 37);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // rjtxtCorreo
            // 
            this.rjtxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.rjtxtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtCorreo.BorderRadius = 5;
            this.rjtxtCorreo.BorderSize = 4;
            this.rjtxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxtCorreo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rjtxtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtxtCorreo.Location = new System.Drawing.Point(426, 219);
            this.rjtxtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtCorreo.Multiline = false;
            this.rjtxtCorreo.Name = "rjtxtCorreo";
            this.rjtxtCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxtCorreo.PasswordChar = false;
            this.rjtxtCorreo.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rjtxtCorreo.PlaceholderText = "Correo electronico, telfono o Skype ";
            this.rjtxtCorreo.Size = new System.Drawing.Size(303, 30);
            this.rjtxtCorreo.TabIndex = 9;
            this.rjtxtCorreo.Texts = "";
            this.rjtxtCorreo.UnderlinedStyle = true;
            // 
            // Pantalla_17_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_17_1_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rjtxtCorreo);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_17_1";
            this.Text = "Pantalla_17_1";
            this.Load += new System.EventHandler(this.Pantalla_17_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnSiguiente;
        private CustomControls.RJControls.RJTextBox rjtxtCorreo;
    }
}