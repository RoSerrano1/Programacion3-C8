namespace Program02;
class Program
{
    static void Main (string [] args)
    {
        //EJERCICIO 1:
        
    Console.WriteLine("-----Bloque 1: Stock de una tienda");
    int gaseosas = 20;
    int galletas = 12;
    int caramelos= 50;
    int suma= gaseosas+galletas+caramelos;

    Console.WriteLine("La cantidad de gaseosas existentes es: " + gaseosas);
    Console.WriteLine("La cantidad de galletas existentes es: " + galletas);
    Console.WriteLine("La cantidad de caramelos es: " + caramelos);
    Console.WriteLine("El Stock Total es: " + suma);
    Console.WriteLine("\nPresione Enter para salir");
    Console.ReadLine();
    }
}
