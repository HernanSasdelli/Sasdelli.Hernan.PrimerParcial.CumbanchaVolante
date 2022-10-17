using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public static class Equipaje
    {
        
        public static int ContarTotalBultosEquipaje(Vuelo unVuelo)
        {
            if(unVuelo != null)
            {
                int equipajePremium = ContarEquipajePremium(unVuelo);
                int equipajeTurista = ContarEquipajeTurista(unVuelo);
                return equipajePremium + equipajeTurista;
            }
            return -1;
        }
        public static int ContarEquipajePremium(Vuelo unVuelo)
        {
            if(unVuelo != null)
            {
                int contadorEquipajePremium=0;

                foreach (Pasajero unPasajero in unVuelo.ListaDePasajeros)
                {
                    if(unPasajero.ViajaEnTurista is false && unPasajero.ValijaPremium is true)
                    {
                        contadorEquipajePremium = contadorEquipajePremium + unPasajero.CantValijaPremium;
                    }
                }
                return contadorEquipajePremium;
            }
            return -1;
        }



        public static int ContarEquipajeTurista(Vuelo unVuelo)
        {
            if(unVuelo != null)
            {
                int contadorEquipajeTurista=0;
                foreach (Pasajero unPasajero in unVuelo.ListaDePasajeros)
                {
                    if(unPasajero.ViajaEnTurista is true && unPasajero.ValijaTurista is true)
                    {
                        contadorEquipajeTurista++;
                    }
                }
                return contadorEquipajeTurista;
            }
            return -1;
        }




        

    }
}
