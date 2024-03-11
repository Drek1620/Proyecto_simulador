namespace Proyecto_simulador
{
    partial class Pantalla16
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
            this.panPin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panPin
            // 
            this.panPin.BackColor = System.Drawing.Color.Transparent;
            this.panPin.Location = new System.Drawing.Point(648, 510);
            this.panPin.Name = "panPin";
            this.panPin.Size = new System.Drawing.Size(138, 35);
            this.panPin.TabIndex = 0;
            this.panPin.Click += new System.EventHandler(this.panPin_Click);
            // 
            // Pantalla16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_16;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panPin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla16";
            this.Text = "Pantalla16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPin;
    }
}