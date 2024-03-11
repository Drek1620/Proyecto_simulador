namespace Proyecto_simulador
{
    partial class Pantalla15
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
            this.panSiguiente = new System.Windows.Forms.Panel();
            this.pnl_Atras = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // panSiguiente
            // 
            this.panSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.panSiguiente.Location = new System.Drawing.Point(631, 512);
            this.panSiguiente.Name = "panSiguiente";
            this.panSiguiente.Size = new System.Drawing.Size(134, 33);
            this.panSiguiente.TabIndex = 0;
            this.panSiguiente.Click += new System.EventHandler(this.panSiguiente_Click);
            // 
            // pnl_Atras
            // 
            this.pnl_Atras.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Atras.Location = new System.Drawing.Point(484, 512);
            this.pnl_Atras.Name = "pnl_Atras";
            this.pnl_Atras.Size = new System.Drawing.Size(136, 33);
            this.pnl_Atras.TabIndex = 5;
            this.pnl_Atras.Click += new System.EventHandler(this.pnl_Atras_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(267, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(380, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.txt_contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(144)))));
            this.txt_contraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_contraseña.BorderRadius = 0;
            this.txt_contraseña.BorderSize = 2;
            this.txt_contraseña.Font = new System.Drawing.Font("Avrile Sans", 9F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_contraseña.Location = new System.Drawing.Point(212, 254);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_contraseña.PasswordChar = true;
            this.txt_contraseña.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(144)))));
            this.txt_contraseña.PlaceholderText = "Contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(377, 32);
            this.txt_contraseña.TabIndex = 6;
            this.txt_contraseña.TabStop = false;
            this.txt_contraseña.Texts = "";
            this.txt_contraseña.UnderlinedStyle = false;
            this.txt_contraseña._TextChanged += new System.EventHandler(this.txt_contraseña__TextChanged);
            // 
            // Pantalla15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_15;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.pnl_Atras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla15";
            this.Text = "Pantalla15";
            this.Load += new System.EventHandler(this.Pantalla15_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSiguiente;
        private System.Windows.Forms.Panel pnl_Atras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txt_contraseña;
    }
}