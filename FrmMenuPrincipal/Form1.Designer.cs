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
            this.lbl_aviones = new System.Windows.Forms.Label();
            this.lbl_pasajeros = new System.Windows.Forms.Label();
            this.lbl_equipaje = new System.Windows.Forms.Label();
            this.cbo_destinosNacionales = new System.Windows.Forms.ComboBox();
            this.dtg_principal = new System.Windows.Forms.DataGridView();
            this.dtg_secundario = new System.Windows.Forms.DataGridView();
            this.dtg_terceario = new System.Windows.Forms.DataGridView();
            this.tmr_fechaYHoraActual = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fechaSistema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_nuevoVuelo = new System.Windows.Forms.Button();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.btn_venderVuelo = new System.Windows.Forms.Button();
            this.cbo_destinosInternacionales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salirMenuPrincipal = new System.Windows.Forms.Button();
            this.lbl_acciones = new System.Windows.Forms.Label();
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aviones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrarEstadisticas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btn_pasajeros.Location = new System.Drawing.Point(238, 37);
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
            this.button3.Location = new System.Drawing.Point(344, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 96);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_aviones
            // 
            this.lbl_aviones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_aviones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_aviones.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_aviones.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_aviones.Location = new System.Drawing.Point(132, 10);
            this.lbl_aviones.Name = "lbl_aviones";
            this.lbl_aviones.Size = new System.Drawing.Size(100, 24);
            this.lbl_aviones.TabIndex = 3;
            this.lbl_aviones.Text = "AVIONES";
            this.lbl_aviones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pasajeros
            // 
            this.lbl_pasajeros.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_pasajeros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pasajeros.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pasajeros.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_pasajeros.Location = new System.Drawing.Point(238, 10);
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
            this.lbl_equipaje.Location = new System.Drawing.Point(344, 9);
            this.lbl_equipaje.Name = "lbl_equipaje";
            this.lbl_equipaje.Size = new System.Drawing.Size(100, 24);
            this.lbl_equipaje.TabIndex = 5;
            this.lbl_equipaje.Text = "EQUIPAJE";
            this.lbl_equipaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_destinosNacionales
            // 
            this.cbo_destinosNacionales.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_destinosNacionales.FormattingEnabled = true;
            this.cbo_destinosNacionales.Location = new System.Drawing.Point(132, 145);
            this.cbo_destinosNacionales.Name = "cbo_destinosNacionales";
            this.cbo_destinosNacionales.Size = new System.Drawing.Size(143, 29);
            this.cbo_destinosNacionales.TabIndex = 6;
            this.cbo_destinosNacionales.Text = "Nacionales";
            // 
            // dtg_principal
            // 
            this.dtg_principal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtg_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_principal.GridColor = System.Drawing.Color.White;
            this.dtg_principal.Location = new System.Drawing.Point(26, 183);
            this.dtg_principal.Name = "dtg_principal";
            this.dtg_principal.RowHeadersWidth = 51;
            this.dtg_principal.RowTemplate.Height = 29;
            this.dtg_principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_principal.Size = new System.Drawing.Size(533, 293);
            this.dtg_principal.TabIndex = 7;
            this.dtg_principal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_principal_CellContentClick);
            // 
            // dtg_secundario
            // 
            this.dtg_secundario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_secundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_secundario.Location = new System.Drawing.Point(565, 183);
            this.dtg_secundario.Name = "dtg_secundario";
            this.dtg_secundario.RowHeadersWidth = 51;
            this.dtg_secundario.RowTemplate.Height = 29;
            this.dtg_secundario.Size = new System.Drawing.Size(399, 293);
            this.dtg_secundario.TabIndex = 8;
            // 
            // dtg_terceario
            // 
            this.dtg_terceario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_terceario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_terceario.Location = new System.Drawing.Point(565, 482);
            this.dtg_terceario.Name = "dtg_terceario";
            this.dtg_terceario.RowHeadersWidth = 51;
            this.dtg_terceario.RowTemplate.Height = 29;
            this.dtg_terceario.Size = new System.Drawing.Size(399, 146);
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
            this.lbl_usuario.Location = new System.Drawing.Point(706, 10);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(258, 36);
            this.lbl_usuario.TabIndex = 12;
            this.lbl_usuario.Text = "2";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_nuevoVuelo
            // 
            this.btn_nuevoVuelo.Location = new System.Drawing.Point(313, 568);
            this.btn_nuevoVuelo.Name = "btn_nuevoVuelo";
            this.btn_nuevoVuelo.Size = new System.Drawing.Size(118, 60);
            this.btn_nuevoVuelo.TabIndex = 13;
            this.btn_nuevoVuelo.Text = "Agregar Vuelo";
            this.btn_nuevoVuelo.UseVisualStyleBackColor = true;
            this.btn_nuevoVuelo.Click += new System.EventHandler(this.btn_nuevoVuelo_Click);
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(437, 568);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(122, 60);
            this.btn_agregarCliente.TabIndex = 14;
            this.btn_agregarCliente.Text = "Agregar Cliente";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // btn_venderVuelo
            // 
            this.btn_venderVuelo.Enabled = false;
            this.btn_venderVuelo.Location = new System.Drawing.Point(313, 482);
            this.btn_venderVuelo.Name = "btn_venderVuelo";
            this.btn_venderVuelo.Size = new System.Drawing.Size(246, 56);
            this.btn_venderVuelo.TabIndex = 15;
            this.btn_venderVuelo.Text = "Subir al Avion";
            this.btn_venderVuelo.UseVisualStyleBackColor = true;
            this.btn_venderVuelo.Click += new System.EventHandler(this.btn_venderVuelo_Click);
            // 
            // cbo_destinosInternacionales
            // 
            this.cbo_destinosInternacionales.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_destinosInternacionales.FormattingEnabled = true;
            this.cbo_destinosInternacionales.Location = new System.Drawing.Point(288, 145);
            this.cbo_destinosInternacionales.Name = "cbo_destinosInternacionales";
            this.cbo_destinosInternacionales.Size = new System.Drawing.Size(143, 29);
            this.cbo_destinosInternacionales.TabIndex = 16;
            this.cbo_destinosInternacionales.Text = "Internacionales";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(26, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "DESTINOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salirMenuPrincipal
            // 
            this.btn_salirMenuPrincipal.Location = new System.Drawing.Point(823, 634);
            this.btn_salirMenuPrincipal.Name = "btn_salirMenuPrincipal";
            this.btn_salirMenuPrincipal.Size = new System.Drawing.Size(141, 41);
            this.btn_salirMenuPrincipal.TabIndex = 18;
            this.btn_salirMenuPrincipal.Text = " Salir";
            this.btn_salirMenuPrincipal.UseVisualStyleBackColor = true;
            this.btn_salirMenuPrincipal.Click += new System.EventHandler(this.btn_salirMenuPrincipal_Click);
            // 
            // lbl_acciones
            // 
            this.lbl_acciones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_acciones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_acciones.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_acciones.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_acciones.Location = new System.Drawing.Point(320, 541);
            this.lbl_acciones.Name = "lbl_acciones";
            this.lbl_acciones.Size = new System.Drawing.Size(100, 24);
            this.lbl_acciones.TabIndex = 21;
            this.lbl_acciones.Text = "Acciones";
            this.lbl_acciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_busqueda.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_busqueda.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_busqueda.Location = new System.Drawing.Point(26, 482);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(100, 24);
            this.lbl_busqueda.TabIndex = 22;
            this.lbl_busqueda.Text = "Busqueda";
            this.lbl_busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(26, 511);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Avion";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(99, 511);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vuelo";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(173, 511);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 24);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pasajero";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 26;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(26, 574);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(232, 37);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_aviones
            // 
            this.btn_aviones.BackColor = System.Drawing.Color.Transparent;
            this.btn_aviones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aviones.BackgroundImage")));
            this.btn_aviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aviones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_aviones.Location = new System.Drawing.Point(132, 37);
            this.btn_aviones.Name = "btn_aviones";
            this.btn_aviones.Size = new System.Drawing.Size(100, 96);
            this.btn_aviones.TabIndex = 28;
            this.btn_aviones.UseVisualStyleBackColor = false;
            this.btn_aviones.Click += new System.EventHandler(this.btn_aviones_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(26, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "VUELOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mostrarEstadisticas
            // 
            this.btn_mostrarEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrarEstadisticas.BackgroundImage = global::FrmMenuPrincipal.Properties.Resources.estadisticas;
            this.btn_mostrarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mostrarEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mostrarEstadisticas.Location = new System.Drawing.Point(450, 37);
            this.btn_mostrarEstadisticas.Name = "btn_mostrarEstadisticas";
            this.btn_mostrarEstadisticas.Size = new System.Drawing.Size(100, 96);
            this.btn_mostrarEstadisticas.TabIndex = 30;
            this.btn_mostrarEstadisticas.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(450, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Estadisticas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 687);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrarEstadisticas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aviones);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_busqueda);
            this.Controls.Add(this.lbl_acciones);
            this.Controls.Add(this.btn_salirMenuPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_destinosInternacionales);
            this.Controls.Add(this.btn_venderVuelo);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.btn_nuevoVuelo);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_fechaSistema);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.dtg_terceario);
            this.Controls.Add(this.dtg_secundario);
            this.Controls.Add(this.dtg_principal);
            this.Controls.Add(this.cbo_destinosNacionales);
            this.Controls.Add(this.lbl_equipaje);
            this.Controls.Add(this.lbl_pasajeros);
            this.Controls.Add(this.lbl_aviones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_pasajeros);
            this.Controls.Add(this.btn_vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_menuPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_menuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_secundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_terceario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vuelos;
        private System.Windows.Forms.Button btn_pasajeros;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_aviones;
        private System.Windows.Forms.Label lbl_pasajeros;
        private System.Windows.Forms.Label lbl_equipaje;
        private System.Windows.Forms.ComboBox cbo_destinosNacionales;
        private System.Windows.Forms.DataGridView dtg_principal;
        private System.Windows.Forms.DataGridView dtg_secundario;
        private System.Windows.Forms.DataGridView dtg_terceario;
        private System.Windows.Forms.Timer tmr_fechaYHoraActual;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fechaSistema;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_nuevoVuelo;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Button btn_venderVuelo;
        private System.Windows.Forms.ComboBox cbo_destinosInternacionales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salirMenuPrincipal;
        private System.Windows.Forms.Label lbl_acciones;
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aviones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mostrarEstadisticas;
        private System.Windows.Forms.Label label3;
    }
}
