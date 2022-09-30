using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Usuario
    {
        private string nickName;
        private string contraseña;

        public Usuario(string nickName, string contraseña)
        {
            this.nickName = nickName;
            this.contraseña = contraseña;
        }

        public string Nombre { get=> this.nickName;}
        public string Contraseña { get => this.contraseña; }

        public static Usuario LogueoAleatorio(List<Usuario> listaDeUsuarios)
        {                        
            int largo = listaDeUsuarios.Count();
            Random indiceRandom = new Random();
            int indice=indiceRandom.Next(0, largo-1);

            return listaDeUsuarios[indice];
        }


        
       


    }

}
