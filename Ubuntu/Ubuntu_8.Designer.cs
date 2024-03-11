namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_8
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prb_Reinicio = new Proyecto_simulador.RJProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prb_Reinicio
            // 
            this.prb_Reinicio.ChannelColor = System.Drawing.Color.White;
            this.prb_Reinicio.ChannelHeight = 15;
            this.prb_Reinicio.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.prb_Reinicio.ForeColor = System.Drawing.Color.White;
            this.prb_Reinicio.Location = new System.Drawing.Point(140, 613);
            this.prb_Reinicio.Name = "prb_Reinicio";
            this.prb_Reinicio.ShowMaximun = false;
            this.prb_Reinicio.ShowValue = Proyecto_simulador.TextPosition.None;
            this.prb_Reinicio.Size = new System.Drawing.Size(651, 11);
            this.prb_Reinicio.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.prb_Reinicio.SliderHeight = 20;
            this.prb_Reinicio.SymbolAfter = "";
            this.prb_Reinicio.SymbolBefore = "";
            this.prb_Reinicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(155, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instalando el sistema";
            // 
            // Ubuntu_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_8;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prb_Reinicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_8";
            this.Text = "Ubuntu_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private RJProgressBar prb_Reinicio;
        private System.Windows.Forms.Label label1;
    }
}