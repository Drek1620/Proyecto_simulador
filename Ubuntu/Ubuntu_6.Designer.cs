namespace Proyecto_simulador.Ubuntu
{
    partial class Ubuntu_6
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
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rButton1 = new Proyecto_simulador.RButton();
            this.btnInstalar = new Proyecto_simulador.RButton();
            this.SuspendLayout();
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(170)))), ((int)(((byte)(144)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(170)))), ((int)(((byte)(144)))));
            this.rjTextBox1.BorderRadius = 5;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.Black;
            this.rjTextBox1.Location = new System.Drawing.Point(86, 521);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(761, 35);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.TabStop = false;
            this.rjTextBox1.Texts = "Durango";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.White;
            this.rButton1.BackgroundColor = System.Drawing.Color.White;
            this.rButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.rButton1.BorderRadius = 5;
            this.rButton1.BorderSize = 1;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.Font = new System.Drawing.Font("Ubuntu", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.rButton1.Location = new System.Drawing.Point(620, 563);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(112, 32);
            this.rButton1.TabIndex = 6;
            this.rButton1.Text = "Atrás";
            this.rButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // btnInstalar
            // 
            this.btnInstalar.BackColor = System.Drawing.Color.White;
            this.btnInstalar.BackgroundColor = System.Drawing.Color.White;
            this.btnInstalar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnInstalar.BorderRadius = 5;
            this.btnInstalar.BorderSize = 1;
            this.btnInstalar.FlatAppearance.BorderSize = 0;
            this.btnInstalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalar.Font = new System.Drawing.Font("Ubuntu", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.Location = new System.Drawing.Point(735, 563);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(112, 32);
            this.btnInstalar.TabIndex = 5;
            this.btnInstalar.Text = "Continuar";
            this.btnInstalar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(56)))), ((int)(((byte)(52)))));
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // Ubuntu_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Screen_6;
            this.ClientSize = new System.Drawing.Size(934, 701);
            this.Controls.Add(this.rButton1);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.rjTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ubuntu_6";
            this.Text = "Ubuntu_6";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private RButton rButton1;
        private RButton btnInstalar;
    }
}