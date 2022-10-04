namespace FrmETicket
{
    partial class frm_emitirEticket
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
            System.Windows.Forms.Button btn_emitirTicket;
            System.Windows.Forms.Button button1;
            this.lbl_totalVuelo = new System.Windows.Forms.Label();
            this.lbl_impuestoUTN = new System.Windows.Forms.Label();
            this.lbl_impuestoPais = new System.Windows.Forms.Label();
            this.lbl_impuestoTazasYCargos = new System.Windows.Forms.Label();
            this.lbl_importaSinImp = new System.Windows.Forms.Label();
            this.lbl_totalTotal = new System.Windows.Forms.Label();
            this.lbl_impuestosUtn = new System.Windows.Forms.Label();
            this.lbl_impuestosPais = new System.Windows.Forms.Label();
            this.lbl_impuestos = new System.Windows.Forms.Label();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.lbl_muestraDestino = new System.Windows.Forms.Label();
            this.lbl_muestraOrigen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_muestraVuelo = new System.Windows.Forms.Label();
            this.lbl_vuelo = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_pasaporte = new System.Windows.Forms.Label();
            this.lbl_bolsoDeMano = new System.Windows.Forms.Label();
            this.lbl_valijas = new System.Windows.Forms.Label();
            btn_emitirTicket = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emitirTicket
            // 
            btn_emitirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_emitirTicket.Font = new System.Drawing.Font("Simpsonfont", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            btn_emitirTicket.ForeColor = System.Drawing.Color.Black;
            btn_emitirTicket.Location = new System.Drawing.Point(652, 27);
            btn_emitirTicket.Name = "btn_emitirTicket";
            btn_emitirTicket.Size = new System.Drawing.Size(85, 69);
            btn_emitirTicket.TabIndex = 130;
            btn_emitirTicket.Text = "Emitir Ticket";
            btn_emitirTicket.UseVisualStyleBackColor = true;
            btn_emitirTicket.Click += new System.EventHandler(this.btn_emitirTicket_Click);
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Simpsonfont", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(28, 229);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 35);
            button1.TabIndex = 221;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_totalVuelo
            // 
            this.lbl_totalVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalVuelo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalVuelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_totalVuelo.Location = new System.Drawing.Point(408, 229);
            this.lbl_totalVuelo.Name = "lbl_totalVuelo";
            this.lbl_totalVuelo.Size = new System.Drawing.Size(64, 23);
            this.lbl_totalVuelo.TabIndex = 129;
            this.lbl_totalVuelo.Text = "$$$";
            this.lbl_totalVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_totalVuelo.Visible = false;
            // 
            // lbl_impuestoUTN
            // 
            this.lbl_impuestoUTN.AutoSize = true;
            this.lbl_impuestoUTN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestoUTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestoUTN.Location = new System.Drawing.Point(422, 199);
            this.lbl_impuestoUTN.Name = "lbl_impuestoUTN";
            this.lbl_impuestoUTN.Size = new System.Drawing.Size(36, 20);
            this.lbl_impuestoUTN.TabIndex = 128;
            this.lbl_impuestoUTN.Text = "$$$";
            this.lbl_impuestoUTN.Visible = false;
            // 
            // lbl_impuestoPais
            // 
            this.lbl_impuestoPais.AutoSize = true;
            this.lbl_impuestoPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestoPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestoPais.Location = new System.Drawing.Point(422, 179);
            this.lbl_impuestoPais.Name = "lbl_impuestoPais";
            this.lbl_impuestoPais.Size = new System.Drawing.Size(36, 20);
            this.lbl_impuestoPais.TabIndex = 127;
            this.lbl_impuestoPais.Text = "$$$";
            this.lbl_impuestoPais.Visible = false;
            // 
            // lbl_impuestoTazasYCargos
            // 
            this.lbl_impuestoTazasYCargos.AutoSize = true;
            this.lbl_impuestoTazasYCargos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestoTazasYCargos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestoTazasYCargos.Location = new System.Drawing.Point(422, 159);
            this.lbl_impuestoTazasYCargos.Name = "lbl_impuestoTazasYCargos";
            this.lbl_impuestoTazasYCargos.Size = new System.Drawing.Size(36, 20);
            this.lbl_impuestoTazasYCargos.TabIndex = 126;
            this.lbl_impuestoTazasYCargos.Text = "$$$";
            this.lbl_impuestoTazasYCargos.Visible = false;
            // 
            // lbl_importaSinImp
            // 
            this.lbl_importaSinImp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_importaSinImp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_importaSinImp.Location = new System.Drawing.Point(408, 256);
            this.lbl_importaSinImp.Name = "lbl_importaSinImp";
            this.lbl_importaSinImp.Size = new System.Drawing.Size(64, 23);
            this.lbl_importaSinImp.TabIndex = 125;
            this.lbl_importaSinImp.Text = "$$$";
            this.lbl_importaSinImp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_importaSinImp.Visible = false;
            // 
            // lbl_totalTotal
            // 
            this.lbl_totalTotal.AutoSize = true;
            this.lbl_totalTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalTotal.Location = new System.Drawing.Point(342, 229);
            this.lbl_totalTotal.Name = "lbl_totalTotal";
            this.lbl_totalTotal.Size = new System.Drawing.Size(60, 23);
            this.lbl_totalTotal.TabIndex = 124;
            this.lbl_totalTotal.Text = "Vuelo:";
            this.lbl_totalTotal.Visible = false;
            // 
            // lbl_impuestosUtn
            // 
            this.lbl_impuestosUtn.AutoSize = true;
            this.lbl_impuestosUtn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestosUtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestosUtn.Location = new System.Drawing.Point(286, 199);
            this.lbl_impuestosUtn.Name = "lbl_impuestosUtn";
            this.lbl_impuestosUtn.Size = new System.Drawing.Size(116, 20);
            this.lbl_impuestosUtn.TabIndex = 123;
            this.lbl_impuestosUtn.Text = "Impuesto UTN:";
            this.lbl_impuestosUtn.Visible = false;
            // 
            // lbl_impuestosPais
            // 
            this.lbl_impuestosPais.AutoSize = true;
            this.lbl_impuestosPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestosPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestosPais.Location = new System.Drawing.Point(290, 179);
            this.lbl_impuestosPais.Name = "lbl_impuestosPais";
            this.lbl_impuestosPais.Size = new System.Drawing.Size(112, 20);
            this.lbl_impuestosPais.TabIndex = 122;
            this.lbl_impuestosPais.Text = "Impuesto pais:";
            this.lbl_impuestosPais.Visible = false;
            // 
            // lbl_impuestos
            // 
            this.lbl_impuestos.AutoSize = true;
            this.lbl_impuestos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestos.Location = new System.Drawing.Point(216, 159);
            this.lbl_impuestos.Name = "lbl_impuestos";
            this.lbl_impuestos.Size = new System.Drawing.Size(186, 20);
            this.lbl_impuestos.TabIndex = 121;
            this.lbl_impuestos.Text = "Impuesto, tazas y cargos:";
            this.lbl_impuestos.Visible = false;
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_importeTotal.Location = new System.Drawing.Point(278, 256);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(124, 23);
            this.lbl_importeTotal.TabIndex = 120;
            this.lbl_importeTotal.Text = "Importe Total:";
            this.lbl_importeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_importeTotal.Visible = false;
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saludo.Font = new System.Drawing.Font("Simpsonfont", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saludo.Location = new System.Drawing.Point(641, 199);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(125, 80);
            this.lbl_saludo.TabIndex = 131;
            this.lbl_saludo.Text = "     Adios     promocion";
            this.lbl_saludo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_saludo.Visible = false;
            // 
            // lbl_muestraDestino
            // 
            this.lbl_muestraDestino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraDestino.Location = new System.Drawing.Point(308, 50);
            this.lbl_muestraDestino.Name = "lbl_muestraDestino";
            this.lbl_muestraDestino.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraDestino.TabIndex = 220;
            this.lbl_muestraDestino.Text = "Destino";
            // 
            // lbl_muestraOrigen
            // 
            this.lbl_muestraOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraOrigen.Location = new System.Drawing.Point(308, 27);
            this.lbl_muestraOrigen.Name = "lbl_muestraOrigen";
            this.lbl_muestraOrigen.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraOrigen.TabIndex = 219;
            this.lbl_muestraOrigen.Text = "Origen";
            // 
            // lbl_destino
            // 
            this.lbl_destino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_destino.Location = new System.Drawing.Point(226, 50);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(65, 23);
            this.lbl_destino.TabIndex = 218;
            this.lbl_destino.Text = "Destino:";
            // 
            // lbl_origen
            // 
            this.lbl_origen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_origen.Location = new System.Drawing.Point(227, 27);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(64, 23);
            this.lbl_origen.TabIndex = 217;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_muestraVuelo
            // 
            this.lbl_muestraVuelo.AutoSize = true;
            this.lbl_muestraVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraVuelo.Location = new System.Drawing.Point(372, 9);
            this.lbl_muestraVuelo.Name = "lbl_muestraVuelo";
            this.lbl_muestraVuelo.Size = new System.Drawing.Size(82, 20);
            this.lbl_muestraVuelo.TabIndex = 216;
            this.lbl_muestraVuelo.Text = "Vuelo Nro.:";
            // 
            // lbl_vuelo
            // 
            this.lbl_vuelo.AutoSize = true;
            this.lbl_vuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelo.Font = new System.Drawing.Font("Simpsonfont", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelo.Location = new System.Drawing.Point(226, 4);
            this.lbl_vuelo.Name = "lbl_vuelo";
            this.lbl_vuelo.Size = new System.Drawing.Size(123, 25);
            this.lbl_vuelo.TabIndex = 215;
            this.lbl_vuelo.Text = "Vuelo Nro.:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.Location = new System.Drawing.Point(21, 83);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(103, 26);
            this.lbl_apellido.TabIndex = 223;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Location = new System.Drawing.Point(146, 83);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(103, 26);
            this.lbl_nombre.TabIndex = 222;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dni.Location = new System.Drawing.Point(21, 120);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(116, 24);
            this.lbl_dni.TabIndex = 224;
            this.lbl_dni.Text = "D.N.I.:";
            // 
            // lbl_pasaporte
            // 
            this.lbl_pasaporte.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pasaporte.Location = new System.Drawing.Point(21, 154);
            this.lbl_pasaporte.Name = "lbl_pasaporte";
            this.lbl_pasaporte.Size = new System.Drawing.Size(116, 26);
            this.lbl_pasaporte.TabIndex = 225;
            this.lbl_pasaporte.Text = "Pasaporte";
            // 
            // lbl_bolsoDeMano
            // 
            this.lbl_bolsoDeMano.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bolsoDeMano.Location = new System.Drawing.Point(342, 83);
            this.lbl_bolsoDeMano.Name = "lbl_bolsoDeMano";
            this.lbl_bolsoDeMano.Size = new System.Drawing.Size(95, 23);
            this.lbl_bolsoDeMano.TabIndex = 226;
            this.lbl_bolsoDeMano.Text = "Valijas";
            this.lbl_bolsoDeMano.Visible = false;
            // 
            // lbl_valijas
            // 
            this.lbl_valijas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valijas.Location = new System.Drawing.Point(326, 106);
            this.lbl_valijas.Name = "lbl_valijas";
            this.lbl_valijas.Size = new System.Drawing.Size(111, 23);
            this.lbl_valijas.TabIndex = 227;
            this.lbl_valijas.Text = "Valijas";
            this.lbl_valijas.Visible = false;
            // 
            // frm_emitirEticket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FrmETicket.Properties.Resources.Eticket1;
            this.ClientSize = new System.Drawing.Size(815, 303);
            this.Controls.Add(this.lbl_valijas);
            this.Controls.Add(this.lbl_bolsoDeMano);
            this.Controls.Add(this.lbl_pasaporte);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(button1);
            this.Controls.Add(this.lbl_muestraDestino);
            this.Controls.Add(this.lbl_muestraOrigen);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.lbl_muestraVuelo);
            this.Controls.Add(this.lbl_vuelo);
            this.Controls.Add(this.lbl_saludo);
            this.Controls.Add(btn_emitirTicket);
            this.Controls.Add(this.lbl_totalVuelo);
            this.Controls.Add(this.lbl_impuestoUTN);
            this.Controls.Add(this.lbl_impuestoPais);
            this.Controls.Add(this.lbl_impuestoTazasYCargos);
            this.Controls.Add(this.lbl_importaSinImp);
            this.Controls.Add(this.lbl_totalTotal);
            this.Controls.Add(this.lbl_impuestosUtn);
            this.Controls.Add(this.lbl_impuestosPais);
            this.Controls.Add(this.lbl_impuestos);
            this.Controls.Add(this.lbl_importeTotal);
            this.Name = "frm_emitirEticket";
            this.Text = "ETicket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emitirTicket;
        private System.Windows.Forms.Label lbl_totalVuelo;
        private System.Windows.Forms.Label lbl_impuestoUTN;
        private System.Windows.Forms.Label lbl_impuestoPais;
        private System.Windows.Forms.Label lbl_impuestoTazasYCargos;
        private System.Windows.Forms.Label lbl_importaSinImp;
        private System.Windows.Forms.Label lbl_totalTotal;
        private System.Windows.Forms.Label lbl_impuestosUtn;
        private System.Windows.Forms.Label lbl_impuestosPais;
        private System.Windows.Forms.Label lbl_impuestos;
        private System.Windows.Forms.Label lbl_importeTotal;
        private System.Windows.Forms.Label lbl_saludo;
        private System.Windows.Forms.Label lbl_muestraDestino;
        private System.Windows.Forms.Label lbl_muestraOrigen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_muestraVuelo;
        private System.Windows.Forms.Label lbl_vuelo;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_pasaporte;
        private System.Windows.Forms.Label lbl_bolsoDeMano;
        private System.Windows.Forms.Label lbl_valijas;
    }
}
