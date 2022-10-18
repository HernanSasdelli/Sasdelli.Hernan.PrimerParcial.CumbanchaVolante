using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Factura
    {
        decimal importeNeto;
        decimal importeTotal;
        string idVuelo;
        string patenteAeronave;
        int dniClienteAFacturar;
        string destino;
        string origen;
        string clase;
        string tipoDestino;
        string fechaDeFacturacion;
        string nombreAFacturar;
        string apellidoAFacturar;

        public Factura(decimal importeNeto, decimal importeTotal, 
            string idVuelo, string patenteAeronave, int dniClienteAFacturar, 
            string destino, string origen, string clase, string tipoDestino, 
            string fechaDeFacturacion, string nombreAFacturar, string apellidoAFacturar)
        {
            this.importeNeto = importeNeto;
            this.importeTotal = importeTotal;
            this.idVuelo = idVuelo;
            this.patenteAeronave = patenteAeronave;
            this.dniClienteAFacturar = dniClienteAFacturar;
            this.destino = destino;
            this.origen = origen;
            this.clase = clase;
            this.tipoDestino = tipoDestino;
            this.fechaDeFacturacion = fechaDeFacturacion;
            this.nombreAFacturar = nombreAFacturar;
            this.apellidoAFacturar = apellidoAFacturar;
        }

        public decimal ImporteNeto { get => importeNeto; set => importeNeto = value; }
        public decimal ImporteTotal { get => importeTotal; set => importeTotal = value; }
        public string IdVuelo { get => idVuelo; set => idVuelo = value; }
        public string PatenteAeronave { get => patenteAeronave; set => patenteAeronave = value; }
        public int DniClienteAFacturar { get => dniClienteAFacturar; set => dniClienteAFacturar = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Clase { get => clase; set => clase = value; }
        public string TipoDestino { get => tipoDestino; set => tipoDestino = value; }
        public string FechaDeFacturacion { get => fechaDeFacturacion; set => fechaDeFacturacion = value; }
        public string NombreAFacturar { get => nombreAFacturar; set => nombreAFacturar = value; }
        public string ApellidoAFacturar { get => apellidoAFacturar; set => apellidoAFacturar = value; }
    }









}
