﻿using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmETicket
{
    public partial class frm_emitirEticket : Form
    {


        private Vuelo vueloSeleccionado;
        List<Pasajero> listaPasajerosAFacturar = new List<Pasajero>();


        public frm_emitirEticket()
        {
            InitializeComponent();
        }
        public frm_emitirEticket(List<Pasajero> listaPasajerosASubir, Vuelo vueloSelect):this()
        {
            vueloSeleccionado = vueloSelect;
            listaPasajerosAFacturar = listaPasajerosASubir;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_muestraClase.Text = Pasajero.TraerNombreDeClase(listaPasajerosAFacturar[0]);
            dtg_pasajerosAFacturar.DataSource = listaPasajerosAFacturar;
            lbl_muestraOrigen.Text = vueloSeleccionado.OrigenVuelo;
            lbl_muestraDestino.Text = vueloSeleccionado.DestinoVuelo;
            lbl_muestraFecha.Text = vueloSeleccionado.FechaVuelo;
            lbl_muestraHorario.Text = vueloSeleccionado.HoraPartidaVuelo.ToString();
            lbl_muestraDuracion.Text = vueloSeleccionado.DuracionVuelo.ToString();
            lbl_muestraVuelo.Text = vueloSeleccionado.CodigoDeVuelo;

            decimal impPais, impUtn, impTazasYCargas, vueloNeto, total = 0;

            Facturacion facturar = new Facturacion();
            vueloNeto = Facturacion.CalcularValorVueloNeto(vueloSeleccionado, listaPasajerosAFacturar[0].ViajaEnTurista, listaPasajerosAFacturar.Count());
            impPais = Facturacion.CalcularImpuestos(vueloNeto, facturar.ValorImpuestoPais);
            impUtn = Facturacion.CalcularImpuestos(vueloNeto, facturar.ValorImpuestoUtn);
            impTazasYCargas = Facturacion.CalcularImpuestos(vueloNeto, facturar.ValorImpTazasYCargos);
            total = impPais + impUtn + impTazasYCargas + vueloNeto;
            lbl_totalVuelo.Text = vueloNeto.ToString();
            lbl_muestraImpuestoPais.Text = impPais.ToString();
            lbl_muestraImpuestoUTN.Text = impUtn.ToString();
            lbl_muestraImpuestoTazasYCargos.Text = impTazasYCargas.ToString();
            
            lbl_muestraImporteFinal.Text = total.ToString();
        }

        private void btn_emitirTicket_Click(object sender, EventArgs e)
        {
            vueloSeleccionado.ListaDePasajeros.AddRange(listaPasajerosAFacturar);
            Vuelo.ModificarCantPasajerosEnVuelo(vueloSeleccionado,listaPasajerosAFacturar);
            Vuelo.ModificarCantValijasEnBodega(vueloSeleccionado, listaPasajerosAFacturar);
            MessageBox.Show("Ticket emitido con exito \nGracias por viajar con Cumbancha Volante", "", MessageBoxButtons.OK);
            this.Close();
        }

    }
}
