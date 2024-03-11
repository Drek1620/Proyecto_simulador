namespace Proyecto_simulador.Windows_11
{
	partial class Pantalla_7_1
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
            this.panCancelar = new System.Windows.Forms.Panel();
            this.panAceptar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panCancelar
            // 
            this.panCancelar.BackColor = System.Drawing.Color.Transparent;
            this.panCancelar.Location = new System.Drawing.Point(542, 353);
            this.panCancelar.Name = "panCancelar";
            this.panCancelar.Size = new System.Drawing.Size(63, 20);
            this.panCancelar.TabIndex = 3;
            this.panCancelar.Click += new System.EventHandler(this.panCancelar_Click);
            // 
            // panAceptar
            // 
            this.panAceptar.BackColor = System.Drawing.Color.Transparent;
            this.panAceptar.Location = new System.Drawing.Point(473, 353);
            this.panAceptar.Name = "panAceptar";
            this.panAceptar.Size = new System.Drawing.Size(63, 20);
            this.panAceptar.TabIndex = 2;
            this.panAceptar.Click += new System.EventHandler(this.panAceptar_Click);
            // 
            // Pantalla_7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_7_1_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panCancelar);
            this.Controls.Add(this.panAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_7_1";
            this.Text = "Pantalla_7_1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panCancelar;
		private System.Windows.Forms.Panel panAceptar;
	}
}