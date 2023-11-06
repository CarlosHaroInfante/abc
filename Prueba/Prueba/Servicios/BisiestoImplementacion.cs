using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    internal class BisiestoImplementacion : BisiestoInterfaz
    {
        public bool Bisiesto(int any)
        {
            bool bisiesto = true;
            Console.WriteLine(any);



            if (any % 4 == 0)
            {
                
            }
            if (any % 100 == 0)
            {
                
            }
            if (any % 400 == 0)
            {
                Console.WriteLine("El año es Bisiesto");

            }




            else
            {
                Console.WriteLine("No es un Año Bisiesto");
                bisiesto = false;

            }

            return bisiesto;

        }
    }
}
