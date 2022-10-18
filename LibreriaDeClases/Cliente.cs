using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Cliente  : Persona
    {
        int pasaporte; 
        int cantidadVuelosRealizados;
        Dictionary<string, string> vuelosYDestinos;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="pasaporte"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="email"></param>
        public Cliente(string nombre, string apellido, int dni, int pasaporte,
            string fechaNacimiento, string direccion, int telefono, string email) :base(nombre, apellido, dni, fechaNacimiento,direccion,telefono,email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.pasaporte = pasaporte;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.cantidadVuelosRealizados = 0;
            this.vuelosYDestinos = new Dictionary<string, string>();
        }

        public int Pasaporte { get => pasaporte; set => pasaporte = value; }
       
        public int CantidadVuelosRealizados { get => cantidadVuelosRealizados; set => cantidadVuelosRealizados = value; }
        public Dictionary<string, string> VuelosYDestinos { get => vuelosYDestinos; set => vuelosYDestinos = value; }
       
        /// <summary>
        /// Muestra todos los datos disponibles de un cliente
        /// </summary>
        /// <returns>Cadena de texto (string)</returns>
        public virtual string MostrarInfoCliente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de Cliente: {this.Nombre}");
            sb.AppendLine($"Apellido de Cliente: {Apellido}");
            sb.AppendLine($"DNI de Cliente: {Dni}");
            sb.AppendLine($"Edad: {(int)this.CalcularEdad()}");
            sb.AppendLine($"Direccion de Cliente: {Direccion}");
            sb.AppendLine($"Telefono de Cliente: {Telefono}");
            sb.AppendLine($"Email de Cliente: {Email}");

            return sb.ToString();           
        }

        /// <summary>
        /// Calcula una edad a partir de una fecha ingresada por el usuario
        /// </summary>
        /// <param name="fechaDeNacimientoIngresada"></param>
        /// <returns>Diferencia en años (double) desde fecha ingresada a fecha actual</returns>
        public static double CalcularEdadIngresada(string fechaDeNacimientoIngresada)
        {
            DateTime fechaDeNacimiento = DateTime.Parse(fechaDeNacimientoIngresada);
            DateTime fechaActual = DateTime.Today;
            TimeSpan fechaDiferencia = fechaActual.Subtract(fechaDeNacimiento);
            double años = fechaDiferencia.Days / 365.25;
            return años;
        }

        public static void CargarDestinosYCantDeVuelosACliente(List<Vuelo> listaDeVuelos)
        {
            if(listaDeVuelos != null)
            {
                foreach(Vuelo unVuelo in listaDeVuelos)
                {
                    foreach(Pasajero unPasajero in unVuelo.ListaDePasajeros)
                    {
                        foreach(Cliente unCliente in Venta.listaDeClientes)
                        {
                            if(Equals(unPasajero.Dni,unCliente.Dni))
                            {
                                unCliente.SumarVueloACliente();
                                unCliente.AgregarDestinoACliente(unVuelo);
                            }
                        }
                    }
                }
            }
        }

        public void SumarVueloACliente()
        {
            CantidadVuelosRealizados++;
        }
        public void AgregarDestinoACliente(Vuelo unVuelo)
        {
            VuelosYDestinos.Add(unVuelo.CodigoDeVuelo,unVuelo.ToString());
        }


        public List<string> ListaDestinosXCliente()
        {
            List<string> vuelosHechos = new List<string>();
            foreach (KeyValuePair<string,string> item in this.VuelosYDestinos)
            { 
               vuelosHechos.Add($"Vuelo: {item.Key} {item.Value}");
            }
            return vuelosHechos;
        }

    }
    



}
    