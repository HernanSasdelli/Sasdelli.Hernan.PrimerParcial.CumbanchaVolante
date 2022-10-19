using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public static class Facturacion
    {
        static decimal porcentajeMayorValorPremium;
        static decimal valorHoraVueloNacional;
        static decimal valorHoraVueloInternacional;

        static decimal valorHoraPremiumNacional;
        static decimal valorHoraPremiumInternacional;

        static decimal valorImpTazasYCargos;
        static decimal valorImpuestoUtn;
        static decimal valorImpuestoPais;

        public static List<Factura> listaDeFacturas;
        static Facturacion()
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

        public static decimal PorcentajeMayorValorPremium { get => porcentajeMayorValorPremium; set => porcentajeMayorValorPremium = value; }
        public static decimal ValorHoraVueloNacional { get => valorHoraVueloNacional; set => valorHoraVueloNacional = value; }
        public static decimal ValorHoraVueloInternacional { get => valorHoraVueloInternacional; set => valorHoraVueloInternacional = value; }
        static decimal ValorHoraPremiumNacional {  get=> valorHoraPremiumNacional;  }
        static decimal ValorHoraPremiumInternacional { get => valorHoraPremiumInternacional;  }
        public static decimal ValorImpTazasYCargos { get => valorImpTazasYCargos; set => valorImpTazasYCargos = value; }
        public static decimal ValorImpuestoUtn { get => valorImpuestoUtn; set => valorImpuestoUtn = value; }
        public static decimal ValorImpuestoPais { get => valorImpuestoPais; set => valorImpuestoPais = value; }



        public static decimal CalcularValorVueloNeto(Vuelo unVuelo,bool viajaEnTurista, int totalClientes)
        {
            decimal precioViaje = 0;
            if (unVuelo != null && totalClientes>0)
            {
                
                
                if (unVuelo.TipoDestino  == "Nacional")
                { 
                    if(viajaEnTurista==true)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, Facturacion.valorHoraVueloNacional);
                        
                    }
                    else if(viajaEnTurista==false)
                    {
                        precioViaje= CalcularPorHoras(unVuelo.DuracionVuelo,Facturacion.valorHoraPremiumNacional);
                    }
                }
                else if(unVuelo.TipoDestino=="Internacional")
                {
                    if (viajaEnTurista == true)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, Facturacion.valorHoraVueloInternacional);
                    }
                    else if (viajaEnTurista == false)
                    {
                        precioViaje = CalcularPorHoras(unVuelo.DuracionVuelo, Facturacion.valorHoraPremiumInternacional);
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
            
            decimal impPais = Facturacion.CalcularImpuestos(importeNeto, Facturacion.valorImpuestoPais);
            decimal impUtn = Facturacion.CalcularImpuestos(importeNeto, Facturacion.valorImpuestoUtn);
            decimal impTazasYCargas = Facturacion.CalcularImpuestos(importeNeto, Facturacion.valorImpTazasYCargos);

            decimal importeTotal = importeNeto + impPais + impUtn + impTazasYCargas;
            return importeTotal;
        }

        public static decimal CambioPrecios(string nuevoImporte)
        {
            if(Validacion.VacioONulo(nuevoImporte))
            {
                if(decimal.TryParse(nuevoImporte, out decimal nuevoParser))
                {
                    if(nuevoParser>0)
                    {

                        return nuevoParser;
                    }
                    throw new Exception("Rango invalido");
                }
                throw new Exception("Solo Numeros");
            }
            throw new Exception("Campo Vacio");

        }
        public static void ActualizarPreciosPremium()
        {
            valorHoraPremiumNacional = valorHoraVueloNacional + ((valorHoraVueloNacional * porcentajeMayorValorPremium) / 100);
            valorHoraPremiumInternacional = valorHoraVueloInternacional + (valorHoraVueloInternacional * porcentajeMayorValorPremium) / 100;
        }

    }

}
