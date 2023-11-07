using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Prueba.Servicios
{
    internal class BisiestoImplementacion : BisiestoInterfaz
    {
        public bool Bisiesto(int any)
        {
            bool bisiesto = true;




            if (any % 4 == 0)
            {
                Console.WriteLine("Divisible entre 4");
                

                if (any % 100 == 0)
                {
                    Console.WriteLine("Divisible entre 100");

                    
                     if (any % 400 == 0)

                     {  
                      Console.WriteLine("Es bisiesto");  

                     }
                }
                bisiesto = true;
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
