using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    /// <summary>
    /// Interfaz que contiene el método que calcula si el año es bisiesto o no
    /// 071123 - chi
    /// </summary>
    
    internal interface BisiestoInterfaz
    {
        public bool Bisiesto(int any); //Contiene any que son el año introducidos por el usuario
    }
}
