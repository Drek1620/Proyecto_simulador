namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_19
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblNoidenticas = new System.Windows.Forms.Label();
            this.rjtxtcontr2 = new CustomControls.RJControls.RJTextBox();
            this.rjtxtContr1 = new CustomControls.RJControls.RJTextBox();
            this.btnSiguiente = new Proyecto_simulador.RButton();
            this.btnAceptar = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.checkBox1.Location = new System.Drawing.Point(429, 284);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 36);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Mostrar contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblNoidenticas
            // 
            this.lblNoidenticas.AutoSize = true;
            this.lblNoidenticas.BackColor = System.Drawing.Color.Transparent;
            this.lblNoidenticas.ForeColor = System.Drawing.Color.Red;
            this.lblNoidenticas.Location = new System.Drawing.Point(559, 254);
            this.lblNoidenticas.Name = "lblNoidenticas";
            this.lblNoidenticas.Size = new System.Drawing.Size(0, 13);
            this.lblNoidenticas.TabIndex = 12;
            this.lblNoidenticas.Visible = false;
            // 
            // rjtxtcontr2
            // 
            this.rjtxtcontr2.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxtcontr2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(191)))));
            this.rjtxtcontr2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(191)))));
            this.rjtxtcontr2.BorderRadius = 6;
            this.rjtxtcontr2.BorderSize = 3;
            this.rjtxtcontr2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtxtcontr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtxtcontr2.Location = new System.Drawing.Point(429, 248);
            this.rjtxtcontr2.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtcontr2.Multiline = false;
            this.rjtxtcontr2.Name = "rjtxtcontr2";
            this.rjtxtcontr2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 5);
            this.rjtxtcontr2.PasswordChar = true;
            this.rjtxtcontr2.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rjtxtcontr2.PlaceholderText = "Confirmar PIN";
            this.rjtxtcontr2.Size = new System.Drawing.Size(273, 29);
            this.rjtxtcontr2.TabIndex = 10;
            this.rjtxtcontr2.TabStop = false;
            this.rjtxtcontr2.Texts = "";
            this.rjtxtcontr2.UnderlinedStyle = true;
            this.rjtxtcontr2.Visible = false;
            this.rjtxtcontr2._TextChanged += new System.EventHandler(this.rjtxtcontr2__TextChanged);
            // 
            // rjtxtContr1
            // 
            this.rjtxtContr1.BackColor = System.Drawing.SystemColors.Window;
            this.rjtxtContr1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(191)))));
            this.rjtxtContr1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(117)))), ((int)(((byte)(191)))));
            this.rjtxtContr1.BorderRadius = 6;
            this.rjtxtContr1.BorderSize = 3;
            this.rjtxtContr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.rjtxtContr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjtxtContr1.Location = new System.Drawing.Point(429, 213);
            this.rjtxtContr1.Margin = new System.Windows.Forms.Padding(4);
            this.rjtxtContr1.Multiline = false;
            this.rjtxtContr1.Name = "rjtxtContr1";
            this.rjtxtContr1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 5);
            this.rjtxtContr1.PasswordChar = true;
            this.rjtxtContr1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rjtxtContr1.PlaceholderText = "Nuevo PIN";
            this.rjtxtContr1.Size = new System.Drawing.Size(273, 29);
            this.rjtxtContr1.TabIndex = 9;
            this.rjtxtContr1.TabStop = false;
            this.rjtxtContr1.Texts = "";
            this.rjtxtContr1.UnderlinedStyle = true;
            this.rjtxtContr1.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(146)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(146)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiguiente.BorderRadius = 5;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(619, 493);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(106, 37);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Crear un PIN";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 5;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(619, 493);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(106, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Pantalla_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_19_1_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblNoidenticas);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.rjtxtcontr2);
            this.Controls.Add(this.rjtxtContr1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_19";
            this.Text = "Pantalla_19";
            this.Load += new System.EventHandler(this.Pantalla_19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RButton btnSiguiente;
        private RButton btnAceptar;
        private CustomControls.RJControls.RJTextBox rjtxtContr1;
        private CustomControls.RJControls.RJTextBox rjtxtcontr2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblNoidenticas;
    }
}