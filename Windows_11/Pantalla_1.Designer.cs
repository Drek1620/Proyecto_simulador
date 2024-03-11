namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTeclado = new System.Windows.Forms.ComboBox();
            this.cboForm = new System.Windows.Forms.ComboBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            this.btnSiguiente.Location = new System.Drawing.Point(572, 420);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(59, 21);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_1_w11;
            this.panel1.Controls.Add(this.cboTeclado);
            this.panel1.Controls.Add(this.cboForm);
            this.panel1.Controls.Add(this.cboIdioma);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboTeclado
            // 
            this.cboTeclado.DropDownHeight = 80;
            this.cboTeclado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeclado.DropDownWidth = 280;
            this.cboTeclado.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.cboTeclado.FormattingEnabled = true;
            this.cboTeclado.IntegralHeight = false;
            this.cboTeclado.Items.AddRange(new object[] {
            "Latinoamericano",
            "Español (España)",
            "Inglés (US)",
            "Inglés (UK)",
            "Chino (Simplifid)",
            "Japonés",
            "Ruso"});
            this.cboTeclado.Location = new System.Drawing.Point(339, 332);
            this.cboTeclado.Name = "cboTeclado";
            this.cboTeclado.Size = new System.Drawing.Size(248, 20);
            this.cboTeclado.TabIndex = 2;
            // 
            // cboForm
            // 
            this.cboForm.DropDownHeight = 80;
            this.cboForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForm.DropDownWidth = 280;
            this.cboForm.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.cboForm.FormattingEnabled = true;
            this.cboForm.IntegralHeight = false;
            this.cboForm.Items.AddRange(new object[] {
            "Albánes",
            "Azeri (Cirílico)",
            "Azeri (latino)",
            "Vasco",
            "Bielorruso",
            "Búlgaro",
            "Catalán",
            "Croata",
            "Checo",
            "Danés",
            "Neerlandés",
            "Inglés (Canadá)",
            "Inglés (EE.UU)",
            "Inglés (Caribe)",
            "Inglés (Irlanda)",
            "Inglés (Jamaica)",
            "Ingles (Nueva Zelanda)",
            "Inglés (Filipinas)",
            "Inglés (Reino Unido)",
            "Estonio",
            "Faores",
            "Firlandes",
            "Francés (Bélgica)",
            "Francés (Francia)",
            "Gallego",
            "Alemán (Suiza)",
            "Alemán (Alemania)",
            "Griego",
            "Húngaro",
            "Islandes",
            "Indonesio",
            "Italiano (Italia)",
            "Italiano (Suiza)",
            "Japonés",
            "Letón",
            "Lituano",
            "Mongol",
            "Noruego (Bokmal)",
            "Noruego (Nynorsk)",
            "Polaco",
            "Portugués (Brazil)",
            "Portugués (Portugal)",
            "Rumano",
            "Ruso",
            "Servio ",
            "Eslovaco",
            "Esloveno",
            "Español (Bolivia",
            "Español (Chile)",
            "Español (Colombia)",
            "Español (Argentina)",
            "Español (Costa Rica)",
            "Español (El Salvador)",
            "Español (Guatemala)",
            "Español (Honduras)",
            "Español (México)",
            "Español (Panamá)",
            "Español (Perú)",
            "Sueco",
            "Tratáro",
            "Turco",
            "Ucraniano",
            "Uzbeko",
            "Chino (Mandarin)",
            "Chino (Cantones)",
            "Coreano (norte)",
            "Coreano (sur)",
            "Arabe (Dubai)",
            "Arabe (Arabia Sudi)"});
            this.cboForm.Location = new System.Drawing.Point(339, 304);
            this.cboForm.Name = "cboForm";
            this.cboForm.Size = new System.Drawing.Size(248, 20);
            this.cboForm.TabIndex = 2;
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownHeight = 80;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.DropDownWidth = 280;
            this.cboIdioma.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.IntegralHeight = false;
            this.cboIdioma.Items.AddRange(new object[] {
            "Albánes",
            "Azeri (cirílico)",
            "Azeri (latino)",
            "Vasco",
            "Bielorruso",
            "Búlgaro",
            "Catalán",
            "Croata",
            "Checo",
            "Danés",
            "Neerlandés (Bélgica)",
            "Neerlandés (Países Bajos)",
            "Inglés (Australia)",
            "Inglés (Belice)",
            "Inglés (Canadá)",
            "Inglés (Caribe)",
            "Inglés (Reino Unido)",
            "Inglés (EE.UU)",
            "Inglés (Nueva Zelanda)",
            "Inglés (Filipinas)",
            "Estonio",
            "Finlandés",
            "Francés (Bélgica)",
            "Francés (Francia)",
            "Francés (Canadá)",
            "Gallego",
            "Alemán (Australia)",
            "Alemán (Alemania)",
            "Griego",
            "Húngaro",
            "Islandés",
            "Italiano (Italia)",
            "Italiano (Suiza)",
            "Japonés ",
            "Letón",
            "Lituano",
            "Mongol",
            "Noruego (Bokmal)",
            "Noruego (Nysrok)",
            "Polaco",
            "Portugués (Brazil)",
            "Portugués (Portugal)",
            "Rumano",
            "Ruso",
            "Servio",
            "Eslovaco",
            "Esloveno",
            "Español (Bolivia)",
            "Español (Chile)",
            "Español (Colombia)",
            "Español (Costa Rica)",
            "Español (República Dominicana) ",
            "Español (El Salvador)",
            "Español (Guatemala)",
            "Español (México)",
            "Español (Perú)",
            "Español (España)",
            "Turco",
            "Ucraniano",
            "Uzbeko (latino)",
            "Chino (Mandarin)",
            "Chino (Cantones)",
            "Coreano (Corea Sur)",
            "Coreano (Core Norte)",
            "Arabe (Arabia Sudi)"});
            this.cboIdioma.Location = new System.Drawing.Point(339, 277);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(248, 20);
            this.cboIdioma.TabIndex = 2;
            // 
            // Pantalla_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_1_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pantalla_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Interactivo Instalacion Windows 11";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla_1_FormClosing);
            this.Load += new System.EventHandler(this.Pantalla_1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cboTeclado;
		private System.Windows.Forms.ComboBox cboForm;
		private System.Windows.Forms.ComboBox cboIdioma;
	}
}