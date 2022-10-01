namespace FrmNuevoVuelo
{
    partial class frm_nuevoVuelo
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
            this.lbl_mostrarCodVueloRamdom = new System.Windows.Forms.Label();
            this.lbl_codVuelo = new System.Windows.Forms.Label();
            this.cbo_origenNuevoVuelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_destinoNuevoVuelo = new System.Windows.Forms.ComboBox();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.lbl_mostrarDuracionVueloRamdom = new System.Windows.Forms.Label();
            this.lbl_fechaYHora = new System.Windows.Forms.Label();
            this.dtp_fechaNuevoVuelo = new System.Windows.Forms.DateTimePicker();
            this.lbl_aeronaveDesignada = new System.Windows.Forms.Label();
            this.lbl_asientosDisponiblesVuelo = new System.Windows.Forms.Label();
            this.lbl_mostrarCantAsientos = new System.Windows.Forms.Label();
            this.lbl_clasePremiun = new System.Windows.Forms.Label();
            this.lbl_mostrarCantPremium = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mostrarCantTurista = new System.Windows.Forms.Label();
            this.btn_agregarVuelo = new System.Windows.Forms.Button();
            this.btn_cancelarCargaVuelo = new System.Windows.Forms.Button();
            this.lbl_baños = new System.Windows.Forms.Label();
            this.lbl_cantBaños = new System.Windows.Forms.Label();
            this.cbo_aeronaveDesignada = new System.Windows.Forms.ComboBox();
            this.cbo_tipoVuelo = new System.Windows.Forms.ComboBox();
            this.lbl_tipoDestino = new System.Windows.Forms.Label();
            this.lbl_nombreAeronave = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.lbl_mostrarExepcion = new System.Windows.Forms.Label();
            this.chk_wifi = new System.Windows.Forms.CheckBox();
            this.chk_refresco = new System.Windows.Forms.CheckBox();
            this.chk_comida = new System.Windows.Forms.CheckBox();
            this.lbl_capbodega = new System.Windows.Forms.Label();
            this.lbl_mostrarCapacidadBodega = new System.Windows.Forms.Label();
            this.lbl_bultos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mostrarCodVueloRamdom
            // 
            this.lbl_mostrarCodVueloRamdom.Location = new System.Drawing.Point(157, 20);
            this.lbl_mostrarCodVueloRamdom.Name = "lbl_mostrarCodVueloRamdom";
            this.lbl_mostrarCodVueloRamdom.Size = new System.Drawing.Size(117, 42);
            this.lbl_mostrarCodVueloRamdom.TabIndex = 0;
            this.lbl_mostrarCodVueloRamdom.Text = "codigo devuelo autogenerado";
            // 
            // lbl_codVuelo
            // 
            this.lbl_codVuelo.Location = new System.Drawing.Point(36, 20);
            this.lbl_codVuelo.Name = "lbl_codVuelo";
            this.lbl_codVuelo.Size = new System.Drawing.Size(103, 26);
            this.lbl_codVuelo.TabIndex = 1;
            this.lbl_codVuelo.Text = "Cod. Vuelo:";
            // 
            // cbo_origenNuevoVuelo
            // 
            this.cbo_origenNuevoVuelo.FormattingEnabled = true;
            this.cbo_origenNuevoVuelo.Location = new System.Drawing.Point(36, 215);
            this.cbo_origenNuevoVuelo.Name = "cbo_origenNuevoVuelo";
            this.cbo_origenNuevoVuelo.Size = new System.Drawing.Size(151, 28);
            this.cbo_origenNuevoVuelo.TabIndex = 2;
            this.cbo_origenNuevoVuelo.SelectedIndexChanged += new System.EventHandler(this.cbo_origenNuevoVuelo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(222, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destino:";
            // 
            // cbo_destinoNuevoVuelo
            // 
            this.cbo_destinoNuevoVuelo.FormattingEnabled = true;
            this.cbo_destinoNuevoVuelo.Location = new System.Drawing.Point(222, 215);
            this.cbo_destinoNuevoVuelo.Name = "cbo_destinoNuevoVuelo";
            this.cbo_destinoNuevoVuelo.Size = new System.Drawing.Size(151, 28);
            this.cbo_destinoNuevoVuelo.TabIndex = 5;
            this.cbo_destinoNuevoVuelo.SelectedIndexChanged += new System.EventHandler(this.cbo_destinoNuevoVuelo_SelectedIndexChanged);
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.Location = new System.Drawing.Point(36, 260);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(103, 21);
            this.lbl_duracion.TabIndex = 6;
            this.lbl_duracion.Text = "Duracion:";
            // 
            // lbl_mostrarDuracionVueloRamdom
            // 
            this.lbl_mostrarDuracionVueloRamdom.Location = new System.Drawing.Point(157, 260);
            this.lbl_mostrarDuracionVueloRamdom.Name = "lbl_mostrarDuracionVueloRamdom";
            this.lbl_mostrarDuracionVueloRamdom.Size = new System.Drawing.Size(46, 21);
            this.lbl_mostrarDuracionVueloRamdom.TabIndex = 7;
            this.lbl_mostrarDuracionVueloRamdom.Text = "duracion del vuelo ramdom";
            // 
            // lbl_fechaYHora
            // 
            this.lbl_fechaYHora.Location = new System.Drawing.Point(47, 296);
            this.lbl_fechaYHora.Name = "lbl_fechaYHora";
            this.lbl_fechaYHora.Size = new System.Drawing.Size(165, 21);
            this.lbl_fechaYHora.TabIndex = 8;
            this.lbl_fechaYHora.Text = "Hora     Dia      Fecha";
            // 
            // dtp_fechaNuevoVuelo
            // 
            this.dtp_fechaNuevoVuelo.CustomFormat = "  HH tt ddd dd -MMMM-yyyy";
            this.dtp_fechaNuevoVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaNuevoVuelo.Location = new System.Drawing.Point(38, 320);
            this.dtp_fechaNuevoVuelo.MinDate = new System.DateTime(2022, 9, 30, 0, 0, 0, 0);
            this.dtp_fechaNuevoVuelo.Name = "dtp_fechaNuevoVuelo";
            this.dtp_fechaNuevoVuelo.Size = new System.Drawing.Size(335, 27);
            this.dtp_fechaNuevoVuelo.TabIndex = 9;
            this.dtp_fechaNuevoVuelo.Value = new System.DateTime(2022, 9, 30, 18, 25, 36, 0);
            this.dtp_fechaNuevoVuelo.ValueChanged += new System.EventHandler(this.dtp_fechaNuevoVuelo_ValueChanged);
            // 
            // lbl_aeronaveDesignada
            // 
            this.lbl_aeronaveDesignada.Location = new System.Drawing.Point(36, 76);
            this.lbl_aeronaveDesignada.Name = "lbl_aeronaveDesignada";
            this.lbl_aeronaveDesignada.Size = new System.Drawing.Size(151, 24);
            this.lbl_aeronaveDesignada.TabIndex = 10;
            this.lbl_aeronaveDesignada.Text = "Aeronave Designada:";
            // 
            // lbl_asientosDisponiblesVuelo
            // 
            this.lbl_asientosDisponiblesVuelo.Location = new System.Drawing.Point(36, 440);
            this.lbl_asientosDisponiblesVuelo.Name = "lbl_asientosDisponiblesVuelo";
            this.lbl_asientosDisponiblesVuelo.Size = new System.Drawing.Size(208, 23);
            this.lbl_asientosDisponiblesVuelo.TabIndex = 12;
            this.lbl_asientosDisponiblesVuelo.Text = "Disponibilidad de Asientos:";
            // 
            // lbl_mostrarCantAsientos
            // 
            this.lbl_mostrarCantAsientos.Location = new System.Drawing.Point(270, 440);
            this.lbl_mostrarCantAsientos.Name = "lbl_mostrarCantAsientos";
            this.lbl_mostrarCantAsientos.Size = new System.Drawing.Size(103, 21);
            this.lbl_mostrarCantAsientos.TabIndex = 13;
            this.lbl_mostrarCantAsientos.Text = "asietos avion";
            this.lbl_mostrarCantAsientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_clasePremiun
            // 
            this.lbl_clasePremiun.Location = new System.Drawing.Point(110, 472);
            this.lbl_clasePremiun.Name = "lbl_clasePremiun";
            this.lbl_clasePremiun.Size = new System.Drawing.Size(115, 23);
            this.lbl_clasePremiun.TabIndex = 14;
            this.lbl_clasePremiun.Text = "Clase Premium:";
            // 
            // lbl_mostrarCantPremium
            // 
            this.lbl_mostrarCantPremium.Location = new System.Drawing.Point(270, 472);
            this.lbl_mostrarCantPremium.Name = "lbl_mostrarCantPremium";
            this.lbl_mostrarCantPremium.Size = new System.Drawing.Size(103, 21);
            this.lbl_mostrarCantPremium.TabIndex = 15;
            this.lbl_mostrarCantPremium.Text = "asietos premium";
            this.lbl_mostrarCantPremium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(110, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Clase Turista:";
            // 
            // lbl_mostrarCantTurista
            // 
            this.lbl_mostrarCantTurista.Location = new System.Drawing.Point(270, 495);
            this.lbl_mostrarCantTurista.Name = "lbl_mostrarCantTurista";
            this.lbl_mostrarCantTurista.Size = new System.Drawing.Size(103, 21);
            this.lbl_mostrarCantTurista.TabIndex = 17;
            this.lbl_mostrarCantTurista.Text = "asietos turista";
            this.lbl_mostrarCantTurista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_agregarVuelo
            // 
            this.btn_agregarVuelo.Location = new System.Drawing.Point(110, 715);
            this.btn_agregarVuelo.Name = "btn_agregarVuelo";
            this.btn_agregarVuelo.Size = new System.Drawing.Size(134, 50);
            this.btn_agregarVuelo.TabIndex = 18;
            this.btn_agregarVuelo.Text = "Agregar";
            this.btn_agregarVuelo.UseVisualStyleBackColor = true;
            this.btn_agregarVuelo.Click += new System.EventHandler(this.btn_agregarVuelo_Click);
            // 
            // btn_cancelarCargaVuelo
            // 
            this.btn_cancelarCargaVuelo.Location = new System.Drawing.Point(250, 715);
            this.btn_cancelarCargaVuelo.Name = "btn_cancelarCargaVuelo";
            this.btn_cancelarCargaVuelo.Size = new System.Drawing.Size(134, 50);
            this.btn_cancelarCargaVuelo.TabIndex = 19;
            this.btn_cancelarCargaVuelo.Text = "Cancelar";
            this.btn_cancelarCargaVuelo.UseVisualStyleBackColor = true;
            this.btn_cancelarCargaVuelo.Click += new System.EventHandler(this.btn_cancelarCargaVuelo_Click);
            // 
            // lbl_baños
            // 
            this.lbl_baños.Location = new System.Drawing.Point(36, 364);
            this.lbl_baños.Name = "lbl_baños";
            this.lbl_baños.Size = new System.Drawing.Size(208, 23);
            this.lbl_baños.TabIndex = 20;
            this.lbl_baños.Text = "Baños:";
            // 
            // lbl_cantBaños
            // 
            this.lbl_cantBaños.Location = new System.Drawing.Point(270, 364);
            this.lbl_cantBaños.Name = "lbl_cantBaños";
            this.lbl_cantBaños.Size = new System.Drawing.Size(103, 21);
            this.lbl_cantBaños.TabIndex = 21;
            this.lbl_cantBaños.Text = "canti baños";
            this.lbl_cantBaños.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_aeronaveDesignada
            // 
            this.cbo_aeronaveDesignada.FormattingEnabled = true;
            this.cbo_aeronaveDesignada.Location = new System.Drawing.Point(222, 72);
            this.cbo_aeronaveDesignada.Name = "cbo_aeronaveDesignada";
            this.cbo_aeronaveDesignada.Size = new System.Drawing.Size(151, 28);
            this.cbo_aeronaveDesignada.TabIndex = 11;
            this.cbo_aeronaveDesignada.Text = "Disponibles";
            this.cbo_aeronaveDesignada.UseWaitCursor = true;
            this.cbo_aeronaveDesignada.SelectedIndexChanged += new System.EventHandler(this.cbo_aeronaveDesignada_SelectedIndexChanged);
            // 
            // cbo_tipoVuelo
            // 
            this.cbo_tipoVuelo.FormattingEnabled = true;
            this.cbo_tipoVuelo.Location = new System.Drawing.Point(222, 153);
            this.cbo_tipoVuelo.Name = "cbo_tipoVuelo";
            this.cbo_tipoVuelo.Size = new System.Drawing.Size(151, 28);
            this.cbo_tipoVuelo.TabIndex = 22;
            this.cbo_tipoVuelo.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoVuelo_SelectedIndexChanged);
            // 
            // lbl_tipoDestino
            // 
            this.lbl_tipoDestino.Location = new System.Drawing.Point(36, 156);
            this.lbl_tipoDestino.Name = "lbl_tipoDestino";
            this.lbl_tipoDestino.Size = new System.Drawing.Size(151, 21);
            this.lbl_tipoDestino.TabIndex = 23;
            this.lbl_tipoDestino.Text = "Tipo de destino:";
            // 
            // lbl_nombreAeronave
            // 
            this.lbl_nombreAeronave.Location = new System.Drawing.Point(224, 113);
            this.lbl_nombreAeronave.Name = "lbl_nombreAeronave";
            this.lbl_nombreAeronave.Size = new System.Drawing.Size(149, 25);
            this.lbl_nombreAeronave.TabIndex = 24;
            this.lbl_nombreAeronave.Text = "Nombre Aeronave";
            this.lbl_nombreAeronave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_horas
            // 
            this.lbl_horas.Location = new System.Drawing.Point(209, 260);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(103, 21);
            this.lbl_horas.TabIndex = 26;
            this.lbl_horas.Text = "Horas";
            // 
            // lbl_mostrarExepcion
            // 
            this.lbl_mostrarExepcion.Location = new System.Drawing.Point(74, 661);
            this.lbl_mostrarExepcion.Name = "lbl_mostrarExepcion";
            this.lbl_mostrarExepcion.Size = new System.Drawing.Size(251, 33);
            this.lbl_mostrarExepcion.TabIndex = 27;
            this.lbl_mostrarExepcion.Text = "Muestra excepcion";
            this.lbl_mostrarExepcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mostrarExepcion.Visible = false;
            // 
            // chk_wifi
            // 
            this.chk_wifi.AutoSize = true;
            this.chk_wifi.Location = new System.Drawing.Point(36, 548);
            this.chk_wifi.Name = "chk_wifi";
            this.chk_wifi.Size = new System.Drawing.Size(66, 24);
            this.chk_wifi.TabIndex = 28;
            this.chk_wifi.Text = "WI-FI";
            this.chk_wifi.UseVisualStyleBackColor = true;
            // 
            // chk_refresco
            // 
            this.chk_refresco.AutoSize = true;
            this.chk_refresco.Location = new System.Drawing.Point(36, 578);
            this.chk_refresco.Name = "chk_refresco";
            this.chk_refresco.Size = new System.Drawing.Size(135, 24);
            this.chk_refresco.TabIndex = 29;
            this.chk_refresco.Text = "Refresco Basico";
            this.chk_refresco.UseVisualStyleBackColor = true;
            // 
            // chk_comida
            // 
            this.chk_comida.AutoSize = true;
            this.chk_comida.Location = new System.Drawing.Point(36, 608);
            this.chk_comida.Name = "chk_comida";
            this.chk_comida.Size = new System.Drawing.Size(207, 24);
            this.chk_comida.TabIndex = 30;
            this.chk_comida.Text = "Comida (almuerzo o cena)";
            this.chk_comida.UseVisualStyleBackColor = true;
            // 
            // lbl_capbodega
            // 
            this.lbl_capbodega.Location = new System.Drawing.Point(38, 396);
            this.lbl_capbodega.Name = "lbl_capbodega";
            this.lbl_capbodega.Size = new System.Drawing.Size(165, 23);
            this.lbl_capbodega.TabIndex = 31;
            this.lbl_capbodega.Text = "Capacidad de Bodega:";
            // 
            // lbl_mostrarCapacidadBodega
            // 
            this.lbl_mostrarCapacidadBodega.Location = new System.Drawing.Point(239, 396);
            this.lbl_mostrarCapacidadBodega.Name = "lbl_mostrarCapacidadBodega";
            this.lbl_mostrarCapacidadBodega.Size = new System.Drawing.Size(61, 23);
            this.lbl_mostrarCapacidadBodega.TabIndex = 32;
            this.lbl_mostrarCapacidadBodega.Text = "muestra bodega";
            this.lbl_mostrarCapacidadBodega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bultos
            // 
            this.lbl_bultos.Location = new System.Drawing.Point(312, 395);
            this.lbl_bultos.Name = "lbl_bultos";
            this.lbl_bultos.Size = new System.Drawing.Size(61, 23);
            this.lbl_bultos.TabIndex = 33;
            this.lbl_bultos.Text = "Bultos";
            this.lbl_bultos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_nuevoVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 777);
            this.Controls.Add(this.lbl_bultos);
            this.Controls.Add(this.lbl_mostrarCapacidadBodega);
            this.Controls.Add(this.lbl_capbodega);
            this.Controls.Add(this.chk_comida);
            this.Controls.Add(this.chk_refresco);
            this.Controls.Add(this.chk_wifi);
            this.Controls.Add(this.lbl_mostrarExepcion);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.lbl_nombreAeronave);
            this.Controls.Add(this.lbl_tipoDestino);
            this.Controls.Add(this.cbo_tipoVuelo);
            this.Controls.Add(this.lbl_cantBaños);
            this.Controls.Add(this.lbl_baños);
            this.Controls.Add(this.btn_cancelarCargaVuelo);
            this.Controls.Add(this.btn_agregarVuelo);
            this.Controls.Add(this.lbl_mostrarCantTurista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mostrarCantPremium);
            this.Controls.Add(this.lbl_clasePremiun);
            this.Controls.Add(this.lbl_mostrarCantAsientos);
            this.Controls.Add(this.lbl_asientosDisponiblesVuelo);
            this.Controls.Add(this.cbo_aeronaveDesignada);
            this.Controls.Add(this.lbl_aeronaveDesignada);
            this.Controls.Add(this.dtp_fechaNuevoVuelo);
            this.Controls.Add(this.lbl_fechaYHora);
            this.Controls.Add(this.lbl_mostrarDuracionVueloRamdom);
            this.Controls.Add(this.lbl_duracion);
            this.Controls.Add(this.cbo_destinoNuevoVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_origenNuevoVuelo);
            this.Controls.Add(this.lbl_codVuelo);
            this.Controls.Add(this.lbl_mostrarCodVueloRamdom);
            this.Name = "frm_nuevoVuelo";
            this.Text = "Nuevo Vuelo";
            this.Load += new System.EventHandler(this.frm_nuevoVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mostrarCodVueloRamdom;
        private System.Windows.Forms.Label lbl_codVuelo;
        private System.Windows.Forms.ComboBox cbo_origenNuevoVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_destinoNuevoVuelo;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Label lbl_mostrarDuracionVueloRamdom;
        private System.Windows.Forms.Label lbl_fechaYHora;
        private System.Windows.Forms.DateTimePicker dtp_fechaNuevoVuelo;
        private System.Windows.Forms.Label lbl_aeronaveDesignada;
        private System.Windows.Forms.Label lbl_asientosDisponiblesVuelo;
        private System.Windows.Forms.Label lbl_mostrarCantAsientos;
        private System.Windows.Forms.Label lbl_clasePremiun;
        private System.Windows.Forms.Label lbl_mostrarCantPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mostrarCantTurista;
        private System.Windows.Forms.Button btn_agregarVuelo;
        private System.Windows.Forms.Button btn_cancelarCargaVuelo;
        private System.Windows.Forms.Label lbl_baños;
        private System.Windows.Forms.Label lbl_cantBaños;
        private System.Windows.Forms.ComboBox cbo_aeronaveDesignada;
        private System.Windows.Forms.ComboBox cbo_tipoVuelo;
        private System.Windows.Forms.Label lbl_tipoDestino;
        private System.Windows.Forms.Label lbl_nombreAeronave;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Label lbl_mostrarExepcion;
        private System.Windows.Forms.CheckBox chk_wifi;
        private System.Windows.Forms.CheckBox chk_refresco;
        private System.Windows.Forms.CheckBox chk_comida;
        private System.Windows.Forms.Label lbl_capbodega;
        private System.Windows.Forms.Label lbl_mostrarCapacidadBodega;
        private System.Windows.Forms.Label lbl_bultos;
    }
}
