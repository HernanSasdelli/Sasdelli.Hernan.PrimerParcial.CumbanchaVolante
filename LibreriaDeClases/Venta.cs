using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases;

namespace LibreriaDeClases
{

    public static class Venta
    {
        public static List<Aeronave> listaAeronaves;
        public static List<Usuario> listaUsuarios;
        public static List<Vuelo> listaDeVuelos;

        static Venta()
        {
            listaAeronaves = new List<Aeronave>();
            Harcodeo.Aeronaves(listaAeronaves);

            listaUsuarios = new List<Usuario>();
            Harcodeo.Usuarios(listaUsuarios);

            listaDeVuelos = new List<Vuelo>(); 
            Harcodeo.VuelosHarcodeados(listaDeVuelos);

        }

        public static void AgregarVueloALista(Vuelo vuelo)
        {
            Venta.listaDeVuelos.Add(vuelo);
            foreach(Vuelo vuel in Venta.listaDeVuelos)
            {
                vuel.CodigoDeVuelo = "sasa";

            }
        }





    }
}
