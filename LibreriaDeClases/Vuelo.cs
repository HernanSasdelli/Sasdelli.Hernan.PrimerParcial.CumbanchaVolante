﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public enum ETipoDestino
    {
        Nacional,
        Internacional
    };

    public class Vuelo
    {

        const int PORCENTAJEPREMIUM = 20;
        const int CODIGOVUELOINICIAL = 1000000;

        string patenteAeronave;
        string codigoDeVuelo;
        string tipoDestino;
        int duracionVuelo;
        string fechaVuelo;
        int horaPartidaVuelo;
        string origenVuelo;
        string destinoVuelo;
        int asientosDisponiblesVuelo;
        int asientosClasePremium;
        int asientosClaseTurista;
        bool tieneWifi;
        bool tieneServicioRefrescoBasico;
        bool tieneServicioComida;
        int capacidadBodega;
        int pasajerosABordo;
        int valijasEnBodega;
        List<Pasajero> listaDePasajeros;
        List<Equipaje> listaDeEquipaje;

        public static List<string> listaDestinosNacionales;
        public static List<string> listaDestinosInternacionales;


        static Vuelo()
        {
            
            listaDestinosInternacionales = new List<string>();
            Harcodeo.DestinosInternacionales(listaDestinosInternacionales);

            listaDestinosNacionales = new List<string>();
            Harcodeo.DestinosNacionales(listaDestinosNacionales);
            
        }

        public Vuelo(string patenteAeronave, string codigoDeVuelo, string tipoDestino, int duracionVuelo, string fechaVuelo, 
            int horaPartidaVuelo, string origenVuelo, string destinoVuelo, int asientosDisponiblesVuelo,
            int asientosClasePremium, int asientosClaseTurista, bool tieneWifi,
            bool tieneServicioRefrescoBasico, bool tieneServicioComida, int capacidadBodega)
        {
            this.patenteAeronave = patenteAeronave;
            this.codigoDeVuelo = codigoDeVuelo;
            this.tipoDestino = tipoDestino;
            this.duracionVuelo = duracionVuelo;
            this.fechaVuelo = fechaVuelo;
            this.horaPartidaVuelo = horaPartidaVuelo;
            this.origenVuelo = origenVuelo;
            this.destinoVuelo = destinoVuelo;
            this.asientosDisponiblesVuelo = asientosDisponiblesVuelo;            
            this.asientosClasePremium = asientosClasePremium;
            this.asientosClaseTurista = asientosClaseTurista;
            this.tieneWifi = tieneWifi;
            this.tieneServicioRefrescoBasico = tieneServicioRefrescoBasico;
            this.tieneServicioComida = tieneServicioComida;
            this.capacidadBodega = capacidadBodega;
            listaDeEquipaje = new List<Equipaje>();
            listaDePasajeros = new List<Pasajero>();
            pasajerosABordo = listaDePasajeros.Count();
            valijasEnBodega = listaDeEquipaje.Count();
        }


        public string PatenteAeronave { get => patenteAeronave; set => patenteAeronave = value; }
        public string CodigoDeVuelo { get => codigoDeVuelo; set => codigoDeVuelo = value; }
        public string TipoDestino { get => tipoDestino; set => tipoDestino = value; }
        public int DuracionVuelo { get => duracionVuelo; set => duracionVuelo = value; }
        public string FechaVuelo { get => fechaVuelo; set => fechaVuelo = value; }
        public int HoraPartidaVuelo { get => horaPartidaVuelo; set => horaPartidaVuelo = value; }
        public string OrigenVuelo { get => origenVuelo; set => origenVuelo = value; }
        public string DestinoVuelo { get => destinoVuelo; set => destinoVuelo = value; }
        public int AsientosDisponiblesVuelo { get => asientosDisponiblesVuelo; set => asientosDisponiblesVuelo = value; }
        public int AsientosClasePremium { get => asientosClasePremium; set => asientosClasePremium = value; }
        public int AsientosClaseTurista { get => asientosClaseTurista; set => asientosClaseTurista = value; }
        public bool TieneWifi { get => tieneWifi; set => tieneWifi = value; }
        public bool TieneServicioRefrescoBasico { get => tieneServicioRefrescoBasico; set => tieneServicioRefrescoBasico = value; }
        public bool TieneServicioComida { get => tieneServicioComida; set => tieneServicioComida = value; }
        public int PasajerosABordo { get => pasajerosABordo; }
        public List<Pasajero> ListaDePasajeros { get => listaDePasajeros; set => listaDePasajeros = value; }
        internal List<Equipaje> ListaDeEquipaje { get => listaDeEquipaje; set => listaDeEquipaje = value; }
        public int ValijasEnBodega { get => valijasEnBodega; }


        public static List<string> ListaPatentes(List<Aeronave> listaAeronaves)
        {
            List<string> ret = new List<string>();
            foreach (Aeronave item in listaAeronaves)
            {
                ret.Add(item.PatenteAeronave);
            }
            return ret;
        }
        public static Aeronave BuscarAeronavePorPatente(List<Aeronave> listaAeronaves, string patenteBuscada)
        {
            if(listaAeronaves != null && patenteBuscada != null)
            {
                foreach(Aeronave datosAeronave in listaAeronaves)
                {
                   if( datosAeronave.PatenteAeronave == patenteBuscada)
                    {
                        return datosAeronave;
                    }
                    
                }
            }
            return null;
        }

        public static int CalcularCantidadAsientosPremium(int cantTotalAsientos)
        {
            int asientosPremium;
            if(cantTotalAsientos > 0 && PORCENTAJEPREMIUM >= 0)
            {
                asientosPremium = cantTotalAsientos * PORCENTAJEPREMIUM / 100;
                return asientosPremium;
            }                           

            return -1;
        }

        public static int CalcularCantidadAsientosTurista(int canTotalAsientos, int asientosPremium)
        {
            int asientosTurista;
            if(canTotalAsientos > 0 && asientosPremium >=0)
            {
                asientosTurista = canTotalAsientos - asientosPremium;
                return asientosTurista;
            }
            return -1;
        }
        
        public static List<string> DestinosPosiblesNac(string origen)
        {
           List<string> destinosDesdeBuenosAires = new List<string>();
            if (origen == "Buenos Aires")
            {                
                foreach (string item in listaDestinosNacionales)
                {
                    destinosDesdeBuenosAires.Add(item);
                }
                destinosDesdeBuenosAires.Remove("Buenos Aires");                
            }
            else if (origen != "Buenos Aires")
            {
                destinosDesdeBuenosAires.Add("Buenos Aires");
            }

            return destinosDesdeBuenosAires;
        }
        public static List<string> DestinosPosiblesInter(string origen)
        {
            List<string> destinosDesdeBuenosAires = new List<string>();
            if (origen == "Buenos Aires - Argentina")
            {
                foreach (string item in listaDestinosInternacionales)
                {
                    destinosDesdeBuenosAires.Add(item);
                }
                destinosDesdeBuenosAires.Remove("Buenos Aires - Argentina");
            }
            else if (origen != "Buenos Aires - Argentina")
            {
                destinosDesdeBuenosAires.Add("Buenos Aires - Argentina");
            }

            return destinosDesdeBuenosAires;
        }

        public static int CalcularHorasVueloNac()
        {
            Random horasDeVuelo = new Random();
            int horas;
            horas = horasDeVuelo.Next(2,4);

            return horas;
        }
        public static int CalcularHorasVueloInter()
        {
            Random horasDeVuelo = new Random();
            int horas;
            horas = horasDeVuelo.Next(8, 12);

            return horas;
        }

        public static int CodigoDeVueloRandom()
        {
            int codVuelo;
           Random random = new Random();
            codVuelo = random.Next(1000001, 9999999);
            return codVuelo;   
        }

      



    }


}
