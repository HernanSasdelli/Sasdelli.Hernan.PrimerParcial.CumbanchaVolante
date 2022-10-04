using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Cliente
    {

        string nombre;
        string apellido;
        int dni;
        int pasaporte;
        string fechaNacimiento;
        string direccion;
        int telefono;
        string email;
        int cantidadVuelosRealizados;
        Dictionary<int, string> vuelosYDestinos;

        public Cliente(string nombre, string apellido, int dni, int pasaporte,
            string fechaNacimiento, string direccion, int telefono, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.pasaporte = pasaporte;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.cantidadVuelosRealizados = 0;
            this.vuelosYDestinos = new Dictionary<int, string>();
        }

        //set para modificar campos de clientes(modulo en observacion)
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Pasaporte { get => pasaporte; set => pasaporte = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        //seteable desde venta
        public int CantidadVuelosRealizados { get => cantidadVuelosRealizados; set => cantidadVuelosRealizados = value; }
        public Dictionary<int, string> VuelosYDestinos { get => vuelosYDestinos; set => vuelosYDestinos = value; }
    }




}
