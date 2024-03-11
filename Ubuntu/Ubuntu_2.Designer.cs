namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_2
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
            this.btnProbar = new Proyecto_simulador.RButton();
            this.btnInstalar = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Asturianu",
            "Bahasa Indonesia",
            "Bosanski",
            "Català",
            "Čeština",
            "Cymraeg",
            "Dansk",
            "Deutsch",
            "Eesti",
            "English",
            "Español",
            "Esperanto",
            "Euskara",
            "Français",
            "Gaeilge",
            "Galego",
            "Hrvatski",
            "Íslenska",
            "Italiano",
            "Kurdî",
            "Latviski",
            "Lietuviškai",
            "Magyar",
            "Nederlands",
            "No localization (UTF-8)",
            "Norsk bokmål",
            "Norsk nynorsk",
            "Occitan",
            "Polski",
            "Português",
            "Português do Brasil",
            "Română",
            "Sámegillii"});
            this.listBox1.Location = new System.Drawing.Point(89, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(149, 376);
            this.listBox1.TabIndex = 4;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnProbar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnProbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnProbar.BorderRadius = 5;
            this.btnProbar.BorderSize = 1;
            this.btnProbar.FlatAppearance.BorderSize = 0;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnProbar.Location = new System.Drawing.Point(301, 376);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(169, 31);
            this.btnProbar.TabIndex = 1;
            this.btnProbar.Text = "Probar Ubuntu";
            this.btnProbar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnInstalar
            // 
            this.btnInstalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnInstalar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnInstalar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnInstalar.BorderRadius = 5;
            this.btnInstalar.BorderSize = 1;
            this.btnInstalar.FlatAppearance.BorderSize = 0;
            this.btnInstalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.Location = new System.Drawing.Point(597, 376);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(169, 31);
            this.btnInstalar.TabIndex = 0;
            this.btnInstalar.Text = "Instalar Ubuntu";
            this.btnInstalar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Ubuntu_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_2;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.btnInstalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_2";
            this.Text = "Ubuntu_2";
            this.ResumeLayout(false);

        }

        #endregion

        private RButton btnInstalar;
        private RButton btnProbar;
        private System.Windows.Forms.ListBox listBox1;
    }
}