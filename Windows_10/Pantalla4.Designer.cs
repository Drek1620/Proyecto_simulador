namespace Proyecto_simulador
{
    partial class Pantalla4
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
            this.lbl_Win_10 = new System.Windows.Forms.Label();
            this.lbl_Win_Ed = new System.Windows.Forms.Label();
            this.lbl_Win_HomSiLe = new System.Windows.Forms.Label();
            this.lbl_Win_Home = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Tai Le", 7F);
            this.btnSiguiente.Location = new System.Drawing.Point(570, 423);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(62, 21);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lbl_Win_10
            // 
            this.lbl_Win_10.AutoSize = true;
            this.lbl_Win_10.BackColor = System.Drawing.Color.White;
            this.lbl_Win_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Win_10.Location = new System.Drawing.Point(527, 230);
            this.lbl_Win_10.Name = "lbl_Win_10";
            this.lbl_Win_10.Size = new System.Drawing.Size(0, 13);
            this.lbl_Win_10.TabIndex = 2;
            this.lbl_Win_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Win_Ed
            // 
            this.lbl_Win_Ed.AutoSize = true;
            this.lbl_Win_Ed.BackColor = System.Drawing.Color.White;
            this.lbl_Win_Ed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Win_Ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Win_Ed.Location = new System.Drawing.Point(527, 215);
            this.lbl_Win_Ed.Name = "lbl_Win_Ed";
            this.lbl_Win_Ed.Size = new System.Drawing.Size(0, 13);
            this.lbl_Win_Ed.TabIndex = 3;
            this.lbl_Win_Ed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Win_HomSiLe
            // 
            this.lbl_Win_HomSiLe.AutoSize = true;
            this.lbl_Win_HomSiLe.BackColor = System.Drawing.Color.White;
            this.lbl_Win_HomSiLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Win_HomSiLe.Location = new System.Drawing.Point(527, 201);
            this.lbl_Win_HomSiLe.Name = "lbl_Win_HomSiLe";
            this.lbl_Win_HomSiLe.Size = new System.Drawing.Size(0, 13);
            this.lbl_Win_HomSiLe.TabIndex = 4;
            this.lbl_Win_HomSiLe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Win_Home
            // 
            this.lbl_Win_Home.AutoSize = true;
            this.lbl_Win_Home.BackColor = System.Drawing.Color.White;
            this.lbl_Win_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_Win_Home.Location = new System.Drawing.Point(527, 187);
            this.lbl_Win_Home.Name = "lbl_Win_Home";
            this.lbl_Win_Home.Size = new System.Drawing.Size(0, 13);
            this.lbl_Win_Home.TabIndex = 5;
            this.lbl_Win_Home.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Windows 10 Home                                                           x64 ",
            "Windows 10 Home Singles Language                              x64 ",
            "Windows 10 Education                                                     x64 ",
            "Windows 10 Pro                                                                x64" +
                " "});
            this.listBox1.Location = new System.Drawing.Point(190, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 78);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.White;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDesc.Location = new System.Drawing.Point(188, 304);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(204, 58);
            this.lblDesc.TabIndex = 11;
            // 
            // Pantalla4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_simulador.Properties.Resources.Imagen_4;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lbl_Win_Ed);
            this.Controls.Add(this.lbl_Win_Home);
            this.Controls.Add(this.lbl_Win_HomSiLe);
            this.Controls.Add(this.lbl_Win_10);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pantalla4";
            this.Text = "Pantalla4";
            this.Load += new System.EventHandler(this.Pantalla4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lbl_Win_10;
        private System.Windows.Forms.Label lbl_Win_Ed;
        private System.Windows.Forms.Label lbl_Win_HomSiLe;
        private System.Windows.Forms.Label lbl_Win_Home;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblDesc;
    }
}