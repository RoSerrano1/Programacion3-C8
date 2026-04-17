using System.Security.Cryptography;

namespace Ejercicio_Logica;
class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("-         Bienvenidos al Boliche         -");
        Console.WriteLine("------------------------------------------");
        int cantidad = 20;
        string [] nombres = new string [cantidad];
        int [] edad = new int [cantidad];
        Console.WriteLine($"Por favor, ingrese {cantidad} de nombres y edades: ");

        for(int i=0; i<cantidad; i++)
        {
            Console.Write("\nIngrese nombre: ");
            nombres[i]=Console.ReadLine();

            Console.Write("Ingrese edad: ");
            edad[i] = int.Parse(Console.ReadLine());

            Console.Write($"{i}-El nombre ingresado es {nombres[i]} y su edad es {edad[i]}. ");
            if (edad[i] <30)
            {
                Console.WriteLine("¡Lo siento, no puede ingresar!");
            }
            else
            {
                Console.WriteLine("¡Bienvenido al boliche, puede ingresar!");
            }
        }
             Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
    }
}
