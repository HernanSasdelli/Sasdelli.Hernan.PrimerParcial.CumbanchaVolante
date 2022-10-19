namespace FrmCambioDeprecios
{
    partial class frm_cambioPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cambioPrecio));
            this.lbl_imp = new System.Windows.Forms.Label();
            this.lbl_impuestoPais = new System.Windows.Forms.Label();
            this.lbl_utn = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ingresaImpuestoYtaza = new System.Windows.Forms.TextBox();
            this.txt_ingresaImpuestoPais = new System.Windows.Forms.TextBox();
            this.txt_ingresaImpuestoUtn = new System.Windows.Forms.TextBox();
            this.txt_ingresaHoraNac = new System.Windows.Forms.TextBox();
            this.txt_ingresaHoraInt = new System.Windows.Forms.TextBox();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cambiarImpTaz = new System.Windows.Forms.Button();
            this.btn_cambiarImpPais = new System.Windows.Forms.Button();
            this.btn_cambiarImpUTN = new System.Windows.Forms.Button();
            this.btn_cambiarHoraNac = new System.Windows.Forms.Button();
            this.btn_cambiarHoraInter = new System.Windows.Forms.Button();
            this.btn_cambiarPorcentaje = new System.Windows.Forms.Button();
            this.lbl_muestraImpYTa = new System.Windows.Forms.Label();
            this.lbl_muestraImpPais = new System.Windows.Forms.Label();
            this.lbl_muestraImpUtn = new System.Windows.Forms.Label();
            this.lbl_muestraCostoNacional = new System.Windows.Forms.Label();
            this.lbl_muestraCostoInternacional = new System.Windows.Forms.Label();
            this.lbl_muestraPorcentaje = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_imp
            // 
            this.lbl_imp.AutoSize = true;
            this.lbl_imp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_imp.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_imp.ForeColor = System.Drawing.Color.Navy;
            this.lbl_imp.Location = new System.Drawing.Point(12, 62);
            this.lbl_imp.Name = "lbl_imp";
            this.lbl_imp.Size = new System.Drawing.Size(313, 24);
            this.lbl_imp.TabIndex = 0;
            this.lbl_imp.Text = "Cambiar impuestos, tazas y cargos:";
            // 
            // lbl_impuestoPais
            // 
            this.lbl_impuestoPais.AutoSize = true;
            this.lbl_impuestoPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_impuestoPais.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_impuestoPais.Location = new System.Drawing.Point(12, 126);
            this.lbl_impuestoPais.Name = "lbl_impuestoPais";
            this.lbl_impuestoPais.Size = new System.Drawing.Size(130, 24);
            this.lbl_impuestoPais.TabIndex = 1;
            this.lbl_impuestoPais.Text = "Impuesto Pais:";
            // 
            // lbl_utn
            // 
            this.lbl_utn.AutoSize = true;
            this.lbl_utn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_utn.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_utn.ForeColor = System.Drawing.Color.Navy;
            this.lbl_utn.Location = new System.Drawing.Point(12, 191);
            this.lbl_utn.Name = "lbl_utn";
            this.lbl_utn.Size = new System.Drawing.Size(133, 24);
            this.lbl_utn.TabIndex = 2;
            this.lbl_utn.Text = "Impuesto UTN:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Simpsonfont", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_aceptar.Location = new System.Drawing.Point(259, 496);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(165, 65);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Costo Vuelo Nacional Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(10, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo Vuelo Internacional Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Simpsonfont", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porcentaje para Clase Premium:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Simpsonfont", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cambio de precios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Simpsonfont", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(335, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Actual";
            // 
            // txt_ingresaImpuestoYtaza
            // 
            this.txt_ingresaImpuestoYtaza.Location = new System.Drawing.Point(141, 89);
            this.txt_ingresaImpuestoYtaza.Name = "txt_ingresaImpuestoYtaza";
            this.txt_ingresaImpuestoYtaza.Size = new System.Drawing.Size(69, 27);
            this.txt_ingresaImpuestoYtaza.TabIndex = 9;
            // 
            // txt_ingresaImpuestoPais
            // 
            this.txt_ingresaImpuestoPais.Location = new System.Drawing.Point(141, 150);
            this.txt_ingresaImpuestoPais.Name = "txt_ingresaImpuestoPais";
            this.txt_ingresaImpuestoPais.Size = new System.Drawing.Size(69, 27);
            this.txt_ingresaImpuestoPais.TabIndex = 10;
            // 
            // txt_ingresaImpuestoUtn
            // 
            this.txt_ingresaImpuestoUtn.Location = new System.Drawing.Point(141, 218);
            this.txt_ingresaImpuestoUtn.Name = "txt_ingresaImpuestoUtn";
            this.txt_ingresaImpuestoUtn.Size = new System.Drawing.Size(69, 27);
            this.txt_ingresaImpuestoUtn.TabIndex = 11;
            // 
            // txt_ingresaHoraNac
            // 
            this.txt_ingresaHoraNac.Location = new System.Drawing.Point(141, 284);
            this.txt_ingresaHoraNac.Name = "txt_ingresaHoraNac";
            this.txt_ingresaHoraNac.Size = new System.Drawing.Size(69, 27);
            this.txt_ingresaHoraNac.TabIndex = 12;
            // 
            // txt_ingresaHoraInt
            // 
            this.txt_ingresaHoraInt.Location = new System.Drawing.Point(141, 362);
            this.txt_ingresaHoraInt.Name = "txt_ingresaHoraInt";
            this.txt_ingresaHoraInt.Size = new System.Drawing.Size(69, 27);
            this.txt_ingresaHoraInt.TabIndex = 13;
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(141, 443);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(69, 27);
            this.txt_porcentaje.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(23, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nuevo valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(23, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nuevo valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(27, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nuevo valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(23, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nuevo valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(23, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nuevo valor:";
            // 
            // btn_cambiarImpTaz
            // 
            this.btn_cambiarImpTaz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarImpTaz.Location = new System.Drawing.Point(247, 89);
            this.btn_cambiarImpTaz.Name = "btn_cambiarImpTaz";
            this.btn_cambiarImpTaz.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarImpTaz.TabIndex = 20;
            this.btn_cambiarImpTaz.Text = "Cambiar";
            this.btn_cambiarImpTaz.UseVisualStyleBackColor = true;
            this.btn_cambiarImpTaz.Click += new System.EventHandler(this.btn_cambiarImpTaz_Click);
            // 
            // btn_cambiarImpPais
            // 
            this.btn_cambiarImpPais.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarImpPais.Location = new System.Drawing.Point(247, 150);
            this.btn_cambiarImpPais.Name = "btn_cambiarImpPais";
            this.btn_cambiarImpPais.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarImpPais.TabIndex = 21;
            this.btn_cambiarImpPais.Text = "Cambiar";
            this.btn_cambiarImpPais.UseVisualStyleBackColor = true;
            this.btn_cambiarImpPais.Click += new System.EventHandler(this.btn_cambiarImpPais_Click);
            // 
            // btn_cambiarImpUTN
            // 
            this.btn_cambiarImpUTN.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarImpUTN.Location = new System.Drawing.Point(247, 217);
            this.btn_cambiarImpUTN.Name = "btn_cambiarImpUTN";
            this.btn_cambiarImpUTN.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarImpUTN.TabIndex = 22;
            this.btn_cambiarImpUTN.Text = "Cambiar";
            this.btn_cambiarImpUTN.UseVisualStyleBackColor = true;
            this.btn_cambiarImpUTN.Click += new System.EventHandler(this.btn_cambiarImpUTN_Click);
            // 
            // btn_cambiarHoraNac
            // 
            this.btn_cambiarHoraNac.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarHoraNac.Location = new System.Drawing.Point(247, 284);
            this.btn_cambiarHoraNac.Name = "btn_cambiarHoraNac";
            this.btn_cambiarHoraNac.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarHoraNac.TabIndex = 23;
            this.btn_cambiarHoraNac.Text = "Cambiar";
            this.btn_cambiarHoraNac.UseVisualStyleBackColor = true;
            this.btn_cambiarHoraNac.Click += new System.EventHandler(this.btn_cambiarHoraNac_Click);
            // 
            // btn_cambiarHoraInter
            // 
            this.btn_cambiarHoraInter.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarHoraInter.Location = new System.Drawing.Point(247, 361);
            this.btn_cambiarHoraInter.Name = "btn_cambiarHoraInter";
            this.btn_cambiarHoraInter.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarHoraInter.TabIndex = 24;
            this.btn_cambiarHoraInter.Text = "Cambiar";
            this.btn_cambiarHoraInter.UseVisualStyleBackColor = true;
            this.btn_cambiarHoraInter.Click += new System.EventHandler(this.btn_cambiarHoraInter_Click);
            // 
            // btn_cambiarPorcentaje
            // 
            this.btn_cambiarPorcentaje.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarPorcentaje.Location = new System.Drawing.Point(247, 443);
            this.btn_cambiarPorcentaje.Name = "btn_cambiarPorcentaje";
            this.btn_cambiarPorcentaje.Size = new System.Drawing.Size(89, 27);
            this.btn_cambiarPorcentaje.TabIndex = 25;
            this.btn_cambiarPorcentaje.Text = "Cambiar";
            this.btn_cambiarPorcentaje.UseVisualStyleBackColor = true;
            this.btn_cambiarPorcentaje.Click += new System.EventHandler(this.btn_cambiarPorcentaje_Click);
            // 
            // lbl_muestraImpYTa
            // 
            this.lbl_muestraImpYTa.AutoSize = true;
            this.lbl_muestraImpYTa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpYTa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpYTa.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraImpYTa.Location = new System.Drawing.Point(378, 92);
            this.lbl_muestraImpYTa.Name = "lbl_muestraImpYTa";
            this.lbl_muestraImpYTa.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpYTa.TabIndex = 26;
            this.lbl_muestraImpYTa.Text = "$$$";
            // 
            // lbl_muestraImpPais
            // 
            this.lbl_muestraImpPais.AutoSize = true;
            this.lbl_muestraImpPais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpPais.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraImpPais.Location = new System.Drawing.Point(378, 157);
            this.lbl_muestraImpPais.Name = "lbl_muestraImpPais";
            this.lbl_muestraImpPais.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpPais.TabIndex = 27;
            this.lbl_muestraImpPais.Text = "$$$";
            // 
            // lbl_muestraImpUtn
            // 
            this.lbl_muestraImpUtn.AutoSize = true;
            this.lbl_muestraImpUtn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraImpUtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraImpUtn.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraImpUtn.Location = new System.Drawing.Point(378, 221);
            this.lbl_muestraImpUtn.Name = "lbl_muestraImpUtn";
            this.lbl_muestraImpUtn.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraImpUtn.TabIndex = 28;
            this.lbl_muestraImpUtn.Text = "$$$";
            // 
            // lbl_muestraCostoNacional
            // 
            this.lbl_muestraCostoNacional.AutoSize = true;
            this.lbl_muestraCostoNacional.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraCostoNacional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraCostoNacional.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraCostoNacional.Location = new System.Drawing.Point(378, 291);
            this.lbl_muestraCostoNacional.Name = "lbl_muestraCostoNacional";
            this.lbl_muestraCostoNacional.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraCostoNacional.TabIndex = 29;
            this.lbl_muestraCostoNacional.Text = "$$$";
            // 
            // lbl_muestraCostoInternacional
            // 
            this.lbl_muestraCostoInternacional.AutoSize = true;
            this.lbl_muestraCostoInternacional.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraCostoInternacional.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraCostoInternacional.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraCostoInternacional.Location = new System.Drawing.Point(378, 368);
            this.lbl_muestraCostoInternacional.Name = "lbl_muestraCostoInternacional";
            this.lbl_muestraCostoInternacional.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraCostoInternacional.TabIndex = 30;
            this.lbl_muestraCostoInternacional.Text = "$$$";
            // 
            // lbl_muestraPorcentaje
            // 
            this.lbl_muestraPorcentaje.AutoSize = true;
            this.lbl_muestraPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lbl_muestraPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muestraPorcentaje.ForeColor = System.Drawing.Color.Navy;
            this.lbl_muestraPorcentaje.Location = new System.Drawing.Point(378, 449);
            this.lbl_muestraPorcentaje.Name = "lbl_muestraPorcentaje";
            this.lbl_muestraPorcentaje.Size = new System.Drawing.Size(36, 20);
            this.lbl_muestraPorcentaje.TabIndex = 31;
            this.lbl_muestraPorcentaje.Text = "$$$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(27, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Nuevo valor:";
            // 
            // lbl_error
            // 
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_error.ForeColor = System.Drawing.Color.Navy;
            this.lbl_error.Location = new System.Drawing.Point(27, 509);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(195, 36);
            this.lbl_error.TabIndex = 33;
            this.lbl_error.Text = "error";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_error.Visible = false;
            // 
            // frm_cambioPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(466, 586);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_muestraPorcentaje);
            this.Controls.Add(this.lbl_muestraCostoInternacional);
            this.Controls.Add(this.lbl_muestraCostoNacional);
            this.Controls.Add(this.lbl_muestraImpUtn);
            this.Controls.Add(this.lbl_muestraImpPais);
            this.Controls.Add(this.lbl_muestraImpYTa);
            this.Controls.Add(this.btn_cambiarPorcentaje);
            this.Controls.Add(this.btn_cambiarHoraInter);
            this.Controls.Add(this.btn_cambiarHoraNac);
            this.Controls.Add(this.btn_cambiarImpUTN);
            this.Controls.Add(this.btn_cambiarImpPais);
            this.Controls.Add(this.btn_cambiarImpTaz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.txt_ingresaHoraInt);
            this.Controls.Add(this.txt_ingresaHoraNac);
            this.Controls.Add(this.txt_ingresaImpuestoUtn);
            this.Controls.Add(this.txt_ingresaImpuestoPais);
            this.Controls.Add(this.txt_ingresaImpuestoYtaza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_utn);
            this.Controls.Add(this.lbl_impuestoPais);
            this.Controls.Add(this.lbl_imp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cambioPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_cambioPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_imp;
        private System.Windows.Forms.Label lbl_impuestoPais;
        private System.Windows.Forms.Label lbl_utn;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ingresaImpuestoYtaza;
        private System.Windows.Forms.TextBox txt_ingresaImpuestoPais;
        private System.Windows.Forms.TextBox txt_ingresaImpuestoUtn;
        private System.Windows.Forms.TextBox txt_ingresaHoraNac;
        private System.Windows.Forms.TextBox txt_ingresaHoraInt;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cambiarImpTaz;
        private System.Windows.Forms.Button btn_cambiarImpPais;
        private System.Windows.Forms.Button btn_cambiarImpUTN;
        private System.Windows.Forms.Button btn_cambiarHoraNac;
        private System.Windows.Forms.Button btn_cambiarHoraInter;
        private System.Windows.Forms.Button btn_cambiarPorcentaje;
        private System.Windows.Forms.Label lbl_muestraImpYTa;
        private System.Windows.Forms.Label lbl_muestraImpPais;
        private System.Windows.Forms.Label lbl_muestraImpUtn;
        private System.Windows.Forms.Label lbl_muestraCostoNacional;
        private System.Windows.Forms.Label lbl_muestraCostoInternacional;
        private System.Windows.Forms.Label lbl_muestraPorcentaje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_error;
    }
}
