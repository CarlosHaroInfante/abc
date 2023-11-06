using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int Mes()
        {
            Console.WriteLine("Indique un Mes del Año");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public int Año()
        {
            Console.WriteLine("Indique un Año");
            int año = Convert.ToInt32(Console.ReadLine());
            return año;
        }
    }
}
