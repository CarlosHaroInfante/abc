using Prueba.Servicios;
using System.Runtime.Intrinsics.X86;

class Program
{

    public static void Main(System.String[] args)
    {



        MenuInterfaz menu = new MenuImplementacion(); /*Creacion de un Objeto llamado mi del metodo de pedir Mes y Anio*/
        BisiestoInterfaz Bisiesto = new BisiestoImplementacion(); /*Creacion de un Objeto llamado mi1 del metodo de calculo Bisiesto*/
        ContinuidadInterfaz seguir = new ContinuidadImplementacion();


        bool cerrarMenu = false;

        while (!cerrarMenu)
        {

            int mesElegido = menu.Mes();
            int anyoElegido = menu.Año(); 
            bool bisiesto = Bisiesto.Bisiesto(anyoElegido); 

            if (bisiesto)
            {

                if (mesElegido is 1 or 3 or 5 or 7 or 8 or 10 or 12)
                {
                    Console.WriteLine("Nº de dias 31 ");
                }

               if (mesElegido is 4 or 6 or 9 or 11)
                {
                    Console.WriteLine("Nº de dias 30 ");
                }

                if (mesElegido == 2)
                {
                    Console.WriteLine("Nº de dias 29 ");
                }

            }

            else
            {

                if (mesElegido is 1 or 3 or 5 or 7 or 8 or 10 or 12)
                {
                    Console.WriteLine("Nº de dias 31 ");
                }

                if (mesElegido is 4 or 6 or 9 or 11)
                {
                    Console.WriteLine("Nº de dias 30 ");
                }

                if (mesElegido == 2)
                {
                    Console.WriteLine("Nº de dias 28 ");
                }

            }

            string continuacion = seguir.menu();

            if (continuacion != "s")
            {

                cerrarMenu = true;
            }

        }

    }

}
