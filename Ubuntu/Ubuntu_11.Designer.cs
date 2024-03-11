namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_11
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
            this.pan_Inicio = new System.Windows.Forms.Panel();
            this.pan_Menu = new System.Windows.Forms.Panel();
            this.pan_Apagar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Inicio
            // 
            this.pan_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.pan_Inicio.Location = new System.Drawing.Point(832, 0);
            this.pan_Inicio.Name = "pan_Inicio";
            this.pan_Inicio.Size = new System.Drawing.Size(101, 26);
            this.pan_Inicio.TabIndex = 0;
            this.pan_Inicio.Click += new System.EventHandler(this.pan_Inicio_Click);
            // 
            // pan_Menu
            // 
            this.pan_Menu.BackColor = System.Drawing.Color.Transparent;
            this.pan_Menu.BackgroundImage = global::Proyecto_simulador.Properties.Resources.VirtualBox_Ubuntu_09_04_2023_19_35_23__2_;
            this.pan_Menu.Controls.Add(this.pan_Apagar);
            this.pan_Menu.Location = new System.Drawing.Point(602, -2);
            this.pan_Menu.Name = "pan_Menu";
            this.pan_Menu.Size = new System.Drawing.Size(331, 286);
            this.pan_Menu.TabIndex = 1;
            this.pan_Menu.Visible = false;
            // 
            // pan_Apagar
            // 
            this.pan_Apagar.Location = new System.Drawing.Point(13, 245);
            this.pan_Apagar.Name = "pan_Apagar";
            this.pan_Apagar.Size = new System.Drawing.Size(298, 28);
            this.pan_Apagar.TabIndex = 0;
            this.pan_Apagar.Visible = false;
            this.pan_Apagar.Click += new System.EventHandler(this.pan_Apagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Presione la esquina superior derecha y el simbolo de apagar\r\n para terminar la si" +
    "mulacion";
            // 
            // Ubuntu_11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_11;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_Inicio);
            this.Controls.Add(this.pan_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_11";
            this.Text = "Ubuntu_11";
            this.pan_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_Inicio;
        private System.Windows.Forms.Panel pan_Menu;
        private System.Windows.Forms.Panel pan_Apagar;
        private System.Windows.Forms.Label label1;
    }
}