namespace FrmNuevoCliente
{
    partial class frm_nuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nuevoCliente));
            this.btn_cancelarCargaVuelo = new System.Windows.Forms.Button();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_pasaporte = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_pasaporte = new System.Windows.Forms.TextBox();
            this.lbl_mensajeDni = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_datosPersonales = new System.Windows.Forms.Label();
            this.lbl_datosContacto = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_mayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelarCargaVuelo
            // 
            this.btn_cancelarCargaVuelo.Location = new System.Drawing.Point(167, 594);
            this.btn_cancelarCargaVuelo.Name = "btn_cancelarCargaVuelo";
            this.btn_cancelarCargaVuelo.Size = new System.Drawing.Size(134, 50);
            this.btn_cancelarCargaVuelo.TabIndex = 39;
            this.btn_cancelarCargaVuelo.Text = "Cancelar";
            this.btn_cancelarCargaVuelo.UseVisualStyleBackColor = true;
            this.btn_cancelarCargaVuelo.Click += new System.EventHandler(this.btn_cancelarCargaVuelo_Click);
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(27, 594);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(134, 50);
            this.btn_agregarCliente.TabIndex = 38;
            this.btn_agregarCliente.Text = "Agregar";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            this.btn_agregarCliente.Click += new System.EventHandler(this.btn_agregarCliente_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(35, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(103, 26);
            this.lbl_nombre.TabIndex = 21;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.Location = new System.Drawing.Point(35, 156);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(103, 24);
            this.lbl_dni.TabIndex = 40;
            this.lbl_dni.Text = "D.N.I.:";
            // 
            // lbl_pasaporte
            // 
            this.lbl_pasaporte.Location = new System.Drawing.Point(35, 211);
            this.lbl_pasaporte.Name = "lbl_pasaporte";
            this.lbl_pasaporte.Size = new System.Drawing.Size(103, 26);
            this.lbl_pasaporte.TabIndex = 42;
            this.lbl_pasaporte.Text = "Pasaporte";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(144, 153);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.PlaceholderText = "Ej.: 36374455";
            this.txt_dni.Size = new System.Drawing.Size(157, 27);
            this.txt_dni.TabIndex = 43;
            this.txt_dni.TextChanged += new System.EventHandler(this.txt_dni_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(144, 55);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Ej.: Mongomeri";
            this.txt_nombre.Size = new System.Drawing.Size(157, 27);
            this.txt_nombre.TabIndex = 44;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(144, 99);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "Ej.: Burns";
            this.txt_apellido.Size = new System.Drawing.Size(157, 27);
            this.txt_apellido.TabIndex = 45;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_pasaporte
            // 
            this.txt_pasaporte.Location = new System.Drawing.Point(144, 208);
            this.txt_pasaporte.Name = "txt_pasaporte";
            this.txt_pasaporte.Size = new System.Drawing.Size(157, 27);
            this.txt_pasaporte.TabIndex = 46;
            this.txt_pasaporte.TextChanged += new System.EventHandler(this.txt_pasaporte_TextChanged);
            // 
            // lbl_mensajeDni
            // 
            this.lbl_mensajeDni.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDni.ForeColor = System.Drawing.Color.Black;
            this.lbl_mensajeDni.Location = new System.Drawing.Point(222, 183);
            this.lbl_mensajeDni.Name = "lbl_mensajeDni";
            this.lbl_mensajeDni.Size = new System.Drawing.Size(79, 21);
            this.lbl_mensajeDni.TabIndex = 47;
            this.lbl_mensajeDni.Text = "*sin (-) ni (.)";
            this.lbl_mensajeDni.Click += new System.EventHandler(this.lbl_mensajeDni_Click);
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(35, 261);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(103, 46);
            this.lbl_fechaNacimiento.TabIndex = 48;
            this.lbl_fechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(144, 270);
            this.dtp_fechaNacimiento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(157, 27);
            this.dtp_fechaNacimiento.TabIndex = 49;
            this.dtp_fechaNacimiento.ValueChanged += new System.EventHandler(this.dtp_fechaNacimiento_ValueChanged);
            // 
            // lbl_datosPersonales
            // 
            this.lbl_datosPersonales.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datosPersonales.Location = new System.Drawing.Point(35, 26);
            this.lbl_datosPersonales.Name = "lbl_datosPersonales";
            this.lbl_datosPersonales.Size = new System.Drawing.Size(153, 26);
            this.lbl_datosPersonales.TabIndex = 50;
            this.lbl_datosPersonales.Text = "Datos personales";
            // 
            // lbl_datosContacto
            // 
            this.lbl_datosContacto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_datosContacto.Location = new System.Drawing.Point(35, 337);
            this.lbl_datosContacto.Name = "lbl_datosContacto";
            this.lbl_datosContacto.Size = new System.Drawing.Size(153, 26);
            this.lbl_datosContacto.TabIndex = 51;
            this.lbl_datosContacto.Text = "Datos contacto";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(144, 366);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "Ej.: Calle Falsa 123";
            this.txt_direccion.Size = new System.Drawing.Size(157, 27);
            this.txt_direccion.TabIndex = 53;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Location = new System.Drawing.Point(35, 369);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(103, 26);
            this.lbl_direccion.TabIndex = 52;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(144, 415);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "Ej.: 1122334455";
            this.txt_telefono.Size = new System.Drawing.Size(157, 27);
            this.txt_telefono.TabIndex = 55;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Location = new System.Drawing.Point(35, 418);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(103, 26);
            this.lbl_telefono.TabIndex = 54;
            this.lbl_telefono.Text = "Nro. Telefono:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(144, 477);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "Ej.: example@cumbancha.com.ar";
            this.txt_email.Size = new System.Drawing.Size(157, 27);
            this.txt_email.TabIndex = 57;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.Location = new System.Drawing.Point(35, 480);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(103, 26);
            this.lbl_email.TabIndex = 56;
            this.lbl_email.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "*sin (0) ni (15)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(35, 102);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(103, 26);
            this.lbl_apellido.TabIndex = 41;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_error
            // 
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(27, 518);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(274, 62);
            this.lbl_error.TabIndex = 59;
            this.lbl_error.Text = "lbl_error";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_error.Visible = false;
            // 
            // lbl_mayor
            // 
            this.lbl_mayor.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mayor.ForeColor = System.Drawing.Color.Black;
            this.lbl_mayor.Location = new System.Drawing.Point(222, 300);
            this.lbl_mayor.Name = "lbl_mayor";
            this.lbl_mayor.Size = new System.Drawing.Size(79, 21);
            this.lbl_mayor.TabIndex = 60;
            this.lbl_mayor.Text = "Mayor de 18";
            // 
            // frm_nuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 665);
            this.Controls.Add(this.lbl_mayor);
            this.Controls.Add(this.lbl_error);
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
            this.Controls.Add(this.btn_cancelarCargaVuelo);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_nuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frm_nuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelarCargaVuelo;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_pasaporte;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_pasaporte;
        private System.Windows.Forms.Label lbl_mensajeDni;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.Label lbl_datosPersonales;
        private System.Windows.Forms.Label lbl_datosContacto;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_mayor;
    }
}
