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

        
       


    }

}
