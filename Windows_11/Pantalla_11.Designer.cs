namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_11
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSi = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 50;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 10;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "   México                                                                        " +
                "     ",
            "   Afganistán         ",
            "   Albania                    ",
            "   Alemania",
            "   Angola         ",
            "   Anguila   ",
            "   Bélgica",
            "   Belice",
            "   Bolivia",
            "   Brazil",
            "   Canadá",
            "   Chile",
            "   China",
            "   China-Tiawan",
            "   Colombia",
            "   Corea Sur",
            "   Cuba",
            "   Dinamarca",
            "   Ecuador",
            "   Egipto",
            "   El Salvador",
            "   Eslovaquia",
            "   Eslovenia",
            "   España",
            "   Estados Unidos de America",
            "   Estonia",
            "   Filipinas",
            "   Finlandia",
            "   Francia",
            "   Grecia",
            "   Guatemala",
            "   Haití",
            "   Honduras",
            "   Hungria",
            "   India",
            "   Indonesia",
            "   Israel",
            "   Italia",
            "   Jamaica",
            "   Japón",
            "   Letonia",
            "   Líbano",
            "   Luxemburgo",
            "   Madagascar",
            "   Marruecos",
            "   Nicaragua",
            "   Noruega",
            "   Nueva Zelanda",
            "   Paises Bajos",
            "   Perú",
            "   Polonia",
            "   Portugal",
            "   Puerto Rico",
            "   Rusia",
            "   Senegal",
            "   Tunez",
            "   Turquía",
            "   Ucrania",
            "   Uruguay",
            "   Venezuela",
            "   Vietnam",
            "   Zona libre del colon (panama)"});
            this.listBox1.Location = new System.Drawing.Point(429, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(297, 350);
            this.listBox1.TabIndex = 2;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnSi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSi.BorderRadius = 5;
            this.btnSi.BorderSize = 0;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F);
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.Location = new System.Drawing.Point(624, 493);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(102, 35);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "Sí";
            this.btnSi.TextColor = System.Drawing.Color.White;
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // Pantalla_11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_11_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_11";
            this.Text = "Pantalla_11";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnSi;
		private System.Windows.Forms.ListBox listBox1;
	}
}