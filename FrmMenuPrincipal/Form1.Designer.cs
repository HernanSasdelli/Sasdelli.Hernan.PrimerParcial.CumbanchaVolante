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
            this.btn_estadisticas = new System.Windows.Forms.Button();
            this.lbl_aviones = new System.Windows.Forms.Label();
            this.lbl_clientes = new System.Windows.Forms.Label();
            this.lbl_cambioPrecio = new System.Windows.Forms.Label();
            this.dtg_principal = new System.Windows.Forms.DataGridView();
            this.tmr_fechaYHoraActual = new System.Windows.Forms.Timer(this.components);
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fechaSistema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_nuevoVuelo = new System.Windows.Forms.Button();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.btn_venderVuelo = new System.Windows.Forms.Button();
            this.btn_salirMenuPrincipal = new System.Windows.Forms.Button();
            this.lbl_acciones = new System.Windows.Forms.Label();
            this.btn_aviones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrarEstadisticas = new System.Windows.Forms.Button();
            this.lbl_estadisticas = new System.Windows.Forms.Label();
            this.lbl_ocupacionBodega = new System.Windows.Forms.Label();
            this.lbl_mostrarOcupacionBodega = new System.Windows.Forms.Label();
            this.lbl_mostrarOcupacionCabina = new System.Windows.Forms.Label();
            this.lbl_ocupacionCabina = new System.Windows.Forms.Label();
            this.dtg_secundario = new System.Windows.Forms.DataGridView();
            this.btn_vuelosHistorico = new System.Windows.Forms.Button();
            this.lbl_vuelosHistorico = new System.Windows.Forms.Label();
            this.btn_facturas = new System.Windows.Forms.Button();
            this.lbl_facturas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_secundario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vuelos
            // 
            this.btn_vuelos.BackColor = System.Drawing.Color.Transparent;
            this.btn_vuelos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vuelos.BackgroundImage")));
            this.btn_vuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vuelos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vuelos.Location = new System.Drawing.Point(26, 57);
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
            this.btn_pasajeros.Location = new System.Drawing.Point(238, 57);
            this.btn_pasajeros.Name = "btn_pasajeros";
            this.btn_pasajeros.Size = new System.Drawing.Size(100, 96);
            this.btn_pasajeros.TabIndex = 1;
            this.btn_pasajeros.UseVisualStyleBackColor = false;
            this.btn_pasajeros.Click += new System.EventHandler(this.btn_pasajeros_Click);
            // 
            // btn_estadisticas
            // 
            this.btn_estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_estadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_estadisticas.BackgroundImage")));
            this.btn_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estadisticas.Location = new System.Drawing.Point(344, 57);
            this.btn_estadisticas.Name = "btn_estadisticas";
            this.btn_estadisticas.Size = new System.Drawing.Size(100, 96);
            this.btn_estadisticas.TabIndex = 2;
            this.btn_estadisticas.UseVisualStyleBackColor = false;
            this.btn_estadisticas.Click += new System.EventHandler(this.btn_estadisticas_Click);
            // 
            // lbl_aviones
            // 
            this.lbl_aviones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_aviones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_aviones.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_aviones.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_aviones.Location = new System.Drawing.Point(132, 30);
            this.lbl_aviones.Name = "lbl_aviones";
            this.lbl_aviones.Size = new System.Drawing.Size(100, 24);
            this.lbl_aviones.TabIndex = 3;
            this.lbl_aviones.Text = "AVIONES";
            this.lbl_aviones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clientes
            // 
            this.lbl_clientes.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_clientes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_clientes.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clientes.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_clientes.Location = new System.Drawing.Point(238, 30);
            this.lbl_clientes.Name = "lbl_clientes";
            this.lbl_clientes.Size = new System.Drawing.Size(100, 24);
            this.lbl_clientes.TabIndex = 4;
            this.lbl_clientes.Text = "CLIENTES";
            this.lbl_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cambioPrecio
            // 
            this.lbl_cambioPrecio.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_cambioPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cambioPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cambioPrecio.Font = new System.Drawing.Font("Simpsonfont", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cambioPrecio.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_cambioPrecio.Location = new System.Drawing.Point(430, 495);
            this.lbl_cambioPrecio.Name = "lbl_cambioPrecio";
            this.lbl_cambioPrecio.Size = new System.Drawing.Size(121, 24);
            this.lbl_cambioPrecio.TabIndex = 5;
            this.lbl_cambioPrecio.Text = "Ajuste Precios";
            this.lbl_cambioPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_principal
            // 
            this.dtg_principal.BackgroundColor = System.Drawing.Color.White;
            this.dtg_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_principal.GridColor = System.Drawing.Color.White;
            this.dtg_principal.Location = new System.Drawing.Point(26, 183);
            this.dtg_principal.Name = "dtg_principal";
            this.dtg_principal.ReadOnly = true;
            this.dtg_principal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtg_principal.RowTemplate.Height = 29;
            this.dtg_principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_principal.Size = new System.Drawing.Size(533, 293);
            this.dtg_principal.TabIndex = 7;
            this.dtg_principal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_principal_CellContentDoubleClick);
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
            this.btn_nuevoVuelo.Location = new System.Drawing.Point(26, 571);
            this.btn_nuevoVuelo.Name = "btn_nuevoVuelo";
            this.btn_nuevoVuelo.Size = new System.Drawing.Size(118, 60);
            this.btn_nuevoVuelo.TabIndex = 13;
            this.btn_nuevoVuelo.Text = "Agregar Vuelo";
            this.btn_nuevoVuelo.UseVisualStyleBackColor = true;
            this.btn_nuevoVuelo.Click += new System.EventHandler(this.btn_nuevoVuelo_Click);
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(150, 571);
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
            this.btn_venderVuelo.Location = new System.Drawing.Point(26, 485);
            this.btn_venderVuelo.Name = "btn_venderVuelo";
            this.btn_venderVuelo.Size = new System.Drawing.Size(246, 56);
            this.btn_venderVuelo.TabIndex = 15;
            this.btn_venderVuelo.Text = "Subir al Avion";
            this.btn_venderVuelo.UseVisualStyleBackColor = true;
            this.btn_venderVuelo.Click += new System.EventHandler(this.btn_venderVuelo_Click);
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
            this.lbl_acciones.Location = new System.Drawing.Point(33, 544);
            this.lbl_acciones.Name = "lbl_acciones";
            this.lbl_acciones.Size = new System.Drawing.Size(100, 24);
            this.lbl_acciones.TabIndex = 21;
            this.lbl_acciones.Text = "Acciones";
            this.lbl_acciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_aviones
            // 
            this.btn_aviones.BackColor = System.Drawing.Color.Transparent;
            this.btn_aviones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aviones.BackgroundImage")));
            this.btn_aviones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aviones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_aviones.Location = new System.Drawing.Point(132, 57);
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
            this.label2.Font = new System.Drawing.Font("Simpsonfont", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "VUELOS disponibles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_mostrarEstadisticas
            // 
            this.btn_mostrarEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrarEstadisticas.BackgroundImage = global::FrmMenuPrincipal.Properties.Resources.estadisticas;
            this.btn_mostrarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mostrarEstadisticas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mostrarEstadisticas.Location = new System.Drawing.Point(441, 523);
            this.btn_mostrarEstadisticas.Name = "btn_mostrarEstadisticas";
            this.btn_mostrarEstadisticas.Size = new System.Drawing.Size(100, 96);
            this.btn_mostrarEstadisticas.TabIndex = 30;
            this.btn_mostrarEstadisticas.UseVisualStyleBackColor = false;
            this.btn_mostrarEstadisticas.Click += new System.EventHandler(this.btn_mostrarEstadisticas_Click);
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_estadisticas.Location = new System.Drawing.Point(344, 30);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(100, 24);
            this.lbl_estadisticas.TabIndex = 31;
            this.lbl_estadisticas.Text = "Estadisticas";
            this.lbl_estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ocupacionBodega
            // 
            this.lbl_ocupacionBodega.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_ocupacionBodega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ocupacionBodega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ocupacionBodega.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ocupacionBodega.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_ocupacionBodega.Location = new System.Drawing.Point(565, 511);
            this.lbl_ocupacionBodega.Name = "lbl_ocupacionBodega";
            this.lbl_ocupacionBodega.Size = new System.Drawing.Size(211, 30);
            this.lbl_ocupacionBodega.TabIndex = 32;
            this.lbl_ocupacionBodega.Text = "Ocupacion de bodega:";
            this.lbl_ocupacionBodega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mostrarOcupacionBodega
            // 
            this.lbl_mostrarOcupacionBodega.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_mostrarOcupacionBodega.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mostrarOcupacionBodega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_mostrarOcupacionBodega.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mostrarOcupacionBodega.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_mostrarOcupacionBodega.Location = new System.Drawing.Point(769, 511);
            this.lbl_mostrarOcupacionBodega.Name = "lbl_mostrarOcupacionBodega";
            this.lbl_mostrarOcupacionBodega.Size = new System.Drawing.Size(195, 30);
            this.lbl_mostrarOcupacionBodega.TabIndex = 33;
            this.lbl_mostrarOcupacionBodega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mostrarOcupacionCabina
            // 
            this.lbl_mostrarOcupacionCabina.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_mostrarOcupacionCabina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mostrarOcupacionCabina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_mostrarOcupacionCabina.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mostrarOcupacionCabina.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_mostrarOcupacionCabina.Location = new System.Drawing.Point(769, 479);
            this.lbl_mostrarOcupacionCabina.Name = "lbl_mostrarOcupacionCabina";
            this.lbl_mostrarOcupacionCabina.Size = new System.Drawing.Size(195, 30);
            this.lbl_mostrarOcupacionCabina.TabIndex = 35;
            this.lbl_mostrarOcupacionCabina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ocupacionCabina
            // 
            this.lbl_ocupacionCabina.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_ocupacionCabina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ocupacionCabina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ocupacionCabina.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ocupacionCabina.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_ocupacionCabina.Location = new System.Drawing.Point(565, 479);
            this.lbl_ocupacionCabina.Name = "lbl_ocupacionCabina";
            this.lbl_ocupacionCabina.Size = new System.Drawing.Size(198, 30);
            this.lbl_ocupacionCabina.TabIndex = 34;
            this.lbl_ocupacionCabina.Text = "Ocupacion de Cabina";
            this.lbl_ocupacionCabina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_secundario
            // 
            this.dtg_secundario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_secundario.BackgroundColor = System.Drawing.Color.White;
            this.dtg_secundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_secundario.GridColor = System.Drawing.Color.White;
            this.dtg_secundario.Location = new System.Drawing.Point(565, 183);
            this.dtg_secundario.Name = "dtg_secundario";
            this.dtg_secundario.ReadOnly = true;
            this.dtg_secundario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtg_secundario.RowTemplate.Height = 29;
            this.dtg_secundario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_secundario.Size = new System.Drawing.Size(405, 293);
            this.dtg_secundario.TabIndex = 36;
            this.dtg_secundario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_secundario_CellContentClick);
            // 
            // btn_vuelosHistorico
            // 
            this.btn_vuelosHistorico.BackColor = System.Drawing.Color.Transparent;
            this.btn_vuelosHistorico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vuelosHistorico.BackgroundImage")));
            this.btn_vuelosHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vuelosHistorico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_vuelosHistorico.Location = new System.Drawing.Point(324, 523);
            this.btn_vuelosHistorico.Name = "btn_vuelosHistorico";
            this.btn_vuelosHistorico.Size = new System.Drawing.Size(100, 96);
            this.btn_vuelosHistorico.TabIndex = 38;
            this.btn_vuelosHistorico.UseVisualStyleBackColor = false;
            this.btn_vuelosHistorico.Click += new System.EventHandler(this.btn_vuelosHistorico_Click);
            // 
            // lbl_vuelosHistorico
            // 
            this.lbl_vuelosHistorico.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_vuelosHistorico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelosHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_vuelosHistorico.Font = new System.Drawing.Font("Simpsonfont", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelosHistorico.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_vuelosHistorico.Location = new System.Drawing.Point(313, 485);
            this.lbl_vuelosHistorico.Name = "lbl_vuelosHistorico";
            this.lbl_vuelosHistorico.Size = new System.Drawing.Size(121, 34);
            this.lbl_vuelosHistorico.TabIndex = 37;
            this.lbl_vuelosHistorico.Text = "Vuelos Historico";
            this.lbl_vuelosHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_facturas
            // 
            this.btn_facturas.BackColor = System.Drawing.Color.Transparent;
            this.btn_facturas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_facturas.BackgroundImage")));
            this.btn_facturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_facturas.Location = new System.Drawing.Point(451, 57);
            this.btn_facturas.Name = "btn_facturas";
            this.btn_facturas.Size = new System.Drawing.Size(100, 96);
            this.btn_facturas.TabIndex = 39;
            this.btn_facturas.UseVisualStyleBackColor = false;
            this.btn_facturas.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_facturas
            // 
            this.lbl_facturas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_facturas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_facturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_facturas.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_facturas.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_facturas.Location = new System.Drawing.Point(451, 30);
            this.lbl_facturas.Name = "lbl_facturas";
            this.lbl_facturas.Size = new System.Drawing.Size(100, 24);
            this.lbl_facturas.TabIndex = 40;
            this.lbl_facturas.Text = "Facturas";
            this.lbl_facturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 687);
            this.Controls.Add(this.lbl_facturas);
            this.Controls.Add(this.btn_facturas);
            this.Controls.Add(this.btn_vuelosHistorico);
            this.Controls.Add(this.lbl_vuelosHistorico);
            this.Controls.Add(this.dtg_secundario);
            this.Controls.Add(this.lbl_mostrarOcupacionCabina);
            this.Controls.Add(this.lbl_ocupacionCabina);
            this.Controls.Add(this.lbl_mostrarOcupacionBodega);
            this.Controls.Add(this.lbl_ocupacionBodega);
            this.Controls.Add(this.lbl_estadisticas);
            this.Controls.Add(this.btn_mostrarEstadisticas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aviones);
            this.Controls.Add(this.lbl_acciones);
            this.Controls.Add(this.btn_salirMenuPrincipal);
            this.Controls.Add(this.btn_venderVuelo);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.btn_nuevoVuelo);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_fechaSistema);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.dtg_principal);
            this.Controls.Add(this.lbl_cambioPrecio);
            this.Controls.Add(this.lbl_clientes);
            this.Controls.Add(this.lbl_aviones);
            this.Controls.Add(this.btn_estadisticas);
            this.Controls.Add(this.btn_pasajeros);
            this.Controls.Add(this.btn_vuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_menuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_secundario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vuelos;
        private System.Windows.Forms.Button btn_pasajeros;
        private System.Windows.Forms.Button btn_estadisticas;
        private System.Windows.Forms.Label lbl_aviones;
        private System.Windows.Forms.Label lbl_clientes;
        private System.Windows.Forms.Label lbl_cambioPrecio;
        private System.Windows.Forms.DataGridView dtg_principal;
        private System.Windows.Forms.Timer tmr_fechaYHoraActual;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fechaSistema;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_nuevoVuelo;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Button btn_venderVuelo;
        private System.Windows.Forms.Button btn_salirMenuPrincipal;
        private System.Windows.Forms.Label lbl_acciones;
        private System.Windows.Forms.Button btn_aviones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mostrarEstadisticas;
        private System.Windows.Forms.Label lbl_estadisticas;
        private System.Windows.Forms.Label lbl_ocupacionBodega;
        private System.Windows.Forms.Label lbl_mostrarOcupacionBodega;
        private System.Windows.Forms.Label lbl_mostrarOcupacionCabina;
        private System.Windows.Forms.Label lbl_ocupacionCabina;
        private System.Windows.Forms.DataGridView dtg_secundario;
        private System.Windows.Forms.Button btn_vuelosHistorico;
        private System.Windows.Forms.Label lbl_vuelosHistorico;
        private System.Windows.Forms.Button btn_facturas;
        private System.Windows.Forms.Label lbl_facturas;
    }
}
