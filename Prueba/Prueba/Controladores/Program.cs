using Prueba.Servicios;
using System.Runtime.Intrinsics.X86;


/// <summary>
/// Clase Principal del programa, donde se encuentra el método main.
/// 071123 - chi
/// </summary>
class Program
{
    /// <summary>
    /// Main del programa, donde se encuentran las copias de los objetos, las llamadas al método, el bucle del mes y la opción de que si escoges s pida otra vez el número.
    /// 071123 - chi
    /// </summary>
    public static void Main(System.String[] args)
    {

        

        MenuInterfaz menu = new MenuImplementacion(); //Llamada al método que pide el mes y el año por consola
        BisiestoInterfaz Bisiesto = new BisiestoImplementacion(); /*Creacion de un Objeto llamado mi1 del metodo de calculo Bisiesto*/
        ContinuidadInterfaz seguir = new ContinuidadImplementacion();


        bool cerrarMenu = false; //Creo un bool en falso que hará que entremos en el menú           

        while (!cerrarMenu) //Lo inicio con ! para que lo pase a valor negativo y entre en el menú
        {

            int mesElegido = menu.Mes(); //Llamada al método que pide el mes
            int anyoElegido = menu.Año(); //Llamada al método que pide el año
            bool bisiesto = Bisiesto.Bisiesto(anyoElegido); //Llamada al método que hace la operación y devuelve si es bisiesto o no

            if (bisiesto) //If que comparará el mes elegido por el usuario cuando el año es bisiesto
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

                if (mesElegido >= 13) //Validación que hace que si el mes es mayor o igual a 13 datá que el mes no es válido
                {
                    Console.WriteLine("[INFO] - Mes no válido"); 
                }

            }

            else //If que comparará el mes elegido por el usuario cuando el año no es bisiesto
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
                if (mesElegido >= 13)
                {
                    Console.WriteLine("[INFO] - Mes no válido"); //Validación que hace que si el mes es mayor o igual a 13 datá que el mes no es válido//
                }
            }

            string continuacion = seguir.menu(); //Llamada al metodo que devuelve lo que el usuario ha escrito por pantalla

            if (continuacion != "s") //Si lo escrito por pantalla no es s saldrá del menú
            {

                cerrarMenu = true; //Pasa cerrar menu a true
            }

        }

    }

}
