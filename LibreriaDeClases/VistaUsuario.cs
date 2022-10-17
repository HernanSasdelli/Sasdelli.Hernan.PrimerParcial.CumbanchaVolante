using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public static class VistaUsuario
    {
        public static List<Vuelo> listaVuelosRealizados = new List<Vuelo>();
        public static List<Vuelo> listaVuelosEnFechaOEnCurso = new List<Vuelo>();
        public static List<Vuelo> listaVuelosProximos = new List<Vuelo>();
        public static List<Vuelo> listaVuelosProximosParaMostrar = new List<Vuelo>();

        static VistaUsuario()
        {
            listaVuelosRealizados = CrearNuevaListadeVuelos(Venta.listaDeVuelos, "Realizado");
            listaVuelosEnFechaOEnCurso = CrearNuevaListadeVuelos(Venta.listaDeVuelos, "EnCurso");
            listaVuelosProximos = CrearNuevaListadeVuelos(Venta.listaDeVuelos, "Proximo");

            listaVuelosProximosParaMostrar = CrearListaAVisualizar(listaVuelosProximos);
        }



        public static List<Vuelo> CrearNuevaListadeVuelos(List<Vuelo> listaDeVuelos, string estadoDeVuelo)
        {
            List<Vuelo> listaVuelosADevolver = new List<Vuelo>();
            if (listaDeVuelos != null && estadoDeVuelo != null)
            {
                
                foreach(Vuelo unVuelo in listaDeVuelos)
                {
                    if(unVuelo.EstadoDeVuelo==estadoDeVuelo)
                    {
                        listaVuelosADevolver.Add(unVuelo);
                    }
                }

            }
            return listaVuelosADevolver;
        }


        public static List<Vuelo> CrearListaAVisualizar(List<Vuelo> listaVuelosProximos)
        {
            List<Vuelo> listaAMostar = new List<Vuelo>();
            if (listaVuelosProximos != null)
            {
                foreach (Vuelo unVuelo in listaVuelosProximos)
                {
                    Vuelo vueloAMostrar = new Vuelo(unVuelo.CodigoDeVuelo, unVuelo.TipoDestino, unVuelo.OrigenVuelo,
                          unVuelo.DestinoVuelo, unVuelo.FechaVuelo, unVuelo.DuracionVuelo, unVuelo.HoraPartidaVuelo,
                          unVuelo.TieneWifi, unVuelo.TieneServicioRefrescoBasico, unVuelo.TieneServicioRefrescoBasico);
                    listaAMostar.Add(vueloAMostrar);
                }

            }
            return listaAMostar;
        }





    }
}
