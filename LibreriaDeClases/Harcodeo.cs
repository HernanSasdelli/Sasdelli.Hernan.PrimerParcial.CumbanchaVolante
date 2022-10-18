using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public static class Harcodeo
    {

        //USUARIOS

        public static void Usuarios(List<Usuario> usuarioHard)
        { 
          
            usuarioHard.Add(new Usuario("hernan", "pase"));
            usuarioHard.Add(new Usuario("lucas", "pase"));
            usuarioHard.Add(new Usuario("nacho", "pase"));
            usuarioHard.Add(new Usuario("ornela", "pase"));
            usuarioHard.Add(new Usuario("esteban", "pase"));

        }

        //AERONAVES
        public static void Aeronaves(List<Aeronave> aeronavesHard)
        {

            aeronavesHard.Add(new Aeronave("AA012345", 2018, "Aguila Uno", 1200, 150, 2, 150));
            aeronavesHard.Add(new Aeronave("AB123456", 2008, "Aguila Dos", 10000, 500, 4, 550));
            aeronavesHard.Add(new Aeronave("AC234567", 2010, "Aguila Tres", 8000, 200, 1, 150));
            aeronavesHard.Add(new Aeronave("AD345678", 2015, "Zorro Uno", 500, 115, 2, 100));
            aeronavesHard.Add(new Aeronave("AE456789", 2010, "Zorro Dos", 6000, 180, 1, 5));
            aeronavesHard.Add(new Aeronave("AF567890", 2005, "Zorro Tres", 15000, 197, 1, 4));
            aeronavesHard.Add(new Aeronave("AG678901", 2022, "Maverick", 50, 20, 1, 20));            
        }

        //DESTINO
        public static void DestinosNacionales(List<string> destinosNac)
        {            
            destinosNac.Add("Santa Rosa");
            destinosNac.Add("Bariloche");
            destinosNac.Add("Corrientes");
            destinosNac.Add("Cordoba");
            destinosNac.Add("Jujuy");
            destinosNac.Add("Mendoza");
            destinosNac.Add("Neuquen");
            destinosNac.Add("Posadas");
            destinosNac.Add("Iguazu");
            destinosNac.Add("Salta");
            destinosNac.Add("Santiago del Estero");
            destinosNac.Add("Trelew");
            destinosNac.Add("Tucuman");
            destinosNac.Add("Puerto Madryn");
            destinosNac.Add("Usuaia");
            destinosNac.Add("Buenos Aires");
        }

        public static void DestinosInternacionales(List<string> destinosInt)
        {
            destinosInt.Add("Recife - Brasil");
            destinosInt.Add("Roma - Italia");
            destinosInt.Add("Acapulco - Mexico");
            destinosInt.Add("Miami - EEUU");
            destinosInt.Add("Buenos Aires - Argentina");

        }
        //VUELOS
       
        public static void VuelosHarcodeados(List<Vuelo> vuelosHard)
        {                                                                                                                                         //asientos       refr
                                    //patente   cod vuelo        tipo       hs  fecha         hsalida       origen                  destino           prem tu  wifi  comida bodega
            vuelosHard.Add(new Vuelo("AG678901", "1000000","Internacional", 10, "10/04/2022", 16 , "Buenos Aires - Argentina", "Acapulco - Mexico",20,4,16,true,true,false,20,"Realizado"));
            vuelosHard.Add(new Vuelo("AG678901", "1000395","Internacional", 9, "10/08/2022", 8 , "Buenos Aires - Argentina", "Miami - EEUU", 20, 4, 16, true, false, false,20,"Realizado"));
            vuelosHard.Add(new Vuelo("AB123456", "1000500","Nacional", 2 , "05/09/2022", 9 , "Buenos Aires", "Bariloche", 500, 100, 400, true, true, true,550,"Proximo"));
            vuelosHard.Add(new Vuelo("AB123456", "1000501", "Nacional", 4, "05/09/2022", 9, "Buenos Aires", "Bariloche", 500, 100, 400, true, true, true, 550, "EnCurso"));
            vuelosHard.Add(new Vuelo("AD345678", "1000502", "Nacional", 2, "17/10/2022", 9, "Buenos Aires", "Bariloche", 500, 100, 400, true, true, true, 550, "Proximo"));
            vuelosHard.Add(new Vuelo("AC234567", "1300000", "Internacional", 12, "10/04/2023", 16, "Buenos Aires - Argentina", "Acapulco - Mexico", 20, 4, 16, true, true, false, 20, "EnCurso"));
            vuelosHard.Add(new Vuelo("AG678901", "1058295", "Internacional", 11, "17/08/2023", 8, "Buenos Aires - Argentina", "Miami - EEUU", 20, 4, 16, true, false, true, 20, "EnCurso"));
            vuelosHard.Add(new Vuelo("AF567890", "1455595", "Internacional", 9, "19/12/2022", 8, "Buenos Aires - Argentina", "Miami - EEUU", 20, 4, 16, true, true, false, 20, "EnCurso"));




        }

        //CLIENTES
        public static void ClientesHarcodeados(List<Cliente> clientesHard)
        {
            clientesHard.Add(new Cliente("Jose Maria", "Listorti", 14455455, 23141414, "20/01/1975", "ooooh al 400", 1540647798, "jmaria@osoarturo.com"));
            clientesHard.Add(new Cliente("Hernan", "sasdelli", 36374455, 36374455, "09/01/1992", "ginebra 1855", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("Homero", "Simpson", 12345678, 12345678, "01/01/1980", "calle falsa 123", 03420343, "homero@simpson.com"));
            clientesHard.Add(new Pasajero("Marge", "Simpson", 23456789, 36374455, "09/01/1992", "av siempre viva 364", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("Ned", "Flanders", 34567891, 36374455, "09/01/1992", "av siempre viva 366", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("Mod", "Flanders", 45678991, 36374455, "09/01/1992", "av siempre viva 366", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("Krusty", "Burger", 56789123, 36374455, "09/01/1992", "av de los obreros 123", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("Otto", "Octavio", 67891234, 36374455, "09/01/1992", "av de los obreros 123", 1540647798, "her_9192@hotmail.com"));
            clientesHard.Add(new Pasajero("castulo", "smiders", 78912345, 36374455, "09/01/1992", "vietnam 1970", 1540647798, "her_9192@hotmail.com"));
        }


        //PASAJEROS
        public static void PasajerosHarcodeados(List<Pasajero> pasajerosHard)
        {
            pasajerosHard.Add(new Pasajero("Jose Maria", "Listorti", 14455455, 23141414, "20/01/1975", "ooooh al 400", 1540647798, "jmaria@osoarturo.com", true,true,false, 0,true));
            pasajerosHard.Add(new Pasajero("Hernan", "sasdelli", 36374455, 36374455, "09/01/1992", "ginebra 1855", 1540647798, "her_9192@hotmail.com",false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("Homero", "Simpson", 12345678, 12345678, "01/01/1980", "calle falsa 123", 03420343, "homero@simpson.com", false, false, true, 1, false));
            pasajerosHard.Add(new Pasajero("Marge", "Simpson", 23456789, 36374455, "09/01/1992", "av siempre viva 364", 1540647798, "pordios@aprobame.com", false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("Ned", "Flanders", 34567891, 36374455, "09/05/1995", "av siempre viva 366", 1540647798, "nohay@mensajesssubliminales.com", false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("Mod", "Flanders", 45678991, 36374455, "05/01/1989", "av siempre viva 366", 1540647798, "mebaproa@hotmail.com", true, false, true, 0, false));
            pasajerosHard.Add(new Pasajero("Krusty", "Burger", 56789123, 36374455, "03/07/1980", "av de los obreros 123", 1540647798, "her_9192@mebaproa.com", true, false, true, 1, false));
            pasajerosHard.Add(new Pasajero("Otto", "Octavio", 67891234, 36374455, "09/01/1992", "av de los obreros 123", 1540647798, "her_9192@hotmail.com", false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("castulo", "smiders", 78912345, 36374455, "01/05/1975", "vietnam 1970", 1540647798, "her_9192@promocion.com", false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("lisa", "Simpson", 50000001, 36374455, "01/01/2012", "av siempre viva 364", 1540647798, "lucas@campeon.com", false, true, false, 0, false));
            pasajerosHard.Add(new Pasajero("bart", "Simpson", 50000002, 36374455, "01/01/2013", "av siempre viva 364", 1540647798, "her_9192@hotmail.com", false, true, false, 0, false));
            pasajerosHard.Add(new Pasajero("magggie", "Simpson", 50000003, 36374455, "01/01/2017", "av siempre viva 364", 1540647798, "her_9192@hotmail.com", false, true, false, 0, false));
        }
        //PASAJEROS2

        public static void PasajerosHardDos(List<Pasajero> pasajerosHard)
        {
            pasajerosHard.Add(new Pasajero("juan", "roman", 40434434, 40434434, "10/10/1990", "la boca 1245", 1540647798, "juan@Roman.com", true, true, false, 0, true));
            pasajerosHard.Add(new Pasajero("moe", "sislac", 12345678, 12345678, "01/01/1980", "calle falsa 123", 03420343, "homero@simpson.com", true, false, true, 1, false));
            pasajerosHard.Add(new Pasajero("messi", "irveunseis", 23456789, 36374455, "07/01/1960", "av siempre viva 364", 154064898, "pordios@aprobame.com", false, false, true, 2, false));
            pasajerosHard.Add(new Pasajero("juan", "topo", 34567891, 36374455, "09/05/1955", "av siempre viva 366", 080010555, "nohay@mensajesssubliminales.com", true, true, false, 0, true));

        }


        public static void CargarListaDeValijasEnVuelosHarcodeados(List<Vuelo> listaVuelos)
        {
            if (listaVuelos != null)
            {

                foreach (Vuelo unVuelo in listaVuelos)
                {
                    unVuelo.ValijasEnBodega = unVuelo.ValijasEnBodega +Equipaje.ContarTotalBultosEquipaje(unVuelo);

                }
            }
        }
        public static void HarcodearPasajerosEnVuelos(List<Vuelo> listaVuelos, List<Pasajero> listaPasajerosAux)
        {
            foreach (Vuelo unVuelo in listaVuelos)
            {
                unVuelo.ListaDePasajeros = listaPasajerosAux;
                unVuelo.PasajerosABordo = unVuelo.PasajerosABordo +listaPasajerosAux.Count;
            }
        }
        public static void HarcodearPasajerosEnVuelo(string codVuelo, List<Pasajero> listaPasajerosAux)
        {
            Vuelo unVuelo = Vuelo.BuscarVueloPorId(codVuelo);

                unVuelo.ListaDePasajeros = listaPasajerosAux;
                unVuelo.PasajerosABordo = unVuelo.PasajerosABordo +listaPasajerosAux.Count;

        }
    }
}
