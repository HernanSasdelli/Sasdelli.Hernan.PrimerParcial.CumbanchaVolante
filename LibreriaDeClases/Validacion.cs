using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Validacion
    {
        public static Usuario ValidarUsuarioyContraseña(string usuarioIngresado,string contraseñaIngresada)
        {
            if(VacioONulo(usuarioIngresado) && VacioONulo(contraseñaIngresada))
            {
                List<Usuario> listaUsuarios = Harcodeo.CargarUsuarios();

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
                    throw new Exception("usuario incorrecto");
                }
            }
            throw new Exception("Faltan cargar datos");       
            
            //return validacion;
        }

        public static bool VacioONulo(string ingreso)
        {
            if (ingreso != null && ingreso != "")
            {
                return true;
            }
            return false;
        }
        
            
    }
}
