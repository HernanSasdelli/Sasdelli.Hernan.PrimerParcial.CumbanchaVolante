using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Validacion
    {
        public static Usuario ValidarUsuarioyContraseña(string usuarioIngresado,string contraseñaIngresada, 
            List<Usuario> listaUsuarios)
        {
            if(VacioONulo(usuarioIngresado) && VacioONulo(contraseñaIngresada))            
            {        
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.Nombre == usuarioIngresado)
                    {
                        if (usuario.Contraseña == contraseñaIngresada)
                        {
                            return usuario;
                        }
                        throw new Exception("contraseña incorrecta");
                    }                    
                }
                throw new Exception("usuario incorrecto");
            }
            throw new Exception("Faltan cargar datos");                   
          
        }

        public static bool VacioONulo(string ingreso)
        {
            if (ingreso != null && ingreso != "")
            {
                return true;
            }
            return false;
        }
        //Aeronave

        private string patenteAeronave;
        private int modelo;
        private string nombreAeronave;
        private float horasDeVueloTotal;
        private int cantidadDeAsientos;
        private int cantidadDeBaños;
        private int capacidadDeBodega;

        public bool ValidarPatente(string patenteIngresada)
        {
            if (patenteIngresada.Count() == 8 )
            {
                return true;
            }
            return false;
        }

    }
}
