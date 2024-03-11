namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_18
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
            this.btnSesion = new Proyecto_simulador.RButton();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.rjtxtContraseña = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSesion.BorderRadius = 5;
            this.btnSesion.BorderSize = 0;
            this.btnSesion.FlatAppearance.BorderSize = 0;
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.White;
            this.btnSesion.Location = new System.Drawing.Point(624, 492);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(103, 35);
            this.btnSesion.TabIndex = 7;
            this.btnSesion.Text = "Iniciar Sesión";
            this.btnSesion.TextColor = System.Drawing.Color.White;
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // lblEnviar
            // 
            this.lblEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.lblEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.lblEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(122)))), ((int)(((byte)(193)))));
            this.lblEnviar.Location = new System.Drawing.Point(430, 301);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(313, 23);
            this.lblEnviar.TabIndex = 8;
            // 
            // lblCorreo
            // 
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(453, 191);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(209, 23);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // rjtxtContraseña
            // 
            this.rjtxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.rjtxtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtContraseña.BorderRadius = 5;
            this.rjtxtContraseña.BorderSize = 4;
            this.rjtxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxtContraseña.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.rjtxtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtxtContraseña.Location = new System.Drawing.Point(427, 246);
            this.rjtxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtContraseña.Multiline = false;
            this.rjtxtContraseña.Name = "rjtxtContraseña";
            this.rjtxtContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtxtContraseña.PasswordChar = true;
            this.rjtxtContraseña.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rjtxtContraseña.PlaceholderText = "Contraseña";
            this.rjtxtContraseña.Size = new System.Drawing.Size(303, 30);
            this.rjtxtContraseña.TabIndex = 10;
            this.rjtxtContraseña.Texts = "";
            this.rjtxtContraseña.UnderlinedStyle = true;
            this.rjtxtContraseña._TextChanged += new System.EventHandler(this.rjtxtContraseña__TextChanged);
            // 
            // Pantalla_18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_18_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rjtxtContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblEnviar);
            this.Controls.Add(this.btnSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_18";
            this.Text = "Pantalla_18";
            this.Load += new System.EventHandler(this.Pantalla_18_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RButton btnSesion;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Label lblCorreo;
        private CustomControls.RJControls.RJTextBox rjtxtContraseña;
    }
}