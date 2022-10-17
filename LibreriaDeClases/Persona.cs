using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int dni;

        string fechaNacimiento;
        string direccion;
        int telefono;
        string email;

               
        protected Persona(string nombre, string apellido, int dni, string fechaNacimiento, string direccion, 
            int telefono, string email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }



        

        public static double CalcularEdad(string fecha)
        {
            if (Validacion.VacioONulo(fecha))
            {
                DateTime fechaDeNacimiento = DateTime.Parse(fecha);
                DateTime fechaActual = DateTime.Today;
                TimeSpan fechaDiferencia = fechaActual.Subtract(fechaDeNacimiento);
                double años = fechaDiferencia.Days / 365.25;
                return años;
            }
            throw new Exception("No se pudo calcular edad");
        }
    }
}
