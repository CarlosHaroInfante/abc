using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Servicios
{
    internal class ContinuidadImplementacion : ContinuidadInterfaz
    {
        public string menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("- ¿Repetir operación? -");
            Console.WriteLine("- S = SI            -");
            Console.WriteLine("**************************");
            string sigo = Console.ReadLine();
            return sigo;

        }
    }
}
