namespace Proyecto_simulador
{
    partial class Pantalla7
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
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prb_Actualizar = new System.Windows.Forms.ProgressBar();
            this.pnl_Actualizar = new System.Windows.Forms.Panel();
            this.pnl_Formatear = new System.Windows.Forms.Panel();
            this.tmr_Formatear = new System.Windows.Forms.Timer(this.components);
            this.pnl_Eliminar = new System.Windows.Forms.Panel();
            this.pbl_Regresar = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Gb = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Tamaño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSiguiente.Location = new System.Drawing.Point(564, 425);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(68, 22);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNuevo.Location = new System.Drawing.Point(493, 330);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(60, 21);
            this.pnlNuevo.TabIndex = 4;
            this.pnlNuevo.Click += new System.EventHandler(this.pnlNuevo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prb_Actualizar
            // 
            this.prb_Actualizar.Location = new System.Drawing.Point(297, 278);
            this.prb_Actualizar.Name = "prb_Actualizar";
            this.prb_Actualizar.Size = new System.Drawing.Size(198, 18);
            this.prb_Actualizar.TabIndex = 5;
            // 
            // pnl_Actualizar
            // 
            this.pnl_Actualizar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Actualizar.Location = new System.Drawing.Point(187, 332);
            this.pnl_Actualizar.Name = "pnl_Actualizar";
            this.pnl_Actualizar.Size = new System.Drawing.Size(65, 19);
            this.pnl_Actualizar.TabIndex = 6;
            this.pnl_Actualizar.Click += new System.EventHandler(this.pnl_Actualizar_Click);
            // 
            // pnl_Formatear
            // 
            this.pnl_Formatear.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Formatear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Formatear.Location = new System.Drawing.Point(380, 330);
            this.pnl_Formatear.Name = "pnl_Formatear";
            this.pnl_Formatear.Size = new System.Drawing.Size(80, 21);
            this.pnl_Formatear.TabIndex = 7;
            this.pnl_Formatear.Click += new System.EventHandler(this.pnl_Formatear_Click);
            // 
            // tmr_Formatear
            // 
            this.tmr_Formatear.Tick += new System.EventHandler(this.tmr_Formatear_Tick);
            // 
            // pnl_Eliminar
            // 
            this.pnl_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Eliminar.Location = new System.Drawing.Point(287, 330);
            this.pnl_Eliminar.Name = "pnl_Eliminar";
            this.pnl_Eliminar.Size = new System.Drawing.Size(71, 21);
            this.pnl_Eliminar.TabIndex = 8;
            this.pnl_Eliminar.Click += new System.EventHandler(this.pnl_Eliminar_Click);
            // 
            // pbl_Regresar
            // 
            this.pbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.pbl_Regresar.Location = new System.Drawing.Point(152, 87);
            this.pbl_Regresar.Name = "pbl_Regresar";
            this.pbl_Regresar.Size = new System.Drawing.Size(28, 27);
            this.pbl_Regresar.TabIndex = 9;
            this.pbl_Regresar.Click += new System.EventHandler(this.pbl_Regresar_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.numericUpDown1.Location = new System.Drawing.Point(419, 371);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 18);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.AutoSize = true;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_Aceptar.Location = new System.Drawing.Point(502, 368);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(56, 23);
            this.btn_Aceptar.TabIndex = 11;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Gb
            // 
            this.lbl_Gb.AutoSize = true;
            this.lbl_Gb.BackColor = System.Drawing.Color.White;
            this.lbl_Gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Gb.Location = new System.Drawing.Point(473, 377);
            this.lbl_Gb.Name = "lbl_Gb";
            this.lbl_Gb.Size = new System.Drawing.Size(22, 13);
            this.lbl_Gb.TabIndex = 12;
            this.lbl_Gb.Text = "GB";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AutoSize = true;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btn_Cancelar.Location = new System.Drawing.Point(564, 368);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(59, 23);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lbl_Tamaño
            // 
            this.lbl_Tamaño.AutoSize = true;
            this.lbl_Tamaño.BackColor = System.Drawing.Color.White;
            this.lbl_Tamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Tamaño.Location = new System.Drawing.Point(364, 375);
            this.lbl_Tamaño.Name = "lbl_Tamaño";
            this.lbl_Tamaño.Size = new System.Drawing.Size(47, 13);
            this.lbl_Tamaño.TabIndex = 14;
            this.lbl_Tamaño.Text = "Tamaño:";
            // 
            // Pantalla7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_7;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbl_Tamaño);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Gb);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pbl_Regresar);
            this.Controls.Add(this.pnl_Eliminar);
            this.Controls.Add(this.pnl_Formatear);
            this.Controls.Add(this.pnl_Actualizar);
            this.Controls.Add(this.prb_Actualizar);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.btnSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla7";
            this.Text = "Pantalla7";
            this.Load += new System.EventHandler(this.Pantalla7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prb_Actualizar;
        private System.Windows.Forms.Panel pnl_Actualizar;
        private System.Windows.Forms.Panel pnl_Formatear;
        private System.Windows.Forms.Timer tmr_Formatear;
        private System.Windows.Forms.Panel pnl_Eliminar;
        private System.Windows.Forms.Panel pbl_Regresar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Gb;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Tamaño;
    }
}