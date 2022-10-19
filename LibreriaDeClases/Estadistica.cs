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
        int contadorSolitado;
        decimal acumuladorFacturacion;

        public string Destino { get => destino; set => destino = value; }
        public int ContadorSolitado { get => contadorSolitado; set => contadorSolitado = value; }
        public decimal AcumuladorFacturacion { get => acumuladorFacturacion; set => acumuladorFacturacion = value; }

        public Estadistica(string destino, int contadorSolitado, decimal acumuladorFacturacion)
        {
            this.Destino = destino;
            this.ContadorSolitado = contadorSolitado;
            this.AcumuladorFacturacion = acumuladorFacturacion;
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



        public static List<Estadistica> CargarFacturacionYDestinoMasPedido(List<Factura> listaDeFactura)
        {
            List<Estadistica> estadisticaDestinos = new List<Estadistica>();
            string destino;
            int contSR = 0, contBr = 0, contCor = 0, contCba = 0, contJj = 0, contMza = 0, contNeq = 0, contPo = 0, contIz = 0, contSa = 0,
                contSaEs = 0, contTre = 0, contTuc = 0, contPm = 0, contUsu = 0, contReBR = 0, contRoIta = 0, contAcaMe = 0, contBsAs = 0, contMiami = 0;

            decimal acumSR = 0, acumBr = 0, acumCor = 0, acumCba = 0, acumJj = 0, acumMza = 0, acumNeq = 0, acumPo = 0, acumIz = 0, acumSa = 0,
                     acumSaEs = 0, acumTre = 0, acumTuc = 0, acumPm = 0, acumUsu = 0, acumReBR = 0, acumRoIta = 0, acumAcaMe = 0, acumBsAs = 0, acumMiami = 0;


            if (listaDeFactura != null)
            {

                foreach (Factura unaFac in listaDeFactura)
                {
                    destino = unaFac.Destino;
                    switch(destino)
                    {

                        case "Santa Rosa":
                            contSR++;
                            acumSR = acumSR + unaFac.ImporteNeto;
                            break;
                        case "Bariloche":
                            contBr++;
                            acumBr= acumBr + unaFac.ImporteNeto;
                            break;
                        case "Corrientes":
                            contCor++;
                            acumCor= acumCor + unaFac.ImporteNeto;
                            break;
                        case "Cordoba":
                            contCba++;
                            acumCba= acumCba + unaFac.ImporteNeto;
                            break;
                        case "Jujuy":
                            contJj++;
                            acumJj= acumJj + unaFac.ImporteNeto;
                            break;
                        case "Mendoza":
                            contMza++;
                            acumMza= acumMza + unaFac.ImporteNeto;
                            break;
                        case "Neuquen":
                            contNeq++;
                            acumNeq= acumNeq + unaFac.ImporteNeto;
                            break;
                        case "Posadas":
                            contPo++;
                            acumPo= acumPo + unaFac.ImporteNeto;
                            break;
                        case "Iguazu":
                            contIz++;
                            acumIz= acumIz + unaFac.ImporteNeto;
                            break;
                        case "Salta":
                            contSa++;
                            acumSa= acumSa + unaFac.ImporteNeto;
                            break;
                        case "Santiago del Estero":
                            contSaEs++;
                            acumSaEs= acumSaEs + unaFac.ImporteNeto;
                            break;
                        case "Trelew":
                            contTre++;
                            acumTre= acumTre + unaFac.ImporteNeto;
                            break;
                        case "Tucuman":
                            contTuc++;
                            acumTuc= acumTuc + unaFac.ImporteNeto;
                            break;
                        case "Puerto Madryn":
                            contPm++;
                            acumPm= acumPm + unaFac.ImporteNeto;
                            break;
                        case "Usuaia":
                            contUsu++;
                            acumUsu= acumUsu + unaFac.ImporteNeto;
                            break;
                        case "Buenos Aires":
                            contBsAs++;
                            acumBsAs= acumBsAs + unaFac.ImporteNeto;
                            break;
                        case "Recife - Brasil":
                            contReBR++;
                            acumReBR= acumReBR + unaFac.ImporteNeto;
                            break;
                        case "Roma - Italia":
                            contRoIta++;
                            acumRoIta= acumRoIta + unaFac.ImporteNeto;
                            break;
                        case "Acapulco - Mexico":
                           contAcaMe++;
                            acumAcaMe= acumAcaMe + unaFac.ImporteNeto;
                            break;
                        case "Miami - EEUU":
                            contMiami++;
                            acumMiami= acumMiami + unaFac.ImporteNeto;
                            break;
                        case "Buenos Aires - Argentina":
                            contBsAs++;
                            acumBsAs= acumBsAs + unaFac.ImporteNeto;
                            break;                       
                    }
                }
            }
            estadisticaDestinos.Add(new Estadistica("Santa Rosa", contSR, acumSR));
            estadisticaDestinos.Add(new Estadistica("Bariloche", contBr, acumBr));
            estadisticaDestinos.Add(new Estadistica("Corrientes", contCor, acumCor));
            estadisticaDestinos.Add(new Estadistica("Cordoba", contCba, acumCba));
            estadisticaDestinos.Add(new Estadistica("Jujuy", contJj, acumJj));
            estadisticaDestinos.Add(new Estadistica("Mendoza", contMza, acumMza));
            estadisticaDestinos.Add(new Estadistica("Neuquen", contNeq, acumNeq));
            estadisticaDestinos.Add(new Estadistica("Posadas", contPo, acumPo));
            estadisticaDestinos.Add(new Estadistica("Iguazu", contIz, acumIz));
            estadisticaDestinos.Add(new Estadistica("Salta", contSa, acumSa));
            estadisticaDestinos.Add(new Estadistica("Santiago del Estero", contSaEs, acumSaEs));
            estadisticaDestinos.Add(new Estadistica("Trelew", contTre, acumTre));
            estadisticaDestinos.Add(new Estadistica("Tucuman", contTuc, acumTuc));
            estadisticaDestinos.Add(new Estadistica("Puerto Madryn", contPm, acumPm));
            estadisticaDestinos.Add(new Estadistica("Usuaia", contUsu, acumUsu));
            estadisticaDestinos.Add(new Estadistica("Buenos Aires", contBsAs, acumBsAs));
            estadisticaDestinos.Add(new Estadistica("Recife - Brasil", contReBR, acumReBR));
            estadisticaDestinos.Add(new Estadistica("Roma - Italia", contRoIta, acumRoIta));
            estadisticaDestinos.Add(new Estadistica("Acapulco - Mexico", contAcaMe, acumAcaMe));
            estadisticaDestinos.Add(new Estadistica("Miami - EEUU", contMiami, acumMiami));

            return estadisticaDestinos;
               
        }


    }
}
