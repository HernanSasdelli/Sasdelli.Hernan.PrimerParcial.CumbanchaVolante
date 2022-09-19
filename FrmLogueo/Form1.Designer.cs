namespace FrmLogueo
{
    partial class FrmLogueo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogueo));
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_errorIngreso = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(63, 490);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.PlaceholderText = "Ingresar Contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(251, 27);
            this.tb_contraseña.TabIndex = 3;
            this.tb_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_contraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_contraseña_MouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Simpsonfont", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(205, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BotonLogueoSalir);
            // 
            // lbl_errorIngreso
            // 
            this.lbl_errorIngreso.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorIngreso.Location = new System.Drawing.Point(63, 537);
            this.lbl_errorIngreso.MinimumSize = new System.Drawing.Size(0, 20);
            this.lbl_errorIngreso.Name = "lbl_errorIngreso";
            this.lbl_errorIngreso.Size = new System.Drawing.Size(251, 30);
            this.lbl_errorIngreso.TabIndex = 7;
            this.lbl_errorIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(63, 457);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PlaceholderText = "Ingresar Usuario";
            this.tb_usuario.Size = new System.Drawing.Size(251, 27);
            this.tb_usuario.TabIndex = 8;
            this.tb_usuario.Tag = "";
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_usuario_MouseClick);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(37, 593);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(147, 48);
            this.btn_ingresar.TabIndex = 9;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // FrmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmLogueo.Properties.Resources.PantallaLogueo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 671);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.lbl_errorIngreso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_contraseña);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_errorIngreso;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Button btn_ingresar;
    }
}
