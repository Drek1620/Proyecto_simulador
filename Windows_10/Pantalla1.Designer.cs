namespace Proyecto_simulador
{
    partial class Pantalla1
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
            this.cbo_idioma_Ins = new System.Windows.Forms.ComboBox();
            this.cbo_Formato_Fec_Hor = new System.Windows.Forms.ComboBox();
            this.cbo_Teclado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Tai Le", 7F);
            this.btnSiguiente.Location = new System.Drawing.Point(571, 420);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(60, 23);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cbo_idioma_Ins
            // 
            this.cbo_idioma_Ins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_idioma_Ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_idioma_Ins.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.cbo_idioma_Ins.FormattingEnabled = true;
            this.cbo_idioma_Ins.ItemHeight = 13;
            this.cbo_idioma_Ins.Items.AddRange(new object[] {
            "Español (México)",
            "Español (España)",
            "Sueco (Suecia)",
            "Tailandés (Tailandia)",
            "Turco (Turquía)",
            "Ucraniano (Ucrania)",
            "Vietnamita",
            "Árabe (Arabia Saud)",
            "Búlgaro (Bulgaria)",
            "Catalán",
            "Chino (simplificado, China)",
            "Chino (tradicional, Taiwán)",
            "Croata (Croacia)",
            "Checo (República Checa)",
            "Danés (Dinamarca)",
            "Neerlandés (Países Bajos)",
            "Inglés (Estados Unidos)",
            "Inglés (Reino Unido)",
            "Estonio (Estonia)",
            "Finés (Finlandia)",
            "Francés (Canadá)",
            "Francés (Francia)",
            "Alemán (Alemania)",
            "Griego (Grecia)",
            "Hebreo (Israel)",
            "Japonés (Japón)",
            "Coreano (Corea)"});
            this.cbo_idioma_Ins.Location = new System.Drawing.Point(340, 278);
            this.cbo_idioma_Ins.Name = "cbo_idioma_Ins";
            this.cbo_idioma_Ins.Size = new System.Drawing.Size(248, 21);
            this.cbo_idioma_Ins.TabIndex = 1;
            this.cbo_idioma_Ins.TabStop = false;
            // 
            // cbo_Formato_Fec_Hor
            // 
            this.cbo_Formato_Fec_Hor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Formato_Fec_Hor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Formato_Fec_Hor.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.cbo_Formato_Fec_Hor.FormattingEnabled = true;
            this.cbo_Formato_Fec_Hor.Items.AddRange(new object[] {
            "Español (México)",
            "Español (España)",
            "Sueco (Suecia)",
            "Tailandés (Tailandia)",
            "Turco (Turquía)",
            "Ucraniano (Ucrania)",
            "Vietnamita",
            "Árabe (Arabia Saud)",
            "Búlgaro (Bulgaria)",
            "Catalán",
            "Chino (simplificado, China)",
            "Chino (tradicional, Taiwán)",
            "Croata (Croacia)",
            "Checo (República Checa)",
            "Danés (Dinamarca)",
            "Neerlandés (Países Bajos)",
            "Inglés (Estados Unidos)",
            "Inglés (Reino Unido)",
            "Estonio (Estonia)",
            "Finés (Finlandia)",
            "Francés (Canadá)",
            "Francés (Francia)",
            "Alemán (Alemania)",
            "Griego (Grecia)",
            "Hebreo (Israel)",
            "Japonés (Japón)",
            "Coreano (Corea)"});
            this.cbo_Formato_Fec_Hor.Location = new System.Drawing.Point(340, 305);
            this.cbo_Formato_Fec_Hor.Name = "cbo_Formato_Fec_Hor";
            this.cbo_Formato_Fec_Hor.Size = new System.Drawing.Size(248, 21);
            this.cbo_Formato_Fec_Hor.TabIndex = 2;
            // 
            // cbo_Teclado
            // 
            this.cbo_Teclado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Teclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Teclado.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.cbo_Teclado.FormattingEnabled = true;
            this.cbo_Teclado.Items.AddRange(new object[] {
            "Latinoamericano",
            "Español(españa)",
            "Ingles (US)",
            "Ingles (UK)"});
            this.cbo_Teclado.Location = new System.Drawing.Point(340, 332);
            this.cbo_Teclado.Name = "cbo_Teclado";
            this.cbo_Teclado.Size = new System.Drawing.Size(248, 21);
            this.cbo_Teclado.TabIndex = 3;
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.VirtualBox_Windows_10_31_03_2023_13_55_02;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cbo_Teclado);
            this.Controls.Add(this.cbo_Formato_Fec_Hor);
            this.Controls.Add(this.cbo_idioma_Ins);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "Pantalla1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Interactivo Instalador Windows 10";
            this.Load += new System.EventHandler(this.Pantalla1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cbo_idioma_Ins;
        private System.Windows.Forms.ComboBox cbo_Formato_Fec_Hor;
        private System.Windows.Forms.ComboBox cbo_Teclado;
    }
}