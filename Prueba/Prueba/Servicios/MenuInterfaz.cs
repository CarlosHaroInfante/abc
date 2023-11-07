using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    /// <summary>
    /// Interfaz que contiene el método que pedirá el mes y el año.
    /// 071123 - chi
    /// </summary> 
    
    internal interface MenuInterfaz
    {
        public int Mes(); //creación de método, donde se guardará el mes.
        public int Año(); //creación de método, donde se guardará el año.
    }
}
