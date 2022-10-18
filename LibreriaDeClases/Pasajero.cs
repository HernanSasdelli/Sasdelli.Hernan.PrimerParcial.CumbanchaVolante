using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Pasajero : Cliente
    {

        bool equipajeDeMano;
        bool valijaTurista;
        bool valijaPremium;
        int cantValijaPremium;
        bool viajaEnTurista;



        public Pasajero(string nombre, string apellido, int dni, int pasaporte, string fechaNacimiento, string direccion, int telefono, string email) :
            base(nombre,apellido,dni,pasaporte,fechaNacimiento,direccion, telefono, email)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Pasaporte = pasaporte;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;

        }
       
        public Pasajero(string nombre, string apellido, int dni, int pasaporte, string fechaNacimiento, string direccion,
            int telefono, string email, bool mochilaMano, bool valijaTur, bool ValijaPrem,int cantValijaPrem, bool viajaEnClaseTurista)
            : base(nombre, apellido, dni, pasaporte, fechaNacimiento, direccion, telefono, email)
        {
            Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Pasaporte = pasaporte;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.equipajeDeMano = mochilaMano;
            this.valijaTurista = valijaTur;
            this.ValijaPremium = ValijaPrem;
            this.cantValijaPremium = cantValijaPrem;
            this.viajaEnTurista = viajaEnClaseTurista;


        }

        public bool EquipajeDeMano { get => equipajeDeMano; set => equipajeDeMano = value; }
        public bool ValijaTurista { get => valijaTurista; set => valijaTurista = value; }
        public bool ValijaPremium { get => valijaPremium; set => valijaPremium = value; }
        public int CantValijaPremium { get => cantValijaPremium; set => cantValijaPremium = value; }
        public bool ViajaEnTurista { get => viajaEnTurista; set => viajaEnTurista = value; }



        public static bool CargarValijasAlPasajero(Pasajero unPasajero,bool mochila, bool llevaValija, decimal cantValijasPrem, string clase)
        {
            if(unPasajero != null && cantValijasPrem >= 0 && cantValijasPrem < 3 && clase != null)
            {
                unPasajero.equipajeDeMano = mochila;

                if(clase=="Turista")
                {
                    unPasajero.valijaTurista = llevaValija;
                    
                }
                else if(clase == "Premium")
                {
                    unPasajero.valijaPremium = llevaValija;
                    if (llevaValija == true)
                    {
                        unPasajero.cantValijaPremium = (int)cantValijasPrem;

                    }                  
 
                }
                
               return true;
            }
            throw new Exception("No se pudieron cargar valijas");
        }

        public static Pasajero CargarUnPasajeroDesdeUnCliente(Cliente unCliente)
        {
            if(unCliente != null)
            {
                Pasajero unPasajero = new Pasajero(
                unCliente.Nombre,
                unCliente.Apellido,
                unCliente.Dni,
                unCliente.Pasaporte,
                unCliente.FechaNacimiento,
                unCliente.Direccion,
                unCliente.Telefono,
                unCliente.Email);
              
                return unPasajero;
            }
            return null;          

        }


        public static void CargarClase(string clase, Pasajero unPasajero)
        {
            if(clase!=null && unPasajero!=null)   
            {
                if(clase == "Turista")
                {
                    unPasajero.viajaEnTurista = true;
                }
            }
        }
              

        public string TraerNombreDeClase()
        {
            if(ViajaEnTurista)
            {
                return "Turista";
            }
            else
            {
                return "Premium";
            }

        }
        public override string MostrarInfoCliente()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del Pasajero: {this.Nombre}");
            sb.AppendLine($"Apellido del Pasajero: {Apellido}");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Edad: {(int)this.CalcularEdad()} años");
            sb.AppendLine($"Direccion: {Direccion}");
            sb.AppendLine($"Telefono: {Telefono}");
            sb.AppendLine($"Email: {Email}");
            sb.AppendLine($"");
            sb.AppendLine($"Bolso de mano: {Validacion.ValidarServicio(this.equipajeDeMano)}");
            sb.AppendLine($"Clase: {this.TraerNombreDeClase()}");
            sb.AppendLine($"Valijas en Bodega: {this.ContarValijas()}");

            return sb.ToString();
        }
        public static Pasajero BuscarPasajeroPorDni(string dni,Vuelo unVuelo)
        {
            if (dni != null)
            {
                if (int.TryParse(dni, out int dniParser))
                {
                    foreach (Pasajero unPasajero in unVuelo.ListaDePasajeros)
                    {
                        if (unPasajero.Dni == dniParser)
                        {
                            return unPasajero;
                        }
                    }
                }
            }
            return null;
        }
        public int ContarValijas()
        {            
            if (ValijaTurista == true)
            {
                return  1;
            }
            else if (ValijaPremium == true)
            {
               return CantValijaPremium;
            }
            return 0;
        }






    }
}
