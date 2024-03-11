namespace Proyecto_simulador
{
    partial class Pantalla2
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
            this.btnInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstalar
            // 
            this.btnInstalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnInstalar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInstalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.btnInstalar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInstalar.Location = new System.Drawing.Point(345, 290);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(111, 30);
            this.btnInstalar.TabIndex = 0;
            this.btnInstalar.Text = "Instalar ahora";
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Pantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_2;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnInstalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla2";
            this.Text = "Imagen3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstalar;
    }
}