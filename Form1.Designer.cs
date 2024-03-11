namespace Proyecto_simulador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubuntuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.linuxToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estacionesToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // estacionesToolStripMenuItem
            // 
            this.estacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windows10ToolStripMenuItem,
            this.windows11ToolStripMenuItem});
            this.estacionesToolStripMenuItem.Name = "estacionesToolStripMenuItem";
            this.estacionesToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.estacionesToolStripMenuItem.Text = "Estaciones";
            // 
            // windows10ToolStripMenuItem
            // 
            this.windows10ToolStripMenuItem.Name = "windows10ToolStripMenuItem";
            this.windows10ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.windows10ToolStripMenuItem.Text = "Windows 10";
            this.windows10ToolStripMenuItem.Click += new System.EventHandler(this.windows10ToolStripMenuItem_Click);
            // 
            // windows11ToolStripMenuItem
            // 
            this.windows11ToolStripMenuItem.Name = "windows11ToolStripMenuItem";
            this.windows11ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.windows11ToolStripMenuItem.Text = "Windows 11";
            this.windows11ToolStripMenuItem.Click += new System.EventHandler(this.windows11ToolStripMenuItem_Click);
            // 
            // linuxToolStripMenuItem
            // 
            this.linuxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estaciónToolStripMenuItem});
            this.linuxToolStripMenuItem.Name = "linuxToolStripMenuItem";
            this.linuxToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.linuxToolStripMenuItem.Text = "Linux";
            // 
            // estaciónToolStripMenuItem
            // 
            this.estaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubuntuToolStripMenuItem});
            this.estaciónToolStripMenuItem.Name = "estaciónToolStripMenuItem";
            this.estaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.estaciónToolStripMenuItem.Text = "Estaciones";
            // 
            // ubuntuToolStripMenuItem
            // 
            this.ubuntuToolStripMenuItem.Name = "ubuntuToolStripMenuItem";
            this.ubuntuToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.ubuntuToolStripMenuItem.Text = "Ubuntu";
            this.ubuntuToolStripMenuItem.Click += new System.EventHandler(this.ubuntuToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Fondo_proyecto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 421);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simulador de Instaladores de Sistemas Operativos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem estacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubuntuToolStripMenuItem;
    }
}

