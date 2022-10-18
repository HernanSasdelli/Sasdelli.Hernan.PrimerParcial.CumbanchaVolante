using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadisticas
{
    public partial class Form1 : Form
    {
        
        List<Estadistica> estadisticaDestinos;
        public Form1()
        {
            InitializeComponent();
        }
        private void CambiarLblVisible(bool trueOFalse)
        {

            lbl_muestraFacTotal.Visible = trueOFalse;
            lbl_muestraGananciasNetas.Visible = trueOFalse;
            lbl_muestraImpuestos.Visible = trueOFalse;
            lbl_muestraRecInternacionales.Visible = trueOFalse;
            lbl_muestraRecNacionales.Visible = trueOFalse;
            lbl_muestraRecPremium.Visible = trueOFalse;
            lbl_muestraRecTurista.Visible = trueOFalse;
            
        }

        private void btn_calcularEstadisticas_Click(object sender, EventArgs e)
        {
            CambiarLblVisible(true);
            //lbl_muestraDestinoMasVisitado.Text =;
            Facturacion.listaDeFacturas = Facturacion.FacturarDesdeHarcodeo(Venta.listaDeVuelos);
            lbl_muestraFacTotal.Text = Estadistica.CalcularFacturacionTotal(Facturacion.listaDeFacturas).ToString();
            lbl_muestraGananciasNetas.Text = Estadistica.SumarGananciasNetas(Facturacion.listaDeFacturas).ToString();
            lbl_muestraImpuestos.Text = Estadistica.CalcularImpuestos(Facturacion.listaDeFacturas).ToString();
            lbl_muestraRecInternacionales.Text = Estadistica.CalcularImportesEstadisticosTipoDestino(Facturacion.listaDeFacturas, "Internacional").ToString();
            lbl_muestraRecNacionales.Text = Estadistica.CalcularImportesEstadisticosTipoDestino(Facturacion.listaDeFacturas, "Nacional").ToString();
            lbl_muestraRecPremium.Text = Estadistica.CalcularImportesEstadisticosClase(Facturacion.listaDeFacturas, "Premium").ToString();
            lbl_muestraRecTurista.Text = Estadistica.CalcularImportesEstadisticosClase(Facturacion.listaDeFacturas, "Turista").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Facturacion.listaDeFacturas = Facturacion.FacturarDesdeHarcodeo(Venta.listaDeVuelos);            
            estadisticaDestinos=Estadistica.CalcularEstadisticasPorDestino(Facturacion.listaDeFacturas);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            List<Estadistica> destinoOrdenadoPorFacturacion = estadisticaDestinos.OrderByDescending(destino => destino.CantidadDeVecesPedidos).ToList();
            dtg_estadisticas.DataSource = destinoOrdenadoPorFacturacion;
            lbl_destinoMasPedido.Text = "Destino mejor Facturado";
            lbl_muestraDestinoMasVisitado.Text = destinoOrdenadoPorFacturacion[0].Destino;
                lbl_muestraDestinoMasVisitado.Visible = true;

        }

        private void rdb_destinosMasVisitados_CheckedChanged(object sender, EventArgs e)
        {
            List<Estadistica> destinoOrdenadoPorVisitas= estadisticaDestinos.OrderByDescending(destino => destino.CantidadDeVecesPedidos).ToList();
            dtg_estadisticas.DataSource = destinoOrdenadoPorVisitas;
            lbl_destinoMasPedido.Text = "Destino Mas Pedido";
            lbl_muestraDestinoMasVisitado.Text = destinoOrdenadoPorVisitas[0].Destino;
            lbl_muestraDestinoMasVisitado.Visible = true;
        }
    }
}
