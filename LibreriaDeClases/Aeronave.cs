using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Aeronave
    {
        private string patenteAeronave;
        private int modelo;
        private string nombreAeronave;
        private float horasDeVueloTotal;
        private int cantidadDeAsientos;
        private int cantidadDeBaños;
        private int capacidadDeBodega;

        public Aeronave(string patenteAvion, int modelo, string nombre,
            float horasDeVueloTotal, int cantidadDeAsientos, int cantidadDeBaños, int capacidadDeBodega)
        {
            this.patenteAeronave = patenteAvion;
            this.modelo = modelo;
            this.nombreAeronave = nombre;
            this.HorasDeVueloTotal1 = horasDeVueloTotal;
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBaños = cantidadDeBaños;
            this.capacidadDeBodega = capacidadDeBodega;
        }
        public string PatenteAeronave { get { return patenteAeronave; } }
        public string NombreAeronave { get { return nombreAeronave; } }
        public int Modelo { get { return modelo; } }        
        public int CantidadDeAsientos   { get { return cantidadDeAsientos; } }
        public int CantidadDeBaños { get { return cantidadDeBaños; } }
        public int CapacidadDeBodega { get { return capacidadDeBodega; } }
        public float HorasDeVueloTotal1 { get => horasDeVueloTotal; set => horasDeVueloTotal = value; }


        public static List<Vuelo> ListaVuelosPorPatente(string patenteAeronaveSelec)
        {
            List<Vuelo> listaVuelosdeAeronave = new List<Vuelo>();
            if(patenteAeronaveSelec!= null)
            {
                foreach(Vuelo unVuelo in Venta.listaDeVuelos)
                {
                    if(Equals(unVuelo.PatenteAeronave, patenteAeronaveSelec))
                    {
                        listaVuelosdeAeronave.Add(unVuelo);
                    }
                }
            }
            return listaVuelosdeAeronave;
        }



    }






}
