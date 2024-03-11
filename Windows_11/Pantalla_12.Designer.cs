namespace Proyecto_simulador.Windows_11
{
    partial class Pantalla_12
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
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "   Latinoamericano",
            "   Español",
            "   Variacion del español",
            "   Albánes",
            "   Aleman ",
            "   Alfabeto",
            "   Bielorruso",
            "   Canarés",
            "   Catalán",
            "   Checo",
            "   Chino (simplificado)",
            "   Chino (tradicional)",
            "   Congo",
            "   Coreano",
            "   Danés",
            "   Filipino",
            "   Gáles",
            "   Griego",
            "   Guaraní",
            "   Hawaiano",
            "   Haya",
            "   Hindi",
            "   Italino",
            "   Itawes",
            "   Japonés",
            "   Jemer",
            "   Lisu",
            "   Lituano",
            "   Lines",
            "   Inglés (EE.UU)",
            "   Inglés (Canadá)",
            "   Ingles (Reino Unido)",
            "   Rumano",
            "   Ruso",
            "   Tailandes",
            "   Vasco",
            "   Vasavi",
            "   Zande"});
            this.listBox1.Location = new System.Drawing.Point(430, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(296, 300);
            this.listBox1.TabIndex = 1;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
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
            this.btnSi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.Location = new System.Drawing.Point(622, 492);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(104, 36);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Sí";
            this.btnSi.TextColor = System.Drawing.Color.White;
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // Pantalla_12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_12_w11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla_12";
            this.Text = "Pantalla_12";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnSi;
		private System.Windows.Forms.ListBox listBox1;
	}
}