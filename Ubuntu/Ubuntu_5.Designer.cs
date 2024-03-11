namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_5
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
            this.btnAtras = new Proyecto_simulador.RButton();
            this.btnInstalar = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.BackgroundColor = System.Drawing.Color.White;
            this.btnAtras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAtras.BorderRadius = 5;
            this.btnAtras.BorderSize = 1;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Ubuntu", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnAtras.Location = new System.Drawing.Point(640, 562);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(78, 33);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnInstalar
            // 
            this.btnInstalar.BackColor = System.Drawing.Color.White;
            this.btnInstalar.BackgroundColor = System.Drawing.Color.White;
            this.btnInstalar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnInstalar.BorderRadius = 5;
            this.btnInstalar.BorderSize = 1;
            this.btnInstalar.FlatAppearance.BorderSize = 0;
            this.btnInstalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalar.Font = new System.Drawing.Font("Ubuntu", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.Location = new System.Drawing.Point(723, 562);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(124, 33);
            this.btnInstalar.TabIndex = 3;
            this.btnInstalar.Text = "Instalar ahora";
            this.btnInstalar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Ubuntu_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_5;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnInstalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_5";
            this.Text = "Ubuntu_5";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnAtras;
        private RButton btnInstalar;
    }
}