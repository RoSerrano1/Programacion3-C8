using System.ComponentModel.DataAnnotations;

namespace Ejercicio3_arrays;
class Program
{
    static void Main(string[]args)
    {
        //EJERCICIO 3_1:
        Console.WriteLine("--- EJERCICIO 3: USO DE .LENGTH Y BUCLE FOR ---");
        int [] edades = {10,25,18,47,32};
        int cantidadElementos = edades.Length;
        Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos");
        Console.WriteLine("----------------------------------------------------");

        for (int i= 0; i< edades.Length; i++)
        {
            Console.WriteLine("Indice" + i + ": La edad es " + edades[i]);
        }
        Console.WriteLine("\nPresione ENTER para continuar");
        Console.ReadLine();

        //--------------------------------------------------------------------------
        //Ejercicio 3_2:
        string [] nombres = {"Rocio", "Ambar", "Diego", "Jonas"};
        int cantidadNombres= nombres.Length;
        Console.WriteLine("El arreglo tiene " + cantidadNombres + " elementos");
        
        for (int i=0; i<nombres.Length; i++)
        {
            Console.WriteLine("Indice " +i + " : el nombre es " + nombres[i]);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //---------------------------------------------------------------------------
        //EJERCICIO 3_3:
        double [] precios = {20.5, 45.5, 84.3,64,7};
        int cantPrecios= precios.Length;
        Console.WriteLine("El arreglo tiene " + cantPrecios +" elementos");
        for(int i =0; i<precios.Length; i++)
        {
            Console.WriteLine("Indice " + i + " : el precio es $" + precios[i]);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //---------------------------------------------------------------------------
        //EJERCICIO 3_4:
        int [] temperaturas = {20, 35, 25, 18, 40};
        int cantTemperaturas = temperaturas.Length;
        Console.WriteLine("El arreglo tiene " + cantTemperaturas + " elementos");
        for(int i=0; i< temperaturas.Length; i++)
        {
            Console.WriteLine("Indice " + i + ": la temperatura es " + temperaturas[i]);

        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //------------------------------------------------------------------------------
        //EJERCICIO 3_5:
        char [] letras = {'A', 'B', 'C', 'D'};
        int cantLetras = letras.Length;
        Console.WriteLine("El arreglo tiene " + cantLetras + " elementos");
        for(int i=0; i < letras.Length ; i++)
        {
            Console.WriteLine("Indice " + i + ": la letra es " + letras[i]);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();
    }
}
