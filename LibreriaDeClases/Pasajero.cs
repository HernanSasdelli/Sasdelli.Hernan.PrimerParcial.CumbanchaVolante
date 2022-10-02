using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Pasajero : Cliente
    {

        //bool equipajeDeMano;
        // bool equipajeEnBodega;
        public Pasajero(string nombre, string apellido, int dni, int pasaporte, string fechaNacimiento, string direccion, int telefono, string email) : base(nombre, apellido, dni, pasaporte, fechaNacimiento, direccion, telefono, email)
        {
        }
    }
}
