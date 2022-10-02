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
        public static List<Cliente> listaDeClientes;
        static Venta()
        {
            listaAeronaves = new List<Aeronave>();
            Harcodeo.Aeronaves(listaAeronaves);

            listaUsuarios = new List<Usuario>();
            Harcodeo.Usuarios(listaUsuarios);

            listaDeVuelos = new List<Vuelo>(); 
            Harcodeo.VuelosHarcodeados(listaDeVuelos);

            listaDeClientes = new List<Cliente>();


        }

        public static void AgregarVueloALista(Vuelo vuelo)
        {
            Venta.listaDeVuelos.Add(vuelo);
        }

        public static void AgregarClienteALista(Cliente cliente)
        {
            Venta.listaDeClientes.Add(cliente);
        }




    }
}
