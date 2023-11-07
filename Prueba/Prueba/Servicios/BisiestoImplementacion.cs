using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Prueba.Servicios
{
    internal class BisiestoImplementacion : BisiestoInterfaz //Conecto los servicios
    {
        /// <summary>
        /// Método que hace el calculo de si el año es bisiesto o no
        /// 071123 - chi
        /// </summary>
        
        public bool Bisiesto(int any)
        {
            bool bisiesto = true; //Lo iniciamos con true



            if ((any % 4 == 0 && any % 100 != 0) || any % 400 == 0) //Realiza los calculos para ver si es bisiesto y si no pasa al else
            {
                Console.WriteLine("Es un Año Bisiesto"); //Imprime que es bisiesto
            }
            else //Si no ha entrado en el if, entrará en el else
            {
                Console.WriteLine("No es un Año Bisiesto"); //Imprime que no es bisiesto
                bisiesto = false; //Pasamos bisiesto a false
            }



            return bisiesto; //Devuelve la copia de bisiesto

        }
    }
}
