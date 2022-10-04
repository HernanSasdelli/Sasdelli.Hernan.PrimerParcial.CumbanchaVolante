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
            base(nombre, apellido, dni, pasaporte, fechaNacimiento, direccion, telefono, email)
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

        public bool VerificarCantidadPasajerosCargados(int ind,decimal totalForms, List<Pasajero> listaAux)
        {
            if (totalForms == 1)
            {
                return true;
            }
            else if (totalForms > 1)
            {
               if( listaAux.Count==totalForms)
                {
                    return true;
                }
            }
            return false;
        }




    }
}
