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
            System.Windows.Forms.Button btn_cancelarTodo;
            this.lbl_totalVuelo = new System.Windows.Forms.Label();
            this.lbl_muestraImpuestoUTN = new System.Windows.Forms.Label();
            this.lbl_muestraImpuestoPais = new System.Windows.Forms.Label();
            this.lbl_muestraImpuestoTazasYCargos = new System.Windows.Forms.Label();
            this.lbl_muestraImporteFinal = new System.Windows.Forms.Label();
            this.lbl_totalTotal = new System.Windows.Forms.Label();
            this.lbl_impuestosUtn = new System.Windows.Forms.Label();
            this.lbl_impuestosPais = new System.Windows.Forms.Label();
            this.lbl_impuestos = new System.Windows.Forms.Label();
            this.lbl_importeTotal = new System.Windows.Forms.Label();
            this.lbl_muestraDestino = new System.Windows.Forms.Label();
            this.lbl_muestraOrigen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_muestraVuelo = new System.Windows.Forms.Label();
            this.lbl_vuelo = new System.Windows.Forms.Label();
            this.lbl_muestraClase = new System.Windows.Forms.Label();
            this.lbl_clase = new System.Windows.Forms.Label();
            this.lbl_muestraFecha = new System.Windows.Forms.Label();
            this.lbl_muestraHorario = new System.Windows.Forms.Label();
            this.lbl_muestraDuracion = new System.Windows.Forms.Label();
            this.dtg_pasajerosAFacturar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hs1 = new System.Windows.Forms.Label();
            this.lbl_hs2 = new System.Windows.Forms.Label();
            btn_emitirTicket = new System.Windows.Forms.Button();
            btn_cancelarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pasajerosAFacturar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_emitirTicket
            // 
            btn_emitirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            btn_emitirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_emitirTicket.Font = new System.Drawing.Font("Simpsonfont", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            btn_emitirTicket.ForeColor = System.Drawing.Color.Black;
            btn_emitirTicket.Location = new System.Drawing.Point(657, 316);
            btn_emitirTicket.Name = "btn_emitirTicket";
            btn_emitirTicket.Size = new System.Drawing.Size(152, 72);
            btn_emitirTicket.TabIndex = 130;
            btn_emitirTicket.Text = "Emitir Ticket";
            btn_emitirTicket.UseVisualStyleBackColor = false;
            btn_emitirTicket.Click += new System.EventHandler(this.btn_emitirTicket_Click);
            // 
            // btn_cancelarTodo
            // 
            btn_cancelarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_cancelarTodo.Font = new System.Drawing.Font("Simpsonfont", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            btn_cancelarTodo.ForeColor = System.Drawing.Color.Black;
            btn_cancelarTodo.Location = new System.Drawing.Point(722, 406);
            btn_cancelarTodo.Name = "btn_cancelarTodo";
            btn_cancelarTodo.Size = new System.Drawing.Size(87, 35);
            btn_cancelarTodo.TabIndex = 221;
            btn_cancelarTodo.Text = "Salir";
            btn_cancelarTodo.UseVisualStyleBackColor = true;
            // 
            // lbl_totalVuelo
            // 
            this.lbl_totalVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalVuelo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalVuelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_totalVuelo.Location = new System.Drawing.Point(530, 386);
            this.lbl_totalVuelo.Name = "lbl_totalVuelo";
            this.lbl_totalVuelo.Size = new System.Drawing.Size(84, 23);
            this.lbl_totalVuelo.TabIndex = 129;
            this.lbl_totalVuelo.Text = "$$$";
            this.lbl_totalVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_muestraImpuestoUTN
            // 
            this.lbl_muestraImpuestoUTN.AutoSize = true;
            this.lbl_muestraImpuestoUTN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpuestoUTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpuestoUTN.Location = new System.Drawing.Point(544, 356);
            this.lbl_muestraImpuestoUTN.Name = "lbl_muestraImpuestoUTN";
            this.lbl_muestraImpuestoUTN.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpuestoUTN.TabIndex = 128;
            this.lbl_muestraImpuestoUTN.Text = "$$$";
            // 
            // lbl_muestraImpuestoPais
            // 
            this.lbl_muestraImpuestoPais.AutoSize = true;
            this.lbl_muestraImpuestoPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpuestoPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpuestoPais.Location = new System.Drawing.Point(544, 336);
            this.lbl_muestraImpuestoPais.Name = "lbl_muestraImpuestoPais";
            this.lbl_muestraImpuestoPais.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpuestoPais.TabIndex = 127;
            this.lbl_muestraImpuestoPais.Text = "$$$";
            // 
            // lbl_muestraImpuestoTazasYCargos
            // 
            this.lbl_muestraImpuestoTazasYCargos.AutoSize = true;
            this.lbl_muestraImpuestoTazasYCargos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpuestoTazasYCargos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpuestoTazasYCargos.Location = new System.Drawing.Point(544, 316);
            this.lbl_muestraImpuestoTazasYCargos.Name = "lbl_muestraImpuestoTazasYCargos";
            this.lbl_muestraImpuestoTazasYCargos.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpuestoTazasYCargos.TabIndex = 126;
            this.lbl_muestraImpuestoTazasYCargos.Text = "$$$";
            // 
            // lbl_muestraImporteFinal
            // 
            this.lbl_muestraImporteFinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImporteFinal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImporteFinal.Location = new System.Drawing.Point(530, 413);
            this.lbl_muestraImporteFinal.Name = "lbl_muestraImporteFinal";
            this.lbl_muestraImporteFinal.Size = new System.Drawing.Size(84, 23);
            this.lbl_muestraImporteFinal.TabIndex = 125;
            this.lbl_muestraImporteFinal.Text = "$$$";
            this.lbl_muestraImporteFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalTotal
            // 
            this.lbl_totalTotal.AutoSize = true;
            this.lbl_totalTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalTotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalTotal.Location = new System.Drawing.Point(464, 386);
            this.lbl_totalTotal.Name = "lbl_totalTotal";
            this.lbl_totalTotal.Size = new System.Drawing.Size(60, 23);
            this.lbl_totalTotal.TabIndex = 124;
            this.lbl_totalTotal.Text = "Vuelo:";
            // 
            // lbl_impuestosUtn
            // 
            this.lbl_impuestosUtn.AutoSize = true;
            this.lbl_impuestosUtn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestosUtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestosUtn.Location = new System.Drawing.Point(408, 356);
            this.lbl_impuestosUtn.Name = "lbl_impuestosUtn";
            this.lbl_impuestosUtn.Size = new System.Drawing.Size(116, 20);
            this.lbl_impuestosUtn.TabIndex = 123;
            this.lbl_impuestosUtn.Text = "Impuesto UTN:";
            // 
            // lbl_impuestosPais
            // 
            this.lbl_impuestosPais.AutoSize = true;
            this.lbl_impuestosPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestosPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestosPais.Location = new System.Drawing.Point(412, 336);
            this.lbl_impuestosPais.Name = "lbl_impuestosPais";
            this.lbl_impuestosPais.Size = new System.Drawing.Size(112, 20);
            this.lbl_impuestosPais.TabIndex = 122;
            this.lbl_impuestosPais.Text = "Impuesto pais:";
            // 
            // lbl_impuestos
            // 
            this.lbl_impuestos.AutoSize = true;
            this.lbl_impuestos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestos.Location = new System.Drawing.Point(338, 316);
            this.lbl_impuestos.Name = "lbl_impuestos";
            this.lbl_impuestos.Size = new System.Drawing.Size(186, 20);
            this.lbl_impuestos.TabIndex = 121;
            this.lbl_impuestos.Text = "Impuesto, tazas y cargos:";
            // 
            // lbl_importeTotal
            // 
            this.lbl_importeTotal.AutoSize = true;
            this.lbl_importeTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_importeTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_importeTotal.Location = new System.Drawing.Point(400, 413);
            this.lbl_importeTotal.Name = "lbl_importeTotal";
            this.lbl_importeTotal.Size = new System.Drawing.Size(124, 23);
            this.lbl_importeTotal.TabIndex = 120;
            this.lbl_importeTotal.Text = "Importe Total:";
            this.lbl_importeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_muestraDestino
            // 
            this.lbl_muestraDestino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraDestino.Location = new System.Drawing.Point(109, 336);
            this.lbl_muestraDestino.Name = "lbl_muestraDestino";
            this.lbl_muestraDestino.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraDestino.TabIndex = 220;
            this.lbl_muestraDestino.Text = "muestra destino";
            // 
            // lbl_muestraOrigen
            // 
            this.lbl_muestraOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraOrigen.Location = new System.Drawing.Point(109, 313);
            this.lbl_muestraOrigen.Name = "lbl_muestraOrigen";
            this.lbl_muestraOrigen.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraOrigen.TabIndex = 219;
            this.lbl_muestraOrigen.Text = "muestra origen";
            // 
            // lbl_destino
            // 
            this.lbl_destino.BackColor = System.Drawing.Color.Transparent;
            this.lbl_destino.Location = new System.Drawing.Point(39, 336);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(65, 23);
            this.lbl_destino.TabIndex = 218;
            this.lbl_destino.Text = "Destino:";
            // 
            // lbl_origen
            // 
            this.lbl_origen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_origen.Location = new System.Drawing.Point(39, 313);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(64, 23);
            this.lbl_origen.TabIndex = 217;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_muestraVuelo
            // 
            this.lbl_muestraVuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraVuelo.Location = new System.Drawing.Point(659, 22);
            this.lbl_muestraVuelo.Name = "lbl_muestraVuelo";
            this.lbl_muestraVuelo.Size = new System.Drawing.Size(118, 25);
            this.lbl_muestraVuelo.TabIndex = 216;
            this.lbl_muestraVuelo.Text = "muestra vuelo";
            this.lbl_muestraVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_vuelo
            // 
            this.lbl_vuelo.AutoSize = true;
            this.lbl_vuelo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelo.Font = new System.Drawing.Font("Simpsonfont", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_vuelo.Location = new System.Drawing.Point(530, 22);
            this.lbl_vuelo.Name = "lbl_vuelo";
            this.lbl_vuelo.Size = new System.Drawing.Size(123, 25);
            this.lbl_vuelo.TabIndex = 215;
            this.lbl_vuelo.Text = "Vuelo Nro.:";
            // 
            // lbl_muestraClase
            // 
            this.lbl_muestraClase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraClase.Location = new System.Drawing.Point(606, 60);
            this.lbl_muestraClase.Name = "lbl_muestraClase";
            this.lbl_muestraClase.Size = new System.Drawing.Size(186, 23);
            this.lbl_muestraClase.TabIndex = 223;
            this.lbl_muestraClase.Text = "muestra clase";
            // 
            // lbl_clase
            // 
            this.lbl_clase.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clase.Location = new System.Drawing.Point(536, 60);
            this.lbl_clase.Name = "lbl_clase";
            this.lbl_clase.Size = new System.Drawing.Size(64, 23);
            this.lbl_clase.TabIndex = 222;
            this.lbl_clase.Text = "Clase:";
            // 
            // lbl_muestraFecha
            // 
            this.lbl_muestraFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraFecha.Location = new System.Drawing.Point(200, 377);
            this.lbl_muestraFecha.Name = "lbl_muestraFecha";
            this.lbl_muestraFecha.Size = new System.Drawing.Size(94, 23);
            this.lbl_muestraFecha.TabIndex = 225;
            this.lbl_muestraFecha.Text = "muestra fecha";
            this.lbl_muestraFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_muestraHorario
            // 
            this.lbl_muestraHorario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraHorario.Location = new System.Drawing.Point(200, 400);
            this.lbl_muestraHorario.Name = "lbl_muestraHorario";
            this.lbl_muestraHorario.Size = new System.Drawing.Size(95, 23);
            this.lbl_muestraHorario.TabIndex = 227;
            this.lbl_muestraHorario.Text = "muestra horario";
            this.lbl_muestraHorario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_muestraDuracion
            // 
            this.lbl_muestraDuracion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraDuracion.Location = new System.Drawing.Point(200, 423);
            this.lbl_muestraDuracion.Name = "lbl_muestraDuracion";
            this.lbl_muestraDuracion.Size = new System.Drawing.Size(94, 23);
            this.lbl_muestraDuracion.TabIndex = 229;
            this.lbl_muestraDuracion.Text = "muestra duracion";
            this.lbl_muestraDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_pasajerosAFacturar
            // 
            this.dtg_pasajerosAFacturar.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dtg_pasajerosAFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pasajerosAFacturar.Location = new System.Drawing.Point(29, 110);
            this.dtg_pasajerosAFacturar.Name = "dtg_pasajerosAFacturar";
            this.dtg_pasajerosAFacturar.ReadOnly = true;
            this.dtg_pasajerosAFacturar.RowHeadersWidth = 51;
            this.dtg_pasajerosAFacturar.RowTemplate.Height = 29;
            this.dtg_pasajerosAFacturar.Size = new System.Drawing.Size(780, 175);
            this.dtg_pasajerosAFacturar.TabIndex = 230;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 231;
            this.label1.Text = "Fecha Salida:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 232;
            this.label2.Text = "Hora de Salida:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 233;
            this.label3.Text = "Duracion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hs1
            // 
            this.lbl_hs1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hs1.Location = new System.Drawing.Point(288, 400);
            this.lbl_hs1.Name = "lbl_hs1";
            this.lbl_hs1.Size = new System.Drawing.Size(56, 23);
            this.lbl_hs1.TabIndex = 234;
            this.lbl_hs1.Text = "Hs.";
            this.lbl_hs1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hs2
            // 
            this.lbl_hs2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hs2.Location = new System.Drawing.Point(288, 423);
            this.lbl_hs2.Name = "lbl_hs2";
            this.lbl_hs2.Size = new System.Drawing.Size(56, 23);
            this.lbl_hs2.TabIndex = 235;
            this.lbl_hs2.Text = "Hs.";
            this.lbl_hs2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_emitirEticket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FrmETicket.Properties.Resources.Eticket2;
            this.CancelButton = btn_cancelarTodo;
            this.ClientSize = new System.Drawing.Size(1083, 478);
            this.Controls.Add(this.lbl_hs2);
            this.Controls.Add(this.lbl_hs1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_pasajerosAFacturar);
            this.Controls.Add(this.lbl_muestraDuracion);
            this.Controls.Add(this.lbl_muestraHorario);
            this.Controls.Add(this.lbl_muestraFecha);
            this.Controls.Add(this.lbl_muestraClase);
            this.Controls.Add(this.lbl_clase);
            this.Controls.Add(btn_cancelarTodo);
            this.Controls.Add(this.lbl_muestraDestino);
            this.Controls.Add(this.lbl_muestraOrigen);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.lbl_muestraVuelo);
            this.Controls.Add(this.lbl_vuelo);
            this.Controls.Add(btn_emitirTicket);
            this.Controls.Add(this.lbl_totalVuelo);
            this.Controls.Add(this.lbl_muestraImpuestoUTN);
            this.Controls.Add(this.lbl_muestraImpuestoPais);
            this.Controls.Add(this.lbl_muestraImpuestoTazasYCargos);
            this.Controls.Add(this.lbl_muestraImporteFinal);
            this.Controls.Add(this.lbl_totalTotal);
            this.Controls.Add(this.lbl_impuestosUtn);
            this.Controls.Add(this.lbl_impuestosPais);
            this.Controls.Add(this.lbl_impuestos);
            this.Controls.Add(this.lbl_importeTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_emitirEticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ETicket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pasajerosAFacturar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_emitirTicket;
        private System.Windows.Forms.Label lbl_totalVuelo;
        private System.Windows.Forms.Label lbl_muestraImpuestoUTN;
        private System.Windows.Forms.Label lbl_muestraImpuestoPais;
        private System.Windows.Forms.Label lbl_muestraImpuestoTazasYCargos;
        private System.Windows.Forms.Label lbl_muestraImporteFinal;
        private System.Windows.Forms.Label lbl_totalTotal;
        private System.Windows.Forms.Label lbl_impuestosUtn;
        private System.Windows.Forms.Label lbl_impuestosPais;
        private System.Windows.Forms.Label lbl_impuestos;
        private System.Windows.Forms.Label lbl_importeTotal;
        private System.Windows.Forms.Label lbl_muestraDestino;
        private System.Windows.Forms.Label lbl_muestraOrigen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_muestraVuelo;
        private System.Windows.Forms.Label lbl_vuelo;
        private System.Windows.Forms.Label lbl_muestraClase;
        private System.Windows.Forms.Label lbl_clase;
        private System.Windows.Forms.Label lbl_muestraFecha;
        private System.Windows.Forms.Label lbl_muestraHorario;
        private System.Windows.Forms.Label lbl_muestraDuracion;
        private System.Windows.Forms.DataGridView dtg_pasajerosAFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hs1;
        private System.Windows.Forms.Label lbl_hs2;
    }
}
