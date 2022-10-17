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
        public static List<Pasajero> listaPasajerosAuxiliar;
        

        static Venta()
        {
            listaUsuarios = new List<Usuario>();
            Harcodeo.Usuarios(listaUsuarios);

            listaAeronaves = new List<Aeronave>();
            Harcodeo.Aeronaves(listaAeronaves);

            listaDeVuelos = new List<Vuelo>(); 
            Harcodeo.VuelosHarcodeados(listaDeVuelos);

            listaDeClientes = new List<Cliente>();
            Harcodeo.ClientesHarcodeados(listaDeClientes);

            listaPasajerosAuxiliar = new List<Pasajero>();
            Harcodeo.PasajerosHarcodeados(listaPasajerosAuxiliar);

            Harcodeo.HarcodearPasajerosEnVuelos(listaDeVuelos, listaPasajerosAuxiliar);


            Harcodeo.CargarListaDeValijasEnVuelosHarcodeados(listaDeVuelos);
        }


        public static void AgregarVueloALista(Vuelo vuelo)
        {

                Venta.listaDeVuelos.Add(vuelo);
            
        }

        public static void AgregarClienteALista(Cliente cliente)
        {
            Venta.listaDeClientes.Add(cliente);

        }
        

        public static Cliente BuscarClienteXDni(string dniIngresado)
        {
            if (dniIngresado != null)
            {
                if (int.TryParse(dniIngresado, out int dniParser))
                {
                    foreach (Cliente unCliente in Venta.listaDeClientes)
                    {
                        if (unCliente.Dni == dniParser)
                        {
                            return unCliente;
                        }

                    }
                }

            }
            return null;
        }
        public static Cliente BuscarClientePorDni(string dni)
        {
            if(dni != null)
            {
                if(int.TryParse(dni, out int dniParser))
                {
                    foreach(Cliente unCliente in Venta.listaDeClientes)
                    {
                        unCliente.Dni = dniParser;
                        return unCliente;
                    }
                }
            }
            return null;
        }


    }
}
