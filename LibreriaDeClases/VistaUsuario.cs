using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class VistaUsuario
    {
        private static List<Vuelo> listaVuelosSegunEstado;        

        static VistaUsuario()
        {
            ListaVuelosSegunEstado = new List<Vuelo>();                  
        }

        public static List<Vuelo> ListaVuelosSegunEstado { get => listaVuelosSegunEstado; set => listaVuelosSegunEstado = value; }

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






}
}
