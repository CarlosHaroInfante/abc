using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    internal class ContinuidadImplementacion : ContinuidadInterfaz
    {
        /// <summary>
        /// Método que hace que aparezca un menú por consol, coja lo que ha escrito el usuario y lo use para saber si quiere cerrar menu o volver a realizar la operación
        /// 071123 - chi
        /// </summary>
        
        public string menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("- ¿Repetir operación?");
            Console.WriteLine("- S -----------> SI");
            Console.WriteLine("-------------------------");
            string sigo = Console.ReadLine(); //Coge lo que el usuario ha escrito por pantalla
            return sigo; //Devuelve una copia de lo que ha escrito el usuario

        }
    }
}
