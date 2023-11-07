using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    /// <summary>
    /// Interfaz que contiene el método que imprimirá el menú por consola 
    /// 071123 - chi
    /// </summary>
    
    internal interface ContinuidadInterfaz
    {
        public string menu(); //Devolverá un string con el que se hará que siga el programa activo o no
    }
}
