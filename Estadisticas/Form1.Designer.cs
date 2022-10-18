namespace Estadisticas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtg_estadisticas = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.rdb_destinosMasVisitados = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl_destinoMasPedido = new System.Windows.Forms.Label();
            this.lbl_muestraRecTurista = new System.Windows.Forms.Label();
            this.lbl_muestraRecPremium = new System.Windows.Forms.Label();
            this.lbl_muestraRecNacionales = new System.Windows.Forms.Label();
            this.lbl_muestraRecInternacionales = new System.Windows.Forms.Label();
            this.lbl_muestraGananciasNetas = new System.Windows.Forms.Label();
            this.lbl_muestraImpuestos = new System.Windows.Forms.Label();
            this.lbl_muestraFacTotal = new System.Windows.Forms.Label();
            this.lbl_muestraDestinoMasVisitado = new System.Windows.Forms.Label();
            this.btn_calcularEstadisticas = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_estadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_estadisticas
            // 
            this.dtg_estadisticas.BackgroundColor = System.Drawing.Color.White;
            this.dtg_estadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_estadisticas.Location = new System.Drawing.Point(75, 402);
            this.dtg_estadisticas.Name = "dtg_estadisticas";
            this.dtg_estadisticas.RowHeadersWidth = 51;
            this.dtg_estadisticas.RowTemplate.Height = 29;
            this.dtg_estadisticas.Size = new System.Drawing.Size(814, 195);
            this.dtg_estadisticas.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Simpsonfont", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_titulo.Location = new System.Drawing.Point(316, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(329, 48);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Estadisticas";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdb_destinosMasVisitados
            // 
            this.rdb_destinosMasVisitados.AutoSize = true;
            this.rdb_destinosMasVisitados.BackColor = System.Drawing.Color.Transparent;
            this.rdb_destinosMasVisitados.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rdb_destinosMasVisitados.ForeColor = System.Drawing.Color.Navy;
            this.rdb_destinosMasVisitados.Location = new System.Drawing.Point(95, 368);
            this.rdb_destinosMasVisitados.Name = "rdb_destinosMasVisitados";
            this.rdb_destinosMasVisitados.Size = new System.Drawing.Size(232, 28);
            this.rdb_destinosMasVisitados.TabIndex = 2;
            this.rdb_destinosMasVisitados.TabStop = true;
            this.rdb_destinosMasVisitados.Text = "Destinos Mas Visitados";
            this.rdb_destinosMasVisitados.UseVisualStyleBackColor = false;
            this.rdb_destinosMasVisitados.CheckedChanged += new System.EventHandler(this.rdb_destinosMasVisitados_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(75, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recaudacion Clase Turista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(75, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recaudacion Clase Premium";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(75, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recaudacion Vuelos Nacionales";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(75, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recaudacion Vuelos Internacionales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(75, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ganancias Netas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(75, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Impuestos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(637, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Facturacion Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(95, 336);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(297, 28);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Destinos Con Mas recaudacion";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_destinoMasPedido
            // 
            this.lbl_destinoMasPedido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_destinoMasPedido.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_destinoMasPedido.ForeColor = System.Drawing.Color.Navy;
            this.lbl_destinoMasPedido.Location = new System.Drawing.Point(409, 372);
            this.lbl_destinoMasPedido.Name = "lbl_destinoMasPedido";
            this.lbl_destinoMasPedido.Size = new System.Drawing.Size(236, 23);
            this.lbl_destinoMasPedido.TabIndex = 15;
            this.lbl_destinoMasPedido.Text = "Destino mas pedido";
            this.lbl_destinoMasPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_muestraRecTurista
            // 
            this.lbl_muestraRecTurista.AutoSize = true;
            this.lbl_muestraRecTurista.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraRecTurista.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraRecTurista.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraRecTurista.Location = new System.Drawing.Point(416, 69);
            this.lbl_muestraRecTurista.Name = "lbl_muestraRecTurista";
            this.lbl_muestraRecTurista.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraRecTurista.TabIndex = 16;
            this.lbl_muestraRecTurista.Text = "$$$$$$";
            this.lbl_muestraRecTurista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraRecTurista.Visible = false;
            // 
            // lbl_muestraRecPremium
            // 
            this.lbl_muestraRecPremium.AutoSize = true;
            this.lbl_muestraRecPremium.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraRecPremium.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraRecPremium.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraRecPremium.Location = new System.Drawing.Point(416, 109);
            this.lbl_muestraRecPremium.Name = "lbl_muestraRecPremium";
            this.lbl_muestraRecPremium.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraRecPremium.TabIndex = 17;
            this.lbl_muestraRecPremium.Text = "$$$$$$";
            this.lbl_muestraRecPremium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraRecPremium.Visible = false;
            // 
            // lbl_muestraRecNacionales
            // 
            this.lbl_muestraRecNacionales.AutoSize = true;
            this.lbl_muestraRecNacionales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraRecNacionales.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraRecNacionales.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraRecNacionales.Location = new System.Drawing.Point(416, 165);
            this.lbl_muestraRecNacionales.Name = "lbl_muestraRecNacionales";
            this.lbl_muestraRecNacionales.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraRecNacionales.TabIndex = 18;
            this.lbl_muestraRecNacionales.Text = "$$$$$$";
            this.lbl_muestraRecNacionales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraRecNacionales.Visible = false;
            // 
            // lbl_muestraRecInternacionales
            // 
            this.lbl_muestraRecInternacionales.AutoSize = true;
            this.lbl_muestraRecInternacionales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraRecInternacionales.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraRecInternacionales.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraRecInternacionales.Location = new System.Drawing.Point(416, 203);
            this.lbl_muestraRecInternacionales.Name = "lbl_muestraRecInternacionales";
            this.lbl_muestraRecInternacionales.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraRecInternacionales.TabIndex = 19;
            this.lbl_muestraRecInternacionales.Text = "$$$$$$";
            this.lbl_muestraRecInternacionales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraRecInternacionales.Visible = false;
            // 
            // lbl_muestraGananciasNetas
            // 
            this.lbl_muestraGananciasNetas.AutoSize = true;
            this.lbl_muestraGananciasNetas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraGananciasNetas.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraGananciasNetas.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraGananciasNetas.Location = new System.Drawing.Point(416, 245);
            this.lbl_muestraGananciasNetas.Name = "lbl_muestraGananciasNetas";
            this.lbl_muestraGananciasNetas.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraGananciasNetas.TabIndex = 20;
            this.lbl_muestraGananciasNetas.Text = "$$$$$$";
            this.lbl_muestraGananciasNetas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraGananciasNetas.Visible = false;
            // 
            // lbl_muestraImpuestos
            // 
            this.lbl_muestraImpuestos.AutoSize = true;
            this.lbl_muestraImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpuestos.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpuestos.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraImpuestos.Location = new System.Drawing.Point(416, 284);
            this.lbl_muestraImpuestos.Name = "lbl_muestraImpuestos";
            this.lbl_muestraImpuestos.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraImpuestos.TabIndex = 21;
            this.lbl_muestraImpuestos.Text = "$$$$$$";
            this.lbl_muestraImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraImpuestos.Visible = false;
            // 
            // lbl_muestraFacTotal
            // 
            this.lbl_muestraFacTotal.AutoSize = true;
            this.lbl_muestraFacTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraFacTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraFacTotal.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraFacTotal.Location = new System.Drawing.Point(802, 245);
            this.lbl_muestraFacTotal.Name = "lbl_muestraFacTotal";
            this.lbl_muestraFacTotal.Size = new System.Drawing.Size(82, 24);
            this.lbl_muestraFacTotal.TabIndex = 22;
            this.lbl_muestraFacTotal.Text = "$$$$$$";
            this.lbl_muestraFacTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraFacTotal.Visible = false;
            // 
            // lbl_muestraDestinoMasVisitado
            // 
            this.lbl_muestraDestinoMasVisitado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraDestinoMasVisitado.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraDestinoMasVisitado.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraDestinoMasVisitado.Location = new System.Drawing.Point(652, 375);
            this.lbl_muestraDestinoMasVisitado.Name = "lbl_muestraDestinoMasVisitado";
            this.lbl_muestraDestinoMasVisitado.Size = new System.Drawing.Size(237, 24);
            this.lbl_muestraDestinoMasVisitado.TabIndex = 23;
            this.lbl_muestraDestinoMasVisitado.Text = "$$$$$$";
            this.lbl_muestraDestinoMasVisitado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_muestraDestinoMasVisitado.Visible = false;
            // 
            // btn_calcularEstadisticas
            // 
            this.btn_calcularEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_calcularEstadisticas.Font = new System.Drawing.Font("Simpsonfont", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_calcularEstadisticas.Location = new System.Drawing.Point(617, 69);
            this.btn_calcularEstadisticas.Name = "btn_calcularEstadisticas";
            this.btn_calcularEstadisticas.Size = new System.Drawing.Size(266, 96);
            this.btn_calcularEstadisticas.TabIndex = 24;
            this.btn_calcularEstadisticas.Text = "Calcular Estadisticas";
            this.btn_calcularEstadisticas.UseVisualStyleBackColor = false;
            this.btn_calcularEstadisticas.Click += new System.EventHandler(this.btn_calcularEstadisticas_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.Font = new System.Drawing.Font("Simpsonfont", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(747, 603);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(142, 48);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 666);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_calcularEstadisticas);
            this.Controls.Add(this.lbl_muestraDestinoMasVisitado);
            this.Controls.Add(this.lbl_muestraFacTotal);
            this.Controls.Add(this.lbl_muestraImpuestos);
            this.Controls.Add(this.lbl_muestraGananciasNetas);
            this.Controls.Add(this.lbl_muestraRecInternacionales);
            this.Controls.Add(this.lbl_muestraRecNacionales);
            this.Controls.Add(this.lbl_muestraRecPremium);
            this.Controls.Add(this.lbl_muestraRecTurista);
            this.Controls.Add(this.lbl_destinoMasPedido);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdb_destinosMasVisitados);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dtg_estadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_estadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_estadisticas;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.RadioButton rdb_destinosMasVisitados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lbl_destinoMasPedido;
        private System.Windows.Forms.Label lbl_muestraRecTurista;
        private System.Windows.Forms.Label lbl_muestraRecPremium;
        private System.Windows.Forms.Label lbl_muestraRecNacionales;
        private System.Windows.Forms.Label lbl_muestraRecInternacionales;
        private System.Windows.Forms.Label lbl_muestraGananciasNetas;
        private System.Windows.Forms.Label lbl_muestraImpuestos;
        private System.Windows.Forms.Label lbl_muestraFacTotal;
        private System.Windows.Forms.Label lbl_muestraDestinoMasVisitado;
        private System.Windows.Forms.Button btn_calcularEstadisticas;
        private System.Windows.Forms.Button btn_salir;
    }
}
