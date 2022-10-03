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
        

        public Pasajero(string nombre, string apellido, int dni, int pasaporte, string fechaNacimiento, string direccion,
            int telefono, string email, bool viajaEnTurista) : base(nombre, apellido, dni, pasaporte, fechaNacimiento, direccion, telefono, email)
        {


        }

        public bool EquipajeDeMano { get => equipajeDeMano; set => equipajeDeMano = value; }
        public bool ValijaTurista { get => valijaTurista; set => valijaTurista = value; }
        public bool ValijaPremium { get => valijaPremium; set => valijaPremium = value; }
        public int CantValijaPremium { get => cantValijaPremium; set => cantValijaPremium = value; }
        public bool ViajaEnTurista { get => viajaEnTurista; set => viajaEnTurista = value; }

    }
}
