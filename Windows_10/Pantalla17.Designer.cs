namespace Proyecto_simulador
{
    partial class Pantalla17
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbx_num = new System.Windows.Forms.CheckBox();
            this.txtPin = new CustomControls.RJControls.RJTextBox();
            this.txtPin2 = new CustomControls.RJControls.RJTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.Location = new System.Drawing.Point(241, 397);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(158, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbx_num
            // 
            this.cbx_num.AutoSize = true;
            this.cbx_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbx_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbx_num.Location = new System.Drawing.Point(288, 348);
            this.cbx_num.Name = "cbx_num";
            this.cbx_num.Size = new System.Drawing.Size(173, 21);
            this.cbx_num.TabIndex = 4;
            this.cbx_num.TabStop = false;
            this.cbx_num.Text = "Incluir letras y simbolos";
            this.cbx_num.UseVisualStyleBackColor = false;
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.SystemColors.Window;
            this.txtPin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPin.BorderRadius = 0;
            this.txtPin.BorderSize = 1;
            this.txtPin.Font = new System.Drawing.Font("Avrile Sans", 9F);
            this.txtPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtPin.Location = new System.Drawing.Point(288, 275);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPin.Multiline = false;
            this.txtPin.Name = "txtPin";
            this.txtPin.Padding = new System.Windows.Forms.Padding(5, 5, 10, 6);
            this.txtPin.PasswordChar = true;
            this.txtPin.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPin.PlaceholderText = "Nuevo PIN";
            this.txtPin.Size = new System.Drawing.Size(233, 29);
            this.txtPin.TabIndex = 6;
            this.txtPin.Texts = "";
            this.txtPin.UnderlinedStyle = false;
            // 
            // txtPin2
            // 
            this.txtPin2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPin2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPin2.BorderRadius = 0;
            this.txtPin2.BorderSize = 1;
            this.txtPin2.Font = new System.Drawing.Font("Avrile Sans", 9F);
            this.txtPin2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtPin2.Location = new System.Drawing.Point(288, 311);
            this.txtPin2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPin2.Multiline = false;
            this.txtPin2.Name = "txtPin2";
            this.txtPin2.Padding = new System.Windows.Forms.Padding(5, 5, 10, 6);
            this.txtPin2.PasswordChar = true;
            this.txtPin2.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.txtPin2.PlaceholderText = "Confirmar PIN";
            this.txtPin2.Size = new System.Drawing.Size(233, 29);
            this.txtPin2.TabIndex = 7;
            this.txtPin2.Texts = "";
            this.txtPin2.UnderlinedStyle = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.Location = new System.Drawing.Point(402, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(366, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Pantalla17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_17;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtPin2);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.cbx_num);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla17";
            this.Text = "Pantalla17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox cbx_num;
        private CustomControls.RJControls.RJTextBox txtPin;
        private CustomControls.RJControls.RJTextBox txtPin2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}