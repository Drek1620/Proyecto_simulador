namespace Proyecto_simulador
{
    partial class Pantalla7_2
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pnl_Eliminar = new System.Windows.Forms.Panel();
            this.pnl_Actualizar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Formatear = new System.Windows.Forms.Panel();
            this.prb_Actualizar = new System.Windows.Forms.ProgressBar();
            this.tmr_Formatear = new System.Windows.Forms.Timer(this.components);
            this.pbl_Regresar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnSiguiente.Location = new System.Drawing.Point(574, 425);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(59, 21);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnl_Eliminar
            // 
            this.pnl_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Eliminar.Location = new System.Drawing.Point(287, 328);
            this.pnl_Eliminar.Name = "pnl_Eliminar";
            this.pnl_Eliminar.Size = new System.Drawing.Size(71, 24);
            this.pnl_Eliminar.TabIndex = 5;
            this.pnl_Eliminar.Click += new System.EventHandler(this.pnl_Eliminar_Click);
            // 
            // pnl_Actualizar
            // 
            this.pnl_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Actualizar.Location = new System.Drawing.Point(184, 328);
            this.pnl_Actualizar.Name = "pnl_Actualizar";
            this.pnl_Actualizar.Size = new System.Drawing.Size(73, 24);
            this.pnl_Actualizar.TabIndex = 7;
            this.pnl_Actualizar.Click += new System.EventHandler(this.pnl_Actualizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Formatear
            // 
            this.pnl_Formatear.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Formatear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Formatear.Location = new System.Drawing.Point(386, 327);
            this.pnl_Formatear.Name = "pnl_Formatear";
            this.pnl_Formatear.Size = new System.Drawing.Size(80, 25);
            this.pnl_Formatear.TabIndex = 8;
            this.pnl_Formatear.Click += new System.EventHandler(this.pnl_Formatear_Click);
            // 
            // prb_Actualizar
            // 
            this.prb_Actualizar.Location = new System.Drawing.Point(287, 250);
            this.prb_Actualizar.Name = "prb_Actualizar";
            this.prb_Actualizar.Size = new System.Drawing.Size(198, 18);
            this.prb_Actualizar.TabIndex = 9;
            // 
            // tmr_Formatear
            // 
            this.tmr_Formatear.Tick += new System.EventHandler(this.tmr_Formatear_Tick);
            // 
            // pbl_Regresar
            // 
            this.pbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.pbl_Regresar.Location = new System.Drawing.Point(151, 87);
            this.pbl_Regresar.Name = "pbl_Regresar";
            this.pbl_Regresar.Size = new System.Drawing.Size(28, 29);
            this.pbl_Regresar.TabIndex = 10;
            this.pbl_Regresar.Click += new System.EventHandler(this.pbl_Regresar_Click);
            // 
            // Pantalla7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_7_2;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pbl_Regresar);
            this.Controls.Add(this.prb_Actualizar);
            this.Controls.Add(this.pnl_Formatear);
            this.Controls.Add(this.pnl_Actualizar);
            this.Controls.Add(this.pnl_Eliminar);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla7_2";
            this.Text = "Pantalla7_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pnl_Eliminar;
        private System.Windows.Forms.Panel pnl_Actualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_Formatear;
        private System.Windows.Forms.ProgressBar prb_Actualizar;
        private System.Windows.Forms.Timer tmr_Formatear;
        private System.Windows.Forms.Panel pbl_Regresar;
    }
}