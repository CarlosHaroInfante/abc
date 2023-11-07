using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    internal class MenuImplementacion : MenuInterfaz //Conecto los servicios
    {
        /// <summary>
        /// Método que pedirá el mes y el año para hacer los respectivos calculos.
        /// 071123 - chi
        /// </summary>
        
        public int Mes() //Método que pedirá el mes
        {
            Console.WriteLine("Indique un Mes del Año"); //Pide el mes por consola
            int mes = Convert.ToInt32(Console.ReadLine()); //Lo convierte en un int de 32 bits
            return mes; //Devuelve la copia del mes
        }

        public int Año()
        {
            Console.WriteLine("Indique un Año"); //Pide el año por consola
            int año = Convert.ToInt32(Console.ReadLine()); //Lo convierte en un int de 32 bits
            return año; //Devuelve la copia del año
        }
    }
}
