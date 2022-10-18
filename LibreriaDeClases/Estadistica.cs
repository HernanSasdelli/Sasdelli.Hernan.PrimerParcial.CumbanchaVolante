using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Estadistica
    {
        string destino;
        decimal acumladorDeFacturacion;
        decimal cantidadDeVecesPedidos;

        public string Destino { get => destino; set => destino = value; }
        public decimal AcumladorDeFacturacion { get => acumladorDeFacturacion; set => acumladorDeFacturacion = value; }
        public decimal CantidadDeVecesPedidos { get => cantidadDeVecesPedidos; set => cantidadDeVecesPedidos = value; }

        public Estadistica(string destino, decimal acumladorDeFacturacion, decimal cantidadDeVecesPedidos)
        {
            this.Destino = destino;
            this.AcumladorDeFacturacion = acumladorDeFacturacion;
            this.CantidadDeVecesPedidos = cantidadDeVecesPedidos;
        }

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
        /// <summary>
        /// Perdon por esta formula, acumula el importe por destino, y cantidad de veces que fue solicitado
        /// </summary>
        /// <param name="listaDeFacturacion"></param>
        /// <returns>List (string destino, int veces solicitado, decimal total recaudado)</returns>
        public static List<Estadistica> CalcularEstadisticasPorDestino(List<Factura> listaDeFacturacion)
        {
            List<Estadistica> estadisticaDestinos = new List<Estadistica>();
            string destino;
            int contadorSR=0, contadorBche = 0, contadorCor = 0, contadorCba = 0, contadorJj = 0, contadorMen = 0, contadorNq = 0,
                contadorPos = 0, contadorIg = 0, contadorSal = 0, contadorSaEs = 0, contadorTre = 0, contadorTuc = 0, contadorPM = 0,
                contadorUsh = 0, contadorBsAs = 0, contadorBrRec = 0, contadorItRo = 0, contadorMexAca = 0, contadorMiami= 0;
            decimal acumSR = 0, acumBche = 0, acumCor = 0, acumCba = 0, acumJj = 0, acumMen = 0, acumNq = 0,
                acumPos = 0, acumIg = 0, acumSal = 0, acumSaEs = 0, acumTre = 0, acumTuc = 0, acumPM = 0,
                acumUsh = 0, acumBsAs = 0, acumBrRec = 0, acumItRo = 0, acumMexAca = 0, acumMiami = 0;

            if (listaDeFacturacion != null)
            {
                
                foreach (Factura unaFactura in listaDeFacturacion)
                {
                    destino =unaFactura.Destino;
                    switch(destino)
                    {
                        case "Santa Rosa":
                            contadorSR++;
                            acumSR = acumSR + unaFactura.ImporteNeto;
                            break;
                        case "Bariloche":
                            contadorBche++;
                            acumBche = acumBche + unaFactura.ImporteNeto;
                            break;
                        case "Corrientes":
                            contadorCor++;
                            acumCor = acumCor + unaFactura.ImporteNeto;
                            break;
                        case "Cordoba":
                            contadorCba++;
                            acumCba = acumCba + unaFactura.ImporteNeto;
                            break;
                        case "Jujuy":
                            contadorJj++;
                            acumJj = acumJj + unaFactura.ImporteNeto;
                            break;
                        case "Mendoza":
                            contadorMen++;
                            acumMen = acumMen + unaFactura.ImporteNeto;
                            break;
                        case "Neuquen":
                            contadorNq++;
                            acumNq = acumNq + unaFactura.ImporteNeto;
                            break;
                        case "Posadas":
                            contadorPos++;
                            acumPos = acumPos + unaFactura.ImporteNeto;
                            break;
                        case "Iguazu":
                            contadorIg++;
                            acumIg = acumIg + unaFactura.ImporteNeto;
                            break;
                        case "Salta":
                            contadorSal++;
                            acumSal = acumSal + unaFactura.ImporteNeto;
                            break;
                        case "Santiago del Estero":
                            contadorSaEs++;
                            acumSaEs = acumSaEs + unaFactura.ImporteNeto;
                            break;
                        case "Trelew":
                            contadorTre++;
                            acumTre = acumTre + unaFactura.ImporteNeto;
                            break;
                        case "Tucuman":
                            contadorTuc++;
                            acumTuc = acumTuc + unaFactura.ImporteNeto;
                            break;
                        case "Puerto Madryn":
                            contadorPM++;
                            acumPM = acumPM + unaFactura.ImporteNeto;
                            break;
                        case "Usuaia":
                            contadorUsh++;
                            acumUsh = acumUsh + unaFactura.ImporteNeto;
                            break;
                        case "Buenos Aires":
                            contadorBsAs++;
                            acumBsAs = acumBsAs + unaFactura.ImporteNeto;
                            break;
                        case "Buenos Aires - Argentina":
                            contadorBsAs++;
                            acumBsAs = acumBsAs + unaFactura.ImporteNeto;
                            break;
                        case "Recife - Brasil":
                            contadorBrRec++;
                            acumBrRec = acumBrRec + unaFactura.ImporteNeto;
                            break;
                        case "Roma - Italia":
                            contadorItRo++;
                            acumItRo = acumItRo + unaFactura.ImporteNeto;
                            break;
                        case "Acapulco - Mexico":
                            contadorMexAca++;
                            acumMexAca = acumMexAca + unaFactura.ImporteNeto;
                            break;
                        case "Miami - EEUU":
                            contadorMiami++;
                            acumMiami = acumMiami + unaFactura.ImporteNeto;
                            break;
                    }
                }                
                estadisticaDestinos.Add(new Estadistica("Santa Rosa", contadorSR, acumSR));
                estadisticaDestinos.Add(new Estadistica("Bariloche",acumBche,contadorBche));
                estadisticaDestinos.Add(new Estadistica("Corrientes",acumCor,contadorCor));
                estadisticaDestinos.Add(new Estadistica("Cordoba",acumCba,contadorCba));
                estadisticaDestinos.Add(new Estadistica("Jujuy",acumJj,contadorJj));
                estadisticaDestinos.Add(new Estadistica("Mendoza",acumMen,contadorMen));
                estadisticaDestinos.Add(new Estadistica("Neuquen",acumNq,contadorNq));
                estadisticaDestinos.Add(new Estadistica("Posadas",acumPos,contadorPos));
                estadisticaDestinos.Add(new Estadistica("Iguazu",acumIg,contadorIg));
                estadisticaDestinos.Add(new Estadistica("Salta",acumSal,contadorSal));
                estadisticaDestinos.Add(new Estadistica("Santiago del Estero",acumSaEs,contadorSaEs));
                estadisticaDestinos.Add(new Estadistica("Trelew",acumTre,contadorTre));
                estadisticaDestinos.Add(new Estadistica("Tucuman",acumTuc,contadorTuc));
                estadisticaDestinos.Add(new Estadistica("Puerto Madryn",acumPM,contadorPM));
                estadisticaDestinos.Add(new Estadistica("Usuaia",acumUsh,contadorUsh));
                estadisticaDestinos.Add(new Estadistica("Buenos Aires",acumBsAs,contadorBsAs));
                estadisticaDestinos.Add(new Estadistica("Recife - Brasil",acumBrRec,contadorBrRec));
                estadisticaDestinos.Add(new Estadistica("Roma - Italia",acumItRo, contadorItRo));
                estadisticaDestinos.Add(new Estadistica("Acapulco - Mexico",acumMexAca,contadorMexAca));
                estadisticaDestinos.Add(new Estadistica("Miami - EEUU",acumMiami,contadorMiami));
                
            }
            return estadisticaDestinos;
        }


    }
}
