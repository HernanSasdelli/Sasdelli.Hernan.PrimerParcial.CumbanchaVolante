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
        Dictionary<int, string> vuelosYDestinos;


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
            this.vuelosYDestinos = new Dictionary<int, string>();
        }

        public int Pasaporte { get => pasaporte; set => pasaporte = value; }
        
        
        //seteable desde venta        
        public int CantidadVuelosRealizados { get => cantidadVuelosRealizados; set => cantidadVuelosRealizados = value; }
        public Dictionary<int, string> VuelosYDestinos { get => vuelosYDestinos; set => vuelosYDestinos = value; }
       


        public virtual string MostrarInfoCliente(Cliente cliente)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre de Cliente: {cliente.Nombre}");
            sb.AppendLine($"Apellido de Cliente: {cliente.Apellido}");
            sb.AppendLine($"DNI de Cliente: {cliente.Dni}");
            sb.AppendLine($"Direccion de Cliente: {CalcularEdad(cliente.FechaNacimiento)}");
            sb.AppendLine($"DNI de Cliente: {cliente.Direccion}");
            sb.AppendLine($"Telefono de Cliente: {cliente.Telefono}");
            sb.AppendLine($"Email de Cliente: {cliente.Email}");

            return sb.ToString();           
        }

        private Dictionary<int,string> CrearListaDeClienteParaMostrar(List<Cliente> listaDeClientes)
        {
            Dictionary<int, string> listaClientes = new Dictionary<int, string>();
            if(listaDeClientes != null)
            {
;               foreach(Cliente unCliente in listaDeClientes)
                {
                    listaClientes.Add(unCliente.Dni,MostrarInfoCliente(unCliente));
                }
            }
            return listaClientes;
        }

        public Dictionary<int, string> CargarDiccionarioDeClientesParaVista(List<Cliente> listaDeClientes)
        {
            Dictionary<int, string> dicClientesParaVista = new Dictionary<int, string>();
            dicClientesParaVista = CrearListaDeClienteParaMostrar(listaDeClientes);
            return dicClientesParaVista;

        }


    }
    



}
    