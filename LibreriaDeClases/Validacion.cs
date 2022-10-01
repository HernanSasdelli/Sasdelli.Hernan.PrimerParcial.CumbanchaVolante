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


        public bool ValidarPatente(string patenteIngresada)
        {
            if (patenteIngresada.Count() == 8 )
            {
                return true;
            }
            return false;
        }

        public static Vuelo ValidarVuelo(string codVuelo, string patenteAeronave, string tipoDestino,
    string origen, string destino, string duracion, int horaDeSalida, string fechaDeSalida, 
    string asientos, bool comida, bool refresco, bool wifi,string bodega)
        {
            
            if (ValidarDisponibilidadAeronave(patenteAeronave, fechaDeSalida))
            {
                if(int.TryParse(asientos, out int asientosDisponibles))
                {
                  int asientosPremium = Vuelo.CalcularCantidadAsientosPremium(asientosDisponibles);
                    int asientosTurista = Vuelo.CalcularCantidadAsientosTurista(asientosDisponibles, asientosPremium);
                    if(int.TryParse(duracion, out int duracionVuelo))
                    {
                        if(int.TryParse(bodega, out int capBodega))
                        { 
                            Vuelo precargaVuelo = new Vuelo(patenteAeronave, codVuelo, tipoDestino, duracionVuelo, fechaDeSalida,
                            horaDeSalida, origen, destino, asientosDisponibles, asientosPremium, asientosTurista, comida, refresco, wifi,capBodega);

                            return precargaVuelo;
                        }
                    }
                    throw new Exception("Error en duracion de vuelo");
                }
                throw new Exception("Error en disponibilidad de asientos");
            }
            throw new Exception("Aeronave ya en uso para fecha seleccionada");            
        }

        


        public static bool ValidarDisponibilidadAeronave(string patenteAeronave, string fechaDeSalida)
        {
            foreach (Vuelo vuelo in Venta.listaDeVuelos)
            {
                if (fechaDeSalida == vuelo.FechaVuelo)
                {
                    if (patenteAeronave == vuelo.PatenteAeronave)
                    {
                        return false;
                    }                   
                }
            }
            return true;
        }
    }
}
