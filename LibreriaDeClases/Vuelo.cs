using System;
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

        string patenteAeronave;
        string codigoDeVuelo;
        float duracionVuelo;
        string fechaVuelo;
        string horaPartidaVuelo;
        string origenVuelo;
        string destinoVuelo;
        int asientosDisponiblesVuelo;
        int porcentajeClasePremium;
        int asientosClasePremium;
        int asientosClaseTurista;
        bool tieneWifi;
        bool tieneServicioRefrescoBasico;
        bool tieneServicioComida;


        public static List<string> listaDestinosNacionales;
        public static List<string> listaDestinosInternacionales;


        static Vuelo()
        {
            listaDestinosInternacionales = new List<string>();
            Harcodeo.DestinosInternacionales(listaDestinosInternacionales);

            listaDestinosNacionales = new List<string>();
            Harcodeo.DestinosNacionales(listaDestinosNacionales);
        }

         

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

    }


}
