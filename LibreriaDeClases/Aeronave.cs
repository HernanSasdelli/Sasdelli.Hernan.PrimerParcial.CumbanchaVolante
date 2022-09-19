using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Aeronave
    {
        private int patenteAvion;
        private int modelo;
        private string nombre;
        private float horasDeVueloTotal;
        private int cantidadDeAsientos;
        private int cantidadDeBaños;
        private int capacidadDeBodega;

        public Aeronave(int patenteAvion, int modelo, string nombre,
            float horasDeVueloTotal, int cantidadDeAsientos, int cantidadDeBaños, int capacidadDeBodega)
        {
            this.patenteAvion = patenteAvion;
            this.modelo = modelo;
            this.nombre = nombre;
            this.horasDeVueloTotal = horasDeVueloTotal;
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBaños = cantidadDeBaños;
            this.capacidadDeBodega = capacidadDeBodega;
        }
        public int PatenteAvion { get { return patenteAvion; } }
        public string Nombre { get { return nombre; } }
    }
}
