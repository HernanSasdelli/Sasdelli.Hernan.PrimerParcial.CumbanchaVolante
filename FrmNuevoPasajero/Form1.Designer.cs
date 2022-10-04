namespace FrmNuevoPasajero
{
    partial class frm_cargarPasajero
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
            this.lbl_errorGeneral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_datosContacto = new System.Windows.Forms.Label();
            this.lbl_datosPersonales = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_mensajeDni = new System.Windows.Forms.Label();
            this.txt_pasaporte = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_pasaporte = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_vuelo = new System.Windows.Forms.Label();
            this.lbl_muestraVuelo = new System.Windows.Forms.Label();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.chk_esMenor = new System.Windows.Forms.CheckBox();
            this.chk_valijaBodega = new System.Windows.Forms.CheckBox();
            this.nup_cantValijas = new System.Windows.Forms.NumericUpDown();
            this.btn_cancelarDatos = new System.Windows.Forms.Button();
            this.lbl_esCliente = new System.Windows.Forms.Label();
            this.chk_bolsoMano = new System.Windows.Forms.CheckBox();
            this.lbl_rerponsableMenor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.lbl_errorDispon = new System.Windows.Forms.Label();
            this.nup_numeroPasajeros = new System.Windows.Forms.NumericUpDown();
            this.lbl_muestraNumero = new System.Windows.Forms.Label();
            this.rad_variosPasajeros = new System.Windows.Forms.RadioButton();
            this.rad_unPasajero = new System.Windows.Forms.RadioButton();
            this.lbl_cantPasajeros = new System.Windows.Forms.Label();
            this.lbl_disponibilidad = new System.Windows.Forms.Label();
            this.lbl_siNoBufet = new System.Windows.Forms.Label();
            this.lbl_siNoWifi = new System.Windows.Forms.Label();
            this.lbl_bufet = new System.Windows.Forms.Label();
            this.lbl_refrigerio = new System.Windows.Forms.Label();
            this.lbl_wifi = new System.Windows.Forms.Label();
            this.lbl_servicios = new System.Windows.Forms.Label();
            this.lbl_cantBaños = new System.Windows.Forms.Label();
            this.lbl_muestraCantBaños = new System.Windows.Forms.Label();
            this.cbo_tipoServicio = new System.Windows.Forms.ComboBox();
            this.lbl_muestraAtencion = new System.Windows.Forms.Label();
            this.lbl_muestraDestino = new System.Windows.Forms.Label();
            this.lbl_muestraOrigen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_siNoRefrigerio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantValijas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_numeroPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_errorGeneral
            // 
            this.lbl_errorGeneral.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorGeneral.Location = new System.Drawing.Point(79, 590);
            this.lbl_errorGeneral.Name = "lbl_errorGeneral";
            this.lbl_errorGeneral.Size = new System.Drawing.Size(563, 51);
            this.lbl_errorGeneral.TabIndex = 94;
            this.lbl_errorGeneral.Text = "Error General";
            this.lbl_errorGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_errorGeneral.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(568, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "*sin (0) ni (15)";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(495, 492);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "Ej.: example@cumbancha.com.ar";
            this.txt_email.Size = new System.Drawing.Size(157, 27);
            this.txt_email.TabIndex = 85;
            // 
            // lbl_email
            // 
            this.lbl_email.Location = new System.Drawing.Point(364, 495);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(125, 24);
            this.lbl_email.TabIndex = 84;
            this.lbl_email.Text = "E-mail:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(495, 446);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "Ej.: 1122334455";
            this.txt_telefono.Size = new System.Drawing.Size(157, 27);
            this.txt_telefono.TabIndex = 83;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Location = new System.Drawing.Point(364, 449);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(125, 24);
            this.lbl_telefono.TabIndex = 82;
            this.lbl_telefono.Text = "Nro. Telefono:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(495, 393);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Ej.: Calle Falsa 123";
            this.txt_direccion.Size = new System.Drawing.Size(157, 27);
            this.txt_direccion.TabIndex = 81;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Location = new System.Drawing.Point(364, 396);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(115, 26);
            this.lbl_direccion.TabIndex = 80;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // lbl_datosContacto
            // 
            this.lbl_datosContacto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datosContacto.Location = new System.Drawing.Point(364, 343);
            this.lbl_datosContacto.Name = "lbl_datosContacto";
            this.lbl_datosContacto.Size = new System.Drawing.Size(153, 26);
            this.lbl_datosContacto.TabIndex = 79;
            this.lbl_datosContacto.Text = "Datos contacto";
            // 
            // lbl_datosPersonales
            // 
            this.lbl_datosPersonales.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datosPersonales.Location = new System.Drawing.Point(32, 250);
            this.lbl_datosPersonales.Name = "lbl_datosPersonales";
            this.lbl_datosPersonales.Size = new System.Drawing.Size(153, 26);
            this.lbl_datosPersonales.TabIndex = 78;
            this.lbl_datosPersonales.Text = "Datos personales";
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(164, 492);
            this.dtp_fechaNacimiento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(157, 27);
            this.dtp_fechaNacimiento.TabIndex = 77;
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(33, 492);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(103, 46);
            this.lbl_fechaNacimiento.TabIndex = 76;
            this.lbl_fechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lbl_mensajeDni
            // 
            this.lbl_mensajeDni.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDni.ForeColor = System.Drawing.Color.Black;
            this.lbl_mensajeDni.Location = new System.Drawing.Point(242, 310);
            this.lbl_mensajeDni.Name = "lbl_mensajeDni";
            this.lbl_mensajeDni.Size = new System.Drawing.Size(79, 21);
            this.lbl_mensajeDni.TabIndex = 75;
            this.lbl_mensajeDni.Text = "*sin (-) ni (.)";
            // 
            // txt_pasaporte
            // 
            this.txt_pasaporte.Location = new System.Drawing.Point(164, 446);
            this.txt_pasaporte.Name = "txt_pasaporte";
            this.txt_pasaporte.Size = new System.Drawing.Size(157, 27);
            this.txt_pasaporte.TabIndex = 74;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(164, 340);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "Ej.: Burns";
            this.txt_apellido.Size = new System.Drawing.Size(157, 27);
            this.txt_apellido.TabIndex = 73;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(164, 393);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Ej.: Mongomeri";
            this.txt_nombre.Size = new System.Drawing.Size(157, 27);
            this.txt_nombre.TabIndex = 72;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(164, 280);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.PlaceholderText = "Ej.: 36374455";
            this.txt_dni.Size = new System.Drawing.Size(157, 27);
            this.txt_dni.TabIndex = 71;
            this.txt_dni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_dni_MouseClick);
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // lbl_pasaporte
            // 
            this.lbl_pasaporte.Location = new System.Drawing.Point(33, 452);
            this.lbl_pasaporte.Name = "lbl_pasaporte";
            this.lbl_pasaporte.Size = new System.Drawing.Size(103, 26);
            this.lbl_pasaporte.TabIndex = 70;
            this.lbl_pasaporte.Text = "Pasaporte";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(33, 343);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(103, 26);
            this.lbl_apellido.TabIndex = 69;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.Location = new System.Drawing.Point(33, 283);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(103, 24);
            this.lbl_dni.TabIndex = 68;
            this.lbl_dni.Text = "D.N.I.:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(33, 396);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(103, 26);
            this.lbl_nombre.TabIndex = 67;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_vuelo
            // 
            this.lbl_vuelo.AutoSize = true;
            this.lbl_vuelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelo.Location = new System.Drawing.Point(33, 9);
            this.lbl_vuelo.Name = "lbl_vuelo";
            this.lbl_vuelo.Size = new System.Drawing.Size(88, 20);
            this.lbl_vuelo.TabIndex = 96;
            this.lbl_vuelo.Text = "Vuelo Nro.:";
            // 
            // lbl_muestraVuelo
            // 
            this.lbl_muestraVuelo.AutoSize = true;
            this.lbl_muestraVuelo.Location = new System.Drawing.Point(137, 9);
            this.lbl_muestraVuelo.Name = "lbl_muestraVuelo";
            this.lbl_muestraVuelo.Size = new System.Drawing.Size(82, 20);
            this.lbl_muestraVuelo.TabIndex = 97;
            this.lbl_muestraVuelo.Text = "Vuelo Nro.:";
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Enabled = false;
            this.btn_agregarCliente.Location = new System.Drawing.Point(136, 551);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(133, 36);
            this.btn_agregarCliente.TabIndex = 98;
            this.btn_agregarCliente.Text = "Agregar Cliente";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // lbl_clase
            // 
            this.lbl_clase.AutoSize = true;
            this.lbl_clase.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_clase.Location = new System.Drawing.Point(380, 9);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(56, 23);
            this.lbl_clase.TabIndex = 99;
            this.lbl_clase.Text = "Clase:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Location = new System.Drawing.Point(207, 704);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(75, 24);
            this.lbl_cantidad.TabIndex = 103;
            this.lbl_cantidad.Text = "Cantidad:";
            this.lbl_cantidad.Visible = false;
            // 
            // chk_esMenor
            // 
            this.chk_esMenor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk_esMenor.Location = new System.Drawing.Point(235, 525);
            this.chk_esMenor.Name = "chk_esMenor";
            this.chk_esMenor.Size = new System.Drawing.Size(87, 20);
            this.chk_esMenor.TabIndex = 105;
            this.chk_esMenor.Text = "Es menor";
            this.chk_esMenor.UseVisualStyleBackColor = true;
            this.chk_esMenor.CheckedChanged += new System.EventHandler(this.chk_esMenor_CheckedChanged);
            // 
            // chk_valijaBodega
            // 
            this.chk_valijaBodega.Location = new System.Drawing.Point(181, 673);
            this.chk_valijaBodega.Name = "chk_valijaBodega";
            this.chk_valijaBodega.Size = new System.Drawing.Size(259, 24);
            this.chk_valijaBodega.TabIndex = 107;
            this.chk_valijaBodega.Text = "Valija en Bodega";
            this.chk_valijaBodega.UseVisualStyleBackColor = true;
            this.chk_valijaBodega.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nup_cantValijas
            // 
            this.nup_cantValijas.Location = new System.Drawing.Point(288, 702);
            this.nup_cantValijas.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_cantValijas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_cantValijas.Name = "nup_cantValijas";
            this.nup_cantValijas.Size = new System.Drawing.Size(39, 27);
            this.nup_cantValijas.TabIndex = 108;
            this.nup_cantValijas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_cantValijas.Visible = false;
            // 
            // btn_cancelarDatos
            // 
            this.btn_cancelarDatos.Location = new System.Drawing.Point(393, 715);
            this.btn_cancelarDatos.Name = "btn_cancelarDatos";
            this.btn_cancelarDatos.Size = new System.Drawing.Size(138, 41);
            this.btn_cancelarDatos.TabIndex = 120;
            this.btn_cancelarDatos.Text = "Cancelar";
            this.btn_cancelarDatos.UseVisualStyleBackColor = true;
            this.btn_cancelarDatos.Click += new System.EventHandler(this.btn_cancelarDatos_Click);
            // 
            // lbl_esCliente
            // 
            this.lbl_esCliente.ForeColor = System.Drawing.Color.Red;
            this.lbl_esCliente.Location = new System.Drawing.Point(33, 307);
            this.lbl_esCliente.Name = "lbl_esCliente";
            this.lbl_esCliente.Size = new System.Drawing.Size(123, 24);
            this.lbl_esCliente.TabIndex = 122;
            this.lbl_esCliente.Text = "Es o no cliente";
            this.lbl_esCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_esCliente.Visible = false;
            // 
            // chk_bolsoMano
            // 
            this.chk_bolsoMano.Location = new System.Drawing.Point(37, 673);
            this.chk_bolsoMano.Name = "chk_bolsoMano";
            this.chk_bolsoMano.Size = new System.Drawing.Size(138, 24);
            this.chk_bolsoMano.TabIndex = 123;
            this.chk_bolsoMano.Text = "Bolso de Mano";
            this.chk_bolsoMano.UseVisualStyleBackColor = true;
            // 
            // lbl_rerponsableMenor
            // 
            this.lbl_rerponsableMenor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rerponsableMenor.ForeColor = System.Drawing.Color.Black;
            this.lbl_rerponsableMenor.Location = new System.Drawing.Point(396, 422);
            this.lbl_rerponsableMenor.Name = "lbl_rerponsableMenor";
            this.lbl_rerponsableMenor.Size = new System.Drawing.Size(168, 24);
            this.lbl_rerponsableMenor.TabIndex = 124;
            this.lbl_rerponsableMenor.Text = "Datos del responsable:";
            this.lbl_rerponsableMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_rerponsableMenor.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 36);
            this.label2.TabIndex = 127;
            this.label2.Text = "Si el pasajero no es cliente, deberá agregarlo antes de continuar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(543, 715);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(138, 41);
            this.btn_siguiente.TabIndex = 128;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // lbl_errorDispon
            // 
            this.lbl_errorDispon.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorDispon.Location = new System.Drawing.Point(363, 288);
            this.lbl_errorDispon.Name = "lbl_errorDispon";
            this.lbl_errorDispon.Size = new System.Drawing.Size(288, 39);
            this.lbl_errorDispon.TabIndex = 134;
            this.lbl_errorDispon.Text = "Ver Disponibilidad";
            this.lbl_errorDispon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_errorDispon.Visible = false;
            // 
            // nup_numeroPasajeros
            // 
            this.nup_numeroPasajeros.Enabled = false;
            this.nup_numeroPasajeros.Location = new System.Drawing.Point(267, 214);
            this.nup_numeroPasajeros.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nup_numeroPasajeros.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_numeroPasajeros.Name = "nup_numeroPasajeros";
            this.nup_numeroPasajeros.Size = new System.Drawing.Size(43, 27);
            this.nup_numeroPasajeros.TabIndex = 133;
            this.nup_numeroPasajeros.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_numeroPasajeros.Visible = false;
            // 
            // lbl_muestraNumero
            // 
            this.lbl_muestraNumero.Enabled = false;
            this.lbl_muestraNumero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraNumero.Location = new System.Drawing.Point(77, 218);
            this.lbl_muestraNumero.Name = "lbl_muestraNumero";
            this.lbl_muestraNumero.Size = new System.Drawing.Size(184, 23);
            this.lbl_muestraNumero.TabIndex = 132;
            this.lbl_muestraNumero.Text = "Ingrese numero de pasajeros";
            this.lbl_muestraNumero.Visible = false;
            // 
            // rad_variosPasajeros
            // 
            this.rad_variosPasajeros.Location = new System.Drawing.Point(181, 153);
            this.rad_variosPasajeros.Name = "rad_variosPasajeros";
            this.rad_variosPasajeros.Size = new System.Drawing.Size(129, 53);
            this.rad_variosPasajeros.TabIndex = 131;
            this.rad_variosPasajeros.TabStop = true;
            this.rad_variosPasajeros.Text = "Contingente o Grupo Familiar";
            this.rad_variosPasajeros.UseVisualStyleBackColor = true;
            this.rad_variosPasajeros.CheckedChanged += new System.EventHandler(this.rad_variosPasajeros_CheckedChanged);
            // 
            // rad_unPasajero
            // 
            this.rad_unPasajero.AutoSize = true;
            this.rad_unPasajero.Location = new System.Drawing.Point(35, 167);
            this.rad_unPasajero.Name = "rad_unPasajero";
            this.rad_unPasajero.Size = new System.Drawing.Size(99, 24);
            this.rad_unPasajero.TabIndex = 130;
            this.rad_unPasajero.TabStop = true;
            this.rad_unPasajero.Text = "1 pasajero";
            this.rad_unPasajero.UseVisualStyleBackColor = true;
            this.rad_unPasajero.CheckedChanged += new System.EventHandler(this.rad_unPasajero_CheckedChanged);
            // 
            // lbl_cantPasajeros
            // 
            this.lbl_cantPasajeros.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantPasajeros.Location = new System.Drawing.Point(30, 132);
            this.lbl_cantPasajeros.Name = "lbl_cantPasajeros";
            this.lbl_cantPasajeros.Size = new System.Drawing.Size(138, 23);
            this.lbl_cantPasajeros.TabIndex = 129;
            this.lbl_cantPasajeros.Text = "Cantidad Pasajeros";
            // 
            // lbl_disponibilidad
            // 
            this.lbl_disponibilidad.Font = new System.Drawing.Font("Simpsonfont", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_disponibilidad.Location = new System.Drawing.Point(37, 647);
            this.lbl_disponibilidad.Name = "lbl_disponibilidad";
            this.lbl_disponibilidad.Size = new System.Drawing.Size(185, 23);
            this.lbl_disponibilidad.TabIndex = 135;
            this.lbl_disponibilidad.Text = "Disponibilidad en Bodega:";
            // 
            // lbl_siNoBufet
            // 
            this.lbl_siNoBufet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_siNoBufet.Location = new System.Drawing.Point(450, 217);
            this.lbl_siNoBufet.Name = "lbl_siNoBufet";
            this.lbl_siNoBufet.Size = new System.Drawing.Size(57, 25);
            this.lbl_siNoBufet.TabIndex = 148;
            this.lbl_siNoBufet.Text = "si/no";
            // 
            // lbl_siNoWifi
            // 
            this.lbl_siNoWifi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_siNoWifi.Location = new System.Drawing.Point(450, 169);
            this.lbl_siNoWifi.Name = "lbl_siNoWifi";
            this.lbl_siNoWifi.Size = new System.Drawing.Size(46, 25);
            this.lbl_siNoWifi.TabIndex = 146;
            this.lbl_siNoWifi.Text = "si/no";
            // 
            // lbl_bufet
            // 
            this.lbl_bufet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_bufet.Location = new System.Drawing.Point(383, 214);
            this.lbl_bufet.Name = "lbl_bufet";
            this.lbl_bufet.Size = new System.Drawing.Size(57, 23);
            this.lbl_bufet.TabIndex = 145;
            this.lbl_bufet.Text = "Bufet:";
            this.lbl_bufet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_refrigerio
            // 
            this.lbl_refrigerio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_refrigerio.Location = new System.Drawing.Point(502, 168);
            this.lbl_refrigerio.Name = "lbl_refrigerio";
            this.lbl_refrigerio.Size = new System.Drawing.Size(81, 23);
            this.lbl_refrigerio.TabIndex = 144;
            this.lbl_refrigerio.Text = "Refrigerio:";
            this.lbl_refrigerio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_wifi
            // 
            this.lbl_wifi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_wifi.Location = new System.Drawing.Point(383, 168);
            this.lbl_wifi.Name = "lbl_wifi";
            this.lbl_wifi.Size = new System.Drawing.Size(57, 23);
            this.lbl_wifi.TabIndex = 143;
            this.lbl_wifi.Text = "WI-FI:";
            this.lbl_wifi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_servicios
            // 
            this.lbl_servicios.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_servicios.Location = new System.Drawing.Point(380, 132);
            this.lbl_servicios.Name = "lbl_servicios";
            this.lbl_servicios.Size = new System.Drawing.Size(116, 23);
            this.lbl_servicios.TabIndex = 149;
            this.lbl_servicios.Text = "Servicios:";
            // 
            // lbl_cantBaños
            // 
            this.lbl_cantBaños.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cantBaños.Location = new System.Drawing.Point(393, 253);
            this.lbl_cantBaños.Name = "lbl_cantBaños";
            this.lbl_cantBaños.Size = new System.Drawing.Size(107, 23);
            this.lbl_cantBaños.TabIndex = 150;
            this.lbl_cantBaños.Text = "Cant. de Baños:";
            // 
            // lbl_muestraCantBaños
            // 
            this.lbl_muestraCantBaños.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraCantBaños.Location = new System.Drawing.Point(474, 253);
            this.lbl_muestraCantBaños.Name = "lbl_muestraCantBaños";
            this.lbl_muestraCantBaños.Size = new System.Drawing.Size(71, 23);
            this.lbl_muestraCantBaños.TabIndex = 151;
            this.lbl_muestraCantBaños.Text = "cantidad";
            // 
            // cbo_tipoServicio
            // 
            this.cbo_tipoServicio.FormattingEnabled = true;
            this.cbo_tipoServicio.Location = new System.Drawing.Point(459, 6);
            this.cbo_tipoServicio.Name = "cbo_tipoServicio";
            this.cbo_tipoServicio.Size = new System.Drawing.Size(139, 28);
            this.cbo_tipoServicio.TabIndex = 152;
            // 
            // lbl_muestraAtencion
            // 
            this.lbl_muestraAtencion.ForeColor = System.Drawing.Color.Red;
            this.lbl_muestraAtencion.Location = new System.Drawing.Point(373, 48);
            this.lbl_muestraAtencion.Name = "lbl_muestraAtencion";
            this.lbl_muestraAtencion.Size = new System.Drawing.Size(278, 44);
            this.lbl_muestraAtencion.TabIndex = 153;
            this.lbl_muestraAtencion.Text = "El Servicio Premium puede tener cargos adicionales";
            this.lbl_muestraAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraAtencion.Visible = false;
            // 
            // lbl_muestraDestino
            // 
            this.lbl_muestraDestino.Location = new System.Drawing.Point(115, 82);
            this.lbl_muestraDestino.Name = "lbl_muestraDestino";
            this.lbl_muestraDestino.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraDestino.TabIndex = 157;
            this.lbl_muestraDestino.Text = "Destino";
            // 
            // lbl_muestraOrigen
            // 
            this.lbl_muestraOrigen.Location = new System.Drawing.Point(114, 48);
            this.lbl_muestraOrigen.Name = "lbl_muestraOrigen";
            this.lbl_muestraOrigen.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraOrigen.TabIndex = 156;
            this.lbl_muestraOrigen.Text = "Origen";
            // 
            // lbl_destino
            // 
            this.lbl_destino.Location = new System.Drawing.Point(44, 82);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(65, 23);
            this.lbl_destino.TabIndex = 155;
            this.lbl_destino.Text = "Destino:";
            // 
            // lbl_origen
            // 
            this.lbl_origen.Location = new System.Drawing.Point(44, 48);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(64, 23);
            this.lbl_origen.TabIndex = 154;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_siNoRefrigerio
            // 
            this.lbl_siNoRefrigerio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_siNoRefrigerio.Location = new System.Drawing.Point(589, 169);
            this.lbl_siNoRefrigerio.Name = "lbl_siNoRefrigerio";
            this.lbl_siNoRefrigerio.Size = new System.Drawing.Size(46, 25);
            this.lbl_siNoRefrigerio.TabIndex = 158;
            this.lbl_siNoRefrigerio.Text = "si/no";
            // 
            // frm_cargarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 782);
            this.Controls.Add(this.lbl_siNoRefrigerio);
            this.Controls.Add(this.lbl_muestraDestino);
            this.Controls.Add(this.lbl_muestraOrigen);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.lbl_muestraAtencion);
            this.Controls.Add(this.cbo_tipoServicio);
            this.Controls.Add(this.lbl_muestraCantBaños);
            this.Controls.Add(this.lbl_cantBaños);
            this.Controls.Add(this.lbl_servicios);
            this.Controls.Add(this.lbl_siNoBufet);
            this.Controls.Add(this.lbl_siNoWifi);
            this.Controls.Add(this.lbl_bufet);
            this.Controls.Add(this.lbl_refrigerio);
            this.Controls.Add(this.lbl_wifi);
            this.Controls.Add(this.lbl_disponibilidad);
            this.Controls.Add(this.lbl_errorDispon);
            this.Controls.Add(this.nup_numeroPasajeros);
            this.Controls.Add(this.lbl_muestraNumero);
            this.Controls.Add(this.rad_variosPasajeros);
            this.Controls.Add(this.rad_unPasajero);
            this.Controls.Add(this.lbl_cantPasajeros);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_rerponsableMenor);
            this.Controls.Add(this.chk_bolsoMano);
            this.Controls.Add(this.lbl_esCliente);
            this.Controls.Add(this.btn_cancelarDatos);
            this.Controls.Add(this.nup_cantValijas);
            this.Controls.Add(this.chk_valijaBodega);
            this.Controls.Add(this.chk_esMenor);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_clase);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.lbl_muestraVuelo);
            this.Controls.Add(this.lbl_vuelo);
            this.Controls.Add(this.lbl_errorGeneral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_datosContacto);
            this.Controls.Add(this.lbl_datosPersonales);
            this.Controls.Add(this.dtp_fechaNacimiento);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_mensajeDni);
            this.Controls.Add(this.txt_pasaporte);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_pasaporte);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "frm_cargarPasajero";
            this.Text = "Datos Pasajero";
            this.Load += new System.EventHandler(this.frm_cargarPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantValijas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_numeroPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_errorGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_datosContacto;
        private System.Windows.Forms.Label lbl_datosPersonales;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label lbl_mensajeDni;
        private System.Windows.Forms.TextBox txt_pasaporte;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_pasaporte;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_vuelo;
        private System.Windows.Forms.Label lbl_muestraVuelo;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Label lbl_clase;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.CheckBox chk_esMenor;
        private System.Windows.Forms.CheckBox chk_valijaBodega;
        private System.Windows.Forms.NumericUpDown nup_cantValijas;
        private System.Windows.Forms.Button btn_cancelarDatos;
        private System.Windows.Forms.Label lbl_esCliente;
        private System.Windows.Forms.CheckBox chk_bolsoMano;
        private System.Windows.Forms.Label lbl_rerponsableMenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label lbl_errorDispon;
        private System.Windows.Forms.NumericUpDown nup_numeroPasajeros;
        private System.Windows.Forms.Label lbl_muestraNumero;
        private System.Windows.Forms.RadioButton rad_variosPasajeros;
        private System.Windows.Forms.RadioButton rad_unPasajero;
        private System.Windows.Forms.Label lbl_cantPasajeros;
        private System.Windows.Forms.Label lbl_disponibilidad;
        private System.Windows.Forms.Label lbl_siNoBufet;
        private System.Windows.Forms.Label lbl_siNoWifi;
        private System.Windows.Forms.Label lbl_bufet;
        private System.Windows.Forms.Label lbl_refrigerio;
        private System.Windows.Forms.Label lbl_wifi;
        private System.Windows.Forms.Label lbl_servicios;
        private System.Windows.Forms.Label lbl_cantBaños;
        private System.Windows.Forms.Label lbl_muestraCantBaños;
        private System.Windows.Forms.ComboBox cbo_tipoServicio;
        private System.Windows.Forms.Label lbl_muestraAtencion;
        private System.Windows.Forms.Label lbl_muestraDestino;
        private System.Windows.Forms.Label lbl_muestraOrigen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_siNoRefrigerio;
    }
}
