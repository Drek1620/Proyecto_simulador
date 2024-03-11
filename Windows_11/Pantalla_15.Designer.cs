namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_15
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
            this.rButton1 = new Proyecto_simulador.RButton();
            this.rjtxtNombre = new CustomControls.RJControls.RJTextBox();
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
            this.btnSiguiente.Location = new System.Drawing.Point(622, 492);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(102, 36);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.Transparent;
            this.rButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 0;
            this.rButton1.BorderSize = 0;
            this.rButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rButton1.Location = new System.Drawing.Point(644, 639);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(147, 30);
            this.rButton1.TabIndex = 6;
            this.rButton1.TextColor = System.Drawing.Color.RoyalBlue;
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // rjtxtNombre
            // 
            this.rjtxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.rjtxtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.rjtxtNombre.BorderRadius = 5;
            this.rjtxtNombre.BorderSize = 3;
            this.rjtxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rjtxtNombre.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rjtxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtxtNombre.Location = new System.Drawing.Point(428, 283);
            this.rjtxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtNombre.Multiline = false;
            this.rjtxtNombre.Name = "rjtxtNombre";
            this.rjtxtNombre.Padding = new System.Windows.Forms.Padding(10, 13, 10, 13);
            this.rjtxtNombre.PasswordChar = false;
            this.rjtxtNombre.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rjtxtNombre.PlaceholderText = "Asigna un nombre al dispositivo";
            this.rjtxtNombre.Size = new System.Drawing.Size(238, 41);
            this.rjtxtNombre.TabIndex = 5;
            this.rjtxtNombre.TabStop = false;
            this.rjtxtNombre.Texts = "";
            this.rjtxtNombre.UnderlinedStyle = true;
            // 
            // Pantalla_15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_15_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rButton1);
            this.Controls.Add(this.rjtxtNombre);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_15";
            this.Text = "Pantalla_15";
            this.Load += new System.EventHandler(this.Pantalla_15_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnSiguiente;
        private RButton rButton1;
        private CustomControls.RJControls.RJTextBox rjtxtNombre;
    }
}