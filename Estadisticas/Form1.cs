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
        List<Facturacion> listaDeFacturas;
        public Form1()
        {
            InitializeComponent();
        }
        private void CambiarLblVisible(bool trueOFalse)
        {
            lbl_muestraDestinoMasVisitado.Visible = trueOFalse;
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
            lbl_muestraRecNacionales.Text = Estadistica.CalcularImportesEstadisticosTipoDestino(Facturacion.listaDeFacturas, "Nacional0").ToString();
            lbl_muestraRecPremium.Text = Estadistica.CalcularImportesEstadisticosClase(Facturacion.listaDeFacturas, "Premium").ToString();
            lbl_muestraRecTurista.Text = Estadistica.CalcularImportesEstadisticosClase(Facturacion.listaDeFacturas, "Turista").ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Facturacion.listaDeFacturas = Facturacion.FacturarDesdeHarcodeo(Venta.listaDeVuelos);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
