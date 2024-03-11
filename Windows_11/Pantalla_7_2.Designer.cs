namespace Proyecto_simulador.Windows_11
{
	partial class Pantalla_7_2
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
            this.components = new System.ComponentModel.Container();
            this.timer1_2 = new System.Windows.Forms.Timer(this.components);
            this.tmr_Formatear2 = new System.Windows.Forms.Timer(this.components);
            this.prb_Actualizar2 = new System.Windows.Forms.ProgressBar();
            this.pnl_Formatear2 = new System.Windows.Forms.Panel();
            this.pnl_Actualizar2 = new System.Windows.Forms.Panel();
            this.pnl_Eliminar2 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1_2
            // 
            this.timer1_2.Tick += new System.EventHandler(this.timer1_2_Tick);
            // 
            // tmr_Formatear2
            // 
            this.tmr_Formatear2.Tick += new System.EventHandler(this.tmr_Formatear2_Tick_1);
            // 
            // prb_Actualizar2
            // 
            this.prb_Actualizar2.Location = new System.Drawing.Point(293, 258);
            this.prb_Actualizar2.Name = "prb_Actualizar2";
            this.prb_Actualizar2.Size = new System.Drawing.Size(198, 18);
            this.prb_Actualizar2.TabIndex = 13;
            // 
            // pnl_Formatear2
            // 
            this.pnl_Formatear2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Formatear2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Formatear2.Location = new System.Drawing.Point(387, 328);
            this.pnl_Formatear2.Name = "pnl_Formatear2";
            this.pnl_Formatear2.Size = new System.Drawing.Size(70, 24);
            this.pnl_Formatear2.TabIndex = 12;
            this.pnl_Formatear2.Click += new System.EventHandler(this.pnl_Formatear2_Click);
            // 
            // pnl_Actualizar2
            // 
            this.pnl_Actualizar2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Actualizar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Actualizar2.Location = new System.Drawing.Point(185, 328);
            this.pnl_Actualizar2.Name = "pnl_Actualizar2";
            this.pnl_Actualizar2.Size = new System.Drawing.Size(68, 24);
            this.pnl_Actualizar2.TabIndex = 11;
            this.pnl_Actualizar2.Click += new System.EventHandler(this.pnl_Actualizar2_Click);
            // 
            // pnl_Eliminar2
            // 
            this.pnl_Eliminar2.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Eliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Eliminar2.Location = new System.Drawing.Point(293, 328);
            this.pnl_Eliminar2.Name = "pnl_Eliminar2";
            this.pnl_Eliminar2.Size = new System.Drawing.Size(61, 24);
            this.pnl_Eliminar2.TabIndex = 10;
            this.pnl_Eliminar2.Click += new System.EventHandler(this.pnl_Eliminar2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnSiguiente.Location = new System.Drawing.Point(569, 422);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(68, 23);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // Pantalla_7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_7_2;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.prb_Actualizar2);
            this.Controls.Add(this.pnl_Formatear2);
            this.Controls.Add(this.pnl_Actualizar2);
            this.Controls.Add(this.pnl_Eliminar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_7_2";
            this.Text = "Pantalla_7_2";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1_2;
		private System.Windows.Forms.Timer tmr_Formatear2;
		private System.Windows.Forms.ProgressBar prb_Actualizar2;
		private System.Windows.Forms.Panel pnl_Formatear2;
		private System.Windows.Forms.Panel pnl_Actualizar2;
		private System.Windows.Forms.Panel pnl_Eliminar2;
		private System.Windows.Forms.Button btnSiguiente;
	}
}