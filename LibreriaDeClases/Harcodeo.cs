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

        private static List<Usuario> Usuarios(List<Usuario> usuarioHard)
        { 
           // List<Usuario> usuarioHard = new List<Usuario>();
            usuarioHard.Add(new Usuario("hernan", "pase"));
            usuarioHard.Add(new Usuario("lucas", "pase"));
            usuarioHard.Add(new Usuario("nacho", "pase"));
            usuarioHard.Add(new Usuario("ornela", "pase"));
            usuarioHard.Add(new Usuario("esteban", "pase"));

            return usuarioHard;
        }
        public static List<Usuario> CargarUsuarios()
        {
            List<Usuario> listaUsuariosAux = new List<Usuario>();
            listaUsuariosAux = Usuarios(listaUsuariosAux);
            return listaUsuariosAux;
        }


        //AERONAVES
        private static List<Aeronave> Aeronaves(List<Aeronave> aeronavesHard)
        {

            aeronavesHard.Add(new Aeronave(01234567, 2018, "Aguila Uno", 1200, 150, 2, 150));
            aeronavesHard.Add(new Aeronave(12345678, 2008, "Aguila Dos", 10000, 500, 4, 550));
            aeronavesHard.Add(new Aeronave(23456789, 2010, "Aguila Tres", 8000, 200, 1, 150));
            aeronavesHard.Add(new Aeronave(34567890, 2015, "Zorro Uno", 500, 115, 2, 100));
            aeronavesHard.Add(new Aeronave(45678901, 2010, "Zorro Dos", 6000, 180, 1, 5));
            aeronavesHard.Add(new Aeronave(56789012, 2005, "Zorro Tres", 15000, 197, 1, 4));
            aeronavesHard.Add(new Aeronave(67890123, 2022, "Maverick", 50, 20, 1, 20));

            return aeronavesHard;
        }

        public static List<Aeronave> CargarAeronaves()
        {
            List<Aeronave> listaAeronavesAux = new List<Aeronave>();
            listaAeronavesAux = Aeronaves(listaAeronavesAux);
            return listaAeronavesAux;
        }




    }
}
