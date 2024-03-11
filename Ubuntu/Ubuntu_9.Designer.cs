namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_9
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
            this.btnInstalar = new Proyecto_simulador.RButton();
            this.SuspendLayout();
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
            this.btnInstalar.Font = new System.Drawing.Font("Ubuntu", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.Location = new System.Drawing.Point(536, 408);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(131, 34);
            this.btnInstalar.TabIndex = 9;
            this.btnInstalar.Text = "Reiniciar ahora";
            this.btnInstalar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Ubuntu_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_9;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.btnInstalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_9";
            this.Text = "Ubuntu_9";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnInstalar;
    }
}