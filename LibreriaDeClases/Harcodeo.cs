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
            vuelosHard.Add(new Vuelo("AG678901", "1000000","Internacional", 10, "10/04/2022", 16 , "Buenos Aires - Argentina", "Acapulco - Mexico",20,4,16,true,true,false,20));
            vuelosHard.Add(new Vuelo("AG678901", "1000395","Internacional", 10, "10/08/2022", 8 , "Buenos Aires - Argentina", "Miami - EEUU", 20, 4, 16, true, false, false,20));
            vuelosHard.Add(new Vuelo("AB123456", "1000500","Nacional", 3 , "05/09/2022", 9 , "Buenos Aires", "Bariloche", 500, 100, 400, true, true, true,550));

        }

    
        
    }
}
