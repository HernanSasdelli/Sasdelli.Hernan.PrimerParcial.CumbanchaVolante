using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.DataAnnotations.EmailAddressAttribute;

namespace LibreriaDeClases
{

    //USUARIOS APP
    public class Validacion
    {
        public static Usuario ValidarUsuarioyContraseña(string usuarioIngresado, string contraseñaIngresada,
            List<Usuario> listaUsuarios)
        {
            if (VacioONulo(usuarioIngresado) && VacioONulo(contraseñaIngresada))
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



        
        //AERONAVE

        public bool ValidarPatente(string patenteIngresada)
        {
            if (patenteIngresada.Count() == 8)
            {
                return true;
            }
            return false;
        }

        //VUELO

        public static Vuelo ValidarVuelo(string codVuelo, string patenteAeronave, string tipoDestino,
    string origen, string destino, string duracion, int horaDeSalida, string fechaDeSalida,
    string asientos, bool comida, bool refresco, bool wifi, string bodega)
        {

            if (ValidarDisponibilidadAeronave(patenteAeronave, fechaDeSalida))
            {
                if (int.TryParse(asientos, out int asientosDisponibles))
                {
                    int asientosPremium = Vuelo.CalcularCantidadAsientosPremium(asientosDisponibles);
                    int asientosTurista = Vuelo.CalcularCantidadAsientosTurista(asientosDisponibles, asientosPremium);
                    if (int.TryParse(duracion, out int duracionVuelo))
                    {
                        if (int.TryParse(bodega, out int capBodega))
                        {
                            Vuelo precargaVuelo = new Vuelo(patenteAeronave, codVuelo, tipoDestino, duracionVuelo, fechaDeSalida,
                            horaDeSalida, origen, destino, asientosDisponibles, asientosPremium, asientosTurista, comida, refresco, wifi, capBodega,"Proximo");
                             
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
        public static Pasajero ValidarMenor(string nombre, string apellido, string dni, string pasaporte, string fechaNacimiento,
            string direccion, string telefono, string email)
        {
            if (ValidarString(nombre))
            {
                if (ValidarString(apellido))
                {
                    int dniOk = ValidarDNI(dni);
                    int pasaporteOk = ValidarPasaporte(pasaporte);
                    if (ValidarEsMenorDeEdad(fechaNacimiento))
                    {
                        if (direccion != "")
                        {
                            if (telefono != "")
                            {
                                int telefonoOk = ValidarTelefono(telefono);

                                if (ValidarMail(email))
                                {
                                    Pasajero pasajeroPrecarga = new Pasajero(nombre, apellido, dniOk, pasaporteOk, fechaNacimiento,
                                        direccion, telefonoOk, email);
                                    return pasajeroPrecarga;
                                }

                            }
                        }
                        throw new Exception("No se puede cargar direccion");
                    }                                        
                }                
            }
            throw new Exception();
        }
        public static Cliente ValidarNuevoCliente(string nombre, string apellido, string dni, string pasaporte,
            string fechaNacimiento, string direccion, string telefono, string email)
        {
            if (ValidarString(nombre))
            {
                if (ValidarString(apellido))
                {
                    int dniOk = ValidarDNI(dni);
                    int pasaporteOk = ValidarPasaporte(pasaporte);

                    if (ValidarEsMayorDeEdad(fechaNacimiento))
                    {
                        if (direccion != "")
                        {
                            int telefonoOk = ValidarTelefono(telefono);
                            if (ValidarMail(email))
                            {
                                Cliente clientePrecarga = new Cliente(nombre, apellido, dniOk, pasaporteOk, fechaNacimiento,
                                    direccion, telefonoOk, email);
                                return clientePrecarga;
                            }                                          
                        }
                        throw new Exception("No se puede cargar direccion");
                    }         
                }               
            }
            throw new Exception();
        }

        private static bool ValidarMail(string email)
        {
            if (VacioONulo(email))
            {
                Regex val = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (val.IsMatch(email))
                {
                    return true;
                }
                throw new Exception("Email no valido");
            }
            throw new Exception("Campo email vacio");
        }

        private static int ValidarTelefono(string telefono)
        {
            if(VacioONulo(telefono))
            {
                if (int.TryParse(telefono, out int val))
                {
                    if (val > 5)
                    {
                        return val;
                    }
                    throw new Exception("Telefono Ivalido");
                }
                throw new Exception("No es un numero telefonico");
            }
            throw new Exception("Campo telefono vacio");
        }


        private static int ValidarPasaporte(string pasaporte)
        {
            if (VacioONulo(pasaporte))
            {
                if (int.TryParse(pasaporte, out int pasaporteOk))
                {
                    if (pasaporteOk > 999999 && pasaporteOk < 100000000)
                    {
                        return pasaporteOk;
                    }
                    throw new Exception("Rango pasaporte invalido");
                }
                throw new Exception("Pasaporte solo admite numeros");
            }
            throw new Exception("Campo pasaporte vacio");
        }

        public static int ValidarDNI(string dni)
        {
            if (VacioONulo(dni))
            {
                if (int.TryParse(dni, out int dniOk))
                {
                    if (dniOk > 999999 && dniOk < 100000000)
                    {
                        foreach (Cliente dniClientes in Venta.listaDeClientes)
                        {
                            if (dniClientes.Dni == dniOk)
                            {
                                throw new Exception("El Cliente ya ha sido cargado");
                            }
                        }
                        return dniOk;
                    }
                    throw new Exception("DNI no valido");
                }
                throw new Exception("El DNI solo debe tener numeros");
            }
            throw new Exception("Campo DNI vacio");
        }

        private static bool ValidarString(string nombreOApellido)
        {
            if (VacioONulo(nombreOApellido))
            {
                if (nombreOApellido.Length > 2 && nombreOApellido.Length < 20)
                {
                    Regex Val = new Regex(@"^[a-zA-Z]+( [a-zA-Z]+)*$");
                    if (Val.IsMatch(nombreOApellido))
                    {
                        return true;
                    }
                    throw new Exception("Caracteres no validos");
                }
                throw new Exception("Ingrese entre 2 y 20 caracteres");
            }
            throw new Exception("Campo vacio");
        }


        //Venta Vuelo
        public static string ValidarServicio(bool siONo)
        {
            if (siONo == true)
            {
                return "si";
            }
            return "no";
        }

        private static bool ValidarEsMayorDeEdad(string fechaNacimiento)
        {
            if (VacioONulo(fechaNacimiento))
            {   
                if (EsMayorString(fechaNacimiento))
                {
                    return true;
                }
                throw new Exception("Debe ser mayor de edad para registrarse como cliente");
            }
            throw new Exception("No se pudo cargar edad");
        }

        private static bool ValidarEsMenorDeEdad(string fechaNacimiento)
        {
            if (VacioONulo(fechaNacimiento))
            {
                if (!EsMayorString(fechaNacimiento))
                {
                    return true;
                }
                throw new Exception("El cliente es mayor de edad");
            }
            throw new Exception();
        }

        public static bool EsMayorString(string fechaDeNacimientoIngresada)
        {
            if (VacioONulo(fechaDeNacimientoIngresada))
            {
                if(Cliente.CalcularEdad(fechaDeNacimientoIngresada) >= 18)
                {
                    return true;
                }                
            }
            return false;
        }




    }
}
