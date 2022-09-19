namespace FrmMenuPrincipal
{
    partial class Frm_menuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menuPrincipal));
            this.btn_vuelos = new System.Windows.Forms.Button();
            this.btn_pasajeros = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_vuelos = new System.Windows.Forms.Label();
            this.lbl_pasajeros = new System.Windows.Forms.Label();
            this.lbl_equipaje = new System.Windows.Forms.Label();
            this.cbo_destinos = new System.Windows.Forms.ComboBox();
            this.dtg_principal = new System.Windows.Forms.DataGridView();
            this.dtg_secundario = new System.Windows.Forms.DataGridView();
            this.dtg_terceario = new System.Windows.Forms.DataGridView();
            this.tmr_fechaYHoraActual = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fechaSistema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_secundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_terceario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vuelos
            // 
            this.btn_vuelos.BackColor = System.Drawing.Color.Transparent;
            this.btn_vuelos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vuelos.BackgroundImage")));
            this.btn_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vuelos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vuelos.Location = new System.Drawing.Point(26, 37);
            this.btn_vuelos.Name = "btn_vuelos";
            this.btn_vuelos.Size = new System.Drawing.Size(100, 96);
            this.btn_vuelos.TabIndex = 0;
            this.btn_vuelos.UseVisualStyleBackColor = false;
            this.btn_vuelos.Click += new System.EventHandler(this.btn_vuelos_Click);
            // 
            // btn_pasajeros
            // 
            this.btn_pasajeros.BackColor = System.Drawing.Color.Transparent;
            this.btn_pasajeros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pasajeros.BackgroundImage")));
            this.btn_pasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pasajeros.Location = new System.Drawing.Point(132, 37);
            this.btn_pasajeros.Name = "btn_pasajeros";
            this.btn_pasajeros.Size = new System.Drawing.Size(100, 96);
            this.btn_pasajeros.TabIndex = 1;
            this.btn_pasajeros.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::FrmMenuPrincipal.Properties.Resources.equipaje;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(238, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 96);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_vuelos
            // 
            this.lbl_vuelos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_vuelos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_vuelos.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelos.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_vuelos.Location = new System.Drawing.Point(26, 10);
            this.lbl_vuelos.Name = "lbl_vuelos";
            this.lbl_vuelos.Size = new System.Drawing.Size(100, 24);
            this.lbl_vuelos.TabIndex = 3;
            this.lbl_vuelos.Text = "VUELOS";
            this.lbl_vuelos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pasajeros
            // 
            this.lbl_pasajeros.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_pasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pasajeros.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pasajeros.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_pasajeros.Location = new System.Drawing.Point(132, 10);
            this.lbl_pasajeros.Name = "lbl_pasajeros";
            this.lbl_pasajeros.Size = new System.Drawing.Size(100, 24);
            this.lbl_pasajeros.TabIndex = 4;
            this.lbl_pasajeros.Text = "PASAJEROS";
            this.lbl_pasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_equipaje
            // 
            this.lbl_equipaje.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_equipaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_equipaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_equipaje.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_equipaje.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_equipaje.Location = new System.Drawing.Point(238, 10);
            this.lbl_equipaje.Name = "lbl_equipaje";
            this.lbl_equipaje.Size = new System.Drawing.Size(100, 24);
            this.lbl_equipaje.TabIndex = 5;
            this.lbl_equipaje.Text = "EQUIPAJE";
            this.lbl_equipaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_destinos
            // 
            this.cbo_destinos.Font = new System.Drawing.Font("Simpsonfont", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_destinos.FormattingEnabled = true;
            this.cbo_destinos.Location = new System.Drawing.Point(354, 37);
            this.cbo_destinos.Name = "cbo_destinos";
            this.cbo_destinos.Size = new System.Drawing.Size(151, 33);
            this.cbo_destinos.TabIndex = 6;
            this.cbo_destinos.Text = "Destinos";
            // 
            // dtg_principal
            // 
            this.dtg_principal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_principal.GridColor = System.Drawing.Color.White;
            this.dtg_principal.Location = new System.Drawing.Point(26, 139);
            this.dtg_principal.Name = "dtg_principal";
            this.dtg_principal.RowHeadersWidth = 51;
            this.dtg_principal.RowTemplate.Height = 29;
            this.dtg_principal.Size = new System.Drawing.Size(533, 316);
            this.dtg_principal.TabIndex = 7;
            // 
            // dtg_secundario
            // 
            this.dtg_secundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_secundario.Location = new System.Drawing.Point(565, 139);
            this.dtg_secundario.Name = "dtg_secundario";
            this.dtg_secundario.RowHeadersWidth = 51;
            this.dtg_secundario.RowTemplate.Height = 29;
            this.dtg_secundario.Size = new System.Drawing.Size(399, 247);
            this.dtg_secundario.TabIndex = 8;
            // 
            // dtg_terceario
            // 
            this.dtg_terceario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_terceario.Location = new System.Drawing.Point(565, 392);
            this.dtg_terceario.Name = "dtg_terceario";
            this.dtg_terceario.RowHeadersWidth = 51;
            this.dtg_terceario.RowTemplate.Height = 29;
            this.dtg_terceario.Size = new System.Drawing.Size(399, 215);
            this.dtg_terceario.TabIndex = 9;
            // 
            // tmr_fechaYHoraActual
            // 
            this.tmr_fechaYHoraActual.Enabled = true;
            this.tmr_fechaYHoraActual.Interval = 1;
            this.tmr_fechaYHoraActual.Tick += new System.EventHandler(this.tmr_fechaYHoraActual_Tick);
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("b Blue Vanilla", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hora.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_hora.Location = new System.Drawing.Point(778, 86);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(186, 47);
            this.lbl_hora.TabIndex = 10;
            this.lbl_hora.Text = "2";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_fechaSistema
            // 
            this.lbl_fechaSistema.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaSistema.Font = new System.Drawing.Font("b Blue Vanilla", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaSistema.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_fechaSistema.Location = new System.Drawing.Point(628, 57);
            this.lbl_fechaSistema.Name = "lbl_fechaSistema";
            this.lbl_fechaSistema.Size = new System.Drawing.Size(336, 29);
            this.lbl_fechaSistema.TabIndex = 11;
            this.lbl_fechaSistema.Text = "2";
            this.lbl_fechaSistema.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("b Blue Vanilla", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_usuario.Location = new System.Drawing.Point(778, 10);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(186, 36);
            this.lbl_usuario.TabIndex = 12;
            this.lbl_usuario.Text = "2";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(995, 619);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_fechaSistema);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.dtg_terceario);
            this.Controls.Add(this.dtg_secundario);
            this.Controls.Add(this.dtg_principal);
            this.Controls.Add(this.cbo_destinos);
            this.Controls.Add(this.lbl_equipaje);
            this.Controls.Add(this.lbl_pasajeros);
            this.Controls.Add(this.lbl_vuelos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_pasajeros);
            this.Controls.Add(this.btn_vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_menuPrincipal";
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_secundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_terceario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vuelos;
        private System.Windows.Forms.Button btn_pasajeros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_vuelos;
        private System.Windows.Forms.Label lbl_pasajeros;
        private System.Windows.Forms.Label lbl_equipaje;
        private System.Windows.Forms.ComboBox cbo_destinos;
        private System.Windows.Forms.DataGridView dtg_principal;
        private System.Windows.Forms.DataGridView dtg_secundario;
        private System.Windows.Forms.DataGridView dtg_terceario;
        private System.Windows.Forms.Timer tmr_fechaYHoraActual;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fechaSistema;
        private System.Windows.Forms.Label lbl_usuario;
    }
}
