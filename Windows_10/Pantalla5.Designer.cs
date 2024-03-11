namespace Proyecto_simulador
{
    partial class Pantalla5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla5));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_terminos = new System.Windows.Forms.CheckBox();
            this.pbl_Regresar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSiguiente.Location = new System.Drawing.Point(569, 423);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(65, 21);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(186, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(426, 213);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // chk_terminos
            // 
            this.chk_terminos.AutoSize = true;
            this.chk_terminos.BackColor = System.Drawing.Color.White;
            this.chk_terminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chk_terminos.ForeColor = System.Drawing.Color.Black;
            this.chk_terminos.Location = new System.Drawing.Point(186, 385);
            this.chk_terminos.Name = "chk_terminos";
            this.chk_terminos.Size = new System.Drawing.Size(195, 19);
            this.chk_terminos.TabIndex = 4;
            this.chk_terminos.Text = "Acepto los terminos de licencia";
            this.chk_terminos.UseVisualStyleBackColor = false;
            this.chk_terminos.CheckedChanged += new System.EventHandler(this.chk_terminos_CheckedChanged);
            // 
            // pbl_Regresar
            // 
            this.pbl_Regresar.BackColor = System.Drawing.Color.Transparent;
            this.pbl_Regresar.Location = new System.Drawing.Point(152, 87);
            this.pbl_Regresar.Name = "pbl_Regresar";
            this.pbl_Regresar.Size = new System.Drawing.Size(29, 28);
            this.pbl_Regresar.TabIndex = 5;
            this.pbl_Regresar.Click += new System.EventHandler(this.pbl_Regresar_Click);
            // 
            // Pantalla5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_5;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pbl_Regresar);
            this.Controls.Add(this.chk_terminos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla5";
            this.Text = "Pantalla5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chk_terminos;
        private System.Windows.Forms.Panel pbl_Regresar;
    }
}