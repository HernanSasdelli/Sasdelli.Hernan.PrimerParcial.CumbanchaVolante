using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Estadistica
    {

        public static decimal CalcularImportesEstadisticosClase(List<Factura> listaDeFacturas, string parametroClase)
        {
            decimal acumuladorClase=0;

            if(listaDeFacturas != null && parametroClase != null)
            {
                foreach(Factura unaFactura in listaDeFacturas)
                {
                    if(unaFactura.Clase == parametroClase)
                    {
                        acumuladorClase = acumuladorClase + unaFactura.ImporteNeto;
                    }
                }
            }
            return acumuladorClase;
        }
        public static decimal CalcularImportesEstadisticosTipoDestino(List<Factura> listaDeFacturas, string tipoDestino)
        {
            decimal acumuladorDestino = 0;

            if (listaDeFacturas != null && tipoDestino != null)
            {
                foreach (Factura unaFactura in listaDeFacturas)
                {
                    if (unaFactura.TipoDestino == tipoDestino)
                    {
                        acumuladorDestino = acumuladorDestino + unaFactura.ImporteNeto;
                    }
                }
            }
            return acumuladorDestino;
        }
        public static decimal SumarGananciasNetas(List<Factura> listaDeFacturas)
        {
            decimal gananciasNetas = 0;

            if (listaDeFacturas != null)
            {
                foreach (Factura unaFactura in listaDeFacturas)
                {
                    gananciasNetas = gananciasNetas + unaFactura.ImporteNeto;
                }
            }
            return gananciasNetas;
        }


        public static decimal CalcularImpuestos(List<Factura> listaDeFacturas)
        {
            decimal impuestos = 0;
            decimal diferencia;

            if (listaDeFacturas != null)
            {
                foreach (Factura unaFactura in listaDeFacturas)
                {
                    diferencia = unaFactura.ImporteTotal - unaFactura.ImporteNeto;
                    impuestos = impuestos + diferencia;
                }
            }
            return impuestos;
        }
        public static decimal CalcularFacturacionTotal(List<Factura> listaDeFacturas)
        {
            decimal FacturacionTotal = 0;

            if (listaDeFacturas != null)
            {
                foreach (Factura unaFactura in listaDeFacturas)
                {
                    FacturacionTotal = FacturacionTotal + unaFactura.ImporteTotal;

                }
            }
            return FacturacionTotal;
        }






    }
}
