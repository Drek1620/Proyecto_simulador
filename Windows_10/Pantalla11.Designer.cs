namespace Proyecto_simulador
{
    partial class Pantalla11
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lst_Teclado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(649, 509);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(139, 35);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Sí";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-15, -15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Arabia Saudí",
            "Bolivia",
            "Bonaire",
            "San Eustaquio y Saba",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Burkina Faso",
            "Burundi",
            "Mayotte",
            "México",
            "Micronesia",
            "Moldova",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Montserrat"});
            this.listBox1.Location = new System.Drawing.Point(207, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(381, 302);
            this.listBox1.TabIndex = 2;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // lst_Teclado
            // 
            this.lst_Teclado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.lst_Teclado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Teclado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lst_Teclado.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lst_Teclado.ForeColor = System.Drawing.Color.White;
            this.lst_Teclado.FormattingEnabled = true;
            this.lst_Teclado.ItemHeight = 22;
            this.lst_Teclado.Items.AddRange(new object[] {
            "Aleman (Alemania)",
            "Aleman (Austriaco)",
            "Aleman (suizo)",
            "Español (Mexico)",
            "Español (España)",
            "Español (Argentina)",
            "Español (Colombia)",
            "Frances (Francia)",
            "Frances (Canada)",
            "Ingles (US)",
            "Ingles (UK)",
            "Ingles(Canada) ",
            "Portugues(Brasil)",
            "Portugues (Portugal)"});
            this.lst_Teclado.Location = new System.Drawing.Point(207, 214);
            this.lst_Teclado.Name = "lst_Teclado";
            this.lst_Teclado.ScrollAlwaysVisible = true;
            this.lst_Teclado.Size = new System.Drawing.Size(381, 286);
            this.lst_Teclado.TabIndex = 3;
            this.lst_Teclado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_Teclado_DrawItem);
            // 
            // Pantalla11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_11;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lst_Teclado);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla11";
            this.Text = "Pantalla11";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lst_Teclado;
    }
}