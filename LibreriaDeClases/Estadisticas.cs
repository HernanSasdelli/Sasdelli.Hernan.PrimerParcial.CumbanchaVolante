using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    abstract class Estadisticas
    {
        static Estadisticas()
        {
            Venta.listaAeronaves.Sort();
        }
    }
}
