namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_4
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lstWindows = new System.Windows.Forms.ListBox();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate6 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnSiguiente.Location = new System.Drawing.Point(567, 420);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(66, 25);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lstWindows
            // 
            this.lstWindows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Items.AddRange(new object[] {
            "Windows 11 Home                                                              x64",
            "Windows 11 Home Single Language                                   x64",
            "Windows 11 Education                                                        x64",
            "Windows 11 Pro                                                                   " +
                "x64",
            "Windows 11 Pro Education                                                  x64",
            "Windows 11 Pro for Workstations                                        x64"});
            this.lstWindows.Location = new System.Drawing.Point(190, 187);
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(335, 91);
            this.lstWindows.TabIndex = 3;
            this.lstWindows.SelectedIndexChanged += new System.EventHandler(this.lstWindows_SelectedIndexChanged);
            // 
            // lblDate1
            // 
            this.lblDate1.BackColor = System.Drawing.Color.White;
            this.lblDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDate1.Location = new System.Drawing.Point(525, 187);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(72, 14);
            this.lblDate1.TabIndex = 4;
            // 
            // lblDate3
            // 
            this.lblDate3.BackColor = System.Drawing.Color.White;
            this.lblDate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDate3.Location = new System.Drawing.Point(525, 214);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(72, 14);
            this.lblDate3.TabIndex = 5;
            // 
            // lblDate2
            // 
            this.lblDate2.BackColor = System.Drawing.Color.White;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDate2.Location = new System.Drawing.Point(525, 201);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(72, 13);
            this.lblDate2.TabIndex = 6;
            this.lblDate2.Click += new System.EventHandler(this.lblDate2_Click);
            // 
            // lblDate4
            // 
            this.lblDate4.BackColor = System.Drawing.Color.White;
            this.lblDate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDate4.Location = new System.Drawing.Point(525, 227);
            this.lblDate4.Name = "lblDate4";
            this.lblDate4.Size = new System.Drawing.Size(72, 14);
            this.lblDate4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(525, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 8;
            // 
            // lblDate6
            // 
            this.lblDate6.BackColor = System.Drawing.Color.White;
            this.lblDate6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDate6.Location = new System.Drawing.Point(525, 240);
            this.lblDate6.Name = "lblDate6";
            this.lblDate6.Size = new System.Drawing.Size(72, 14);
            this.lblDate6.TabIndex = 9;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.White;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDesc.Location = new System.Drawing.Point(187, 301);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(204, 58);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // Pantalla_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_4_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.lstWindows);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate3);
            this.Controls.Add(this.lblDate4);
            this.Controls.Add(this.lblDate6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_4";
            this.Text = "Pantalla_4";
            this.Load += new System.EventHandler(this.Pantalla_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
		private System.Windows.Forms.ListBox lstWindows;
		private System.Windows.Forms.Label lblDate1;
		private System.Windows.Forms.Label lblDate3;
		private System.Windows.Forms.Label lblDate2;
		private System.Windows.Forms.Label lblDate4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDate6;
		private System.Windows.Forms.Label lblDesc;
	}
}