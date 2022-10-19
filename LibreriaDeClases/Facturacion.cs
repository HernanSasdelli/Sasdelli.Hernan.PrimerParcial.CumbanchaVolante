using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Facturacion
    {
        decimal porcentajeMayorValorPremium;
        decimal valorHoraVueloNacional;
        decimal valorHoraVueloInternacional;

        decimal valorHoraPremiumNacional;
        decimal valorHoraPremiumInternacional;

        decimal valorImpTazasYCargos;
        decimal valorImpuestoUtn;
        decimal valorImpuestoPais;

        public static List<Factura> listaDeFacturas;
        public Facturacion()
        {
            porcentajeMayorValorPremium = 15;
            valorHoraVueloNacional = 50;
            valorHoraVueloInternacional = 100;
            valorHoraPremiumNacional =valorHoraVueloNacional + ((valorHoraVueloNacional* porcentajeMayorValorPremium)/100);
            valorHoraPremiumInternacional = valorHoraVueloInternacional +(valorHoraVueloInternacional * porcentajeMayorValorPremium) / 100;
            valorImpTazasYCargos = 21;
            valorImpuestoUtn = 9;
            valorImpuestoPais = 40;
            listaDeFacturas = new List<Factura>();
        }

        public  decimal PorcentajeMayorValorPremium { get => porcentajeMayorValorPremium; set => porcentajeMayorValorPremium = value; }
        public decimal ValorHoraVueloNacional { get => valorHoraVueloNacional; set => valorHoraVueloNacional = value; }
        public decimal ValorHoraVueloInternacional { get => valorHoraVueloInternacional; set => valorHoraVueloInternacional = value; }
        public decimal ValorHoraPremiumNacional {  get=> valorHoraPremiumNacional;  }
        public decimal ValorHoraPremiumInternacional { get => valorHoraPremiumInternacional;  }
        public decimal ValorImpTazasYCargos { get => valorImpTazasYCargos; set => valorImpTazasYCargos = value; }
        public decimal ValorImpuestoUtn { get => valorImpuestoUtn; set => valorImpuestoUtn = value; }
        public decimal ValorImpuestoPais { get => valorImpuestoPais; set => valorImpuestoPais = value; }



        public static decimal CalcularValorVueloNeto(Vuelo unVuelo,bool viajaEnTurista, int totalClientes)
        {
            decimal precioViaje = 0;
            if (unVuelo != null && totalClientes>0)
            {
                Facturacion facturar = new Facturacion();
                
                if (unVuelo.TipoDestino  == "Nacional")
                { 
                    if(viajaEnTurista==true)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, facturar.ValorHoraVueloNacional);
                        
                    }
                    else if(viajaEnTurista==false)
                    {
                        precioViaje= CalcularPorHoras(unVuelo.DuracionVuelo,facturar.ValorHoraPremiumNacional);
                    }
                }
                else if(unVuelo.TipoDestino=="Internacional")
                {
                    if (viajaEnTurista == true)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, facturar.ValorHoraVueloInternacional);
                    }
                    else if (viajaEnTurista == false)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, facturar.ValorHoraPremiumInternacional);
                    }
                }
                precioViaje = precioViaje * totalClientes;
            }
            return precioViaje;
        }

        private static decimal CalcularPorHoras(int cantHoras, decimal tipoDeValorHora)
        {
            return cantHoras * tipoDeValorHora;
        }

        public static decimal CalcularImpuestos(decimal precioVuelo,decimal impuestoAcobrar)
        {
            decimal impuestoAPagar = 0;
            if (precioVuelo > 0)
            {
                impuestoAPagar = (precioVuelo * impuestoAcobrar) / 100;                
            }
            return impuestoAPagar;

        }
        
        public static List<Factura> FacturarDesdeHarcodeo(List<Vuelo> listaVuelos)
        {
            List<Factura> facturaLista = new List<Factura>();
            Factura unaFacturaPorCliente;
            if(listaVuelos != null)
            {
                foreach(Vuelo unVuelo in listaVuelos)
                {
                    foreach(Pasajero unPasajero in unVuelo.ListaDePasajeros)
                    {
                        decimal neto = Facturacion.CalcularValorVueloNeto(unVuelo, unPasajero.ViajaEnTurista, 1);

                        unaFacturaPorCliente = new Factura(neto, CalcularTotalConImpuestos(neto), unVuelo.CodigoDeVuelo, unVuelo.PatenteAeronave,
                            unPasajero.Dni, unVuelo.DestinoVuelo, unVuelo.OrigenVuelo, unPasajero.TraerNombreDeClase(), unVuelo.TipoDestino,
                            unVuelo.FechaVuelo, unPasajero.Nombre, unPasajero.Apellido);
                        facturaLista.Add(unaFacturaPorCliente);
                    }

                }
            }
            return facturaLista;
        }

        public static decimal CalcularTotalConImpuestos(decimal importeNeto)
        {
            Facturacion facturar = new Facturacion();
            decimal impPais = Facturacion.CalcularImpuestos(importeNeto, facturar.ValorImpuestoPais);
            decimal impUtn = Facturacion.CalcularImpuestos(importeNeto, facturar.ValorImpuestoUtn);
            decimal impTazasYCargas = Facturacion.CalcularImpuestos(importeNeto, facturar.ValorImpTazasYCargos);

            decimal importeTotal = importeNeto + impPais + impUtn + impTazasYCargas;
            return importeTotal;
        }



    }

}
