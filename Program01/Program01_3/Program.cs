namespace Program01_3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al registro del club");
        Console.WriteLine("Para empezar indicanos tu nombre completo");
        string nombre= Console.ReadLine();

        Console.WriteLine("Indica tu edad");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Indica tu fecha de nacimiento");
        DateTime fecha = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Indica tu numero de documento");
        string documento = Console.ReadLine();

        Console.WriteLine("Indica tu ciudad");
        string ciudad = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("Perfecto, los datos cargados son los siguientes: ");
        Console.WriteLine("Tu nombre es: " + nombre);
        Console.WriteLine("Tu edad es: " + edad);
        Console.WriteLine("Tu fecha de nacimiento es: " + fecha);
        Console.WriteLine("Tu numero de documento es: " + documento);
        Console.WriteLine("Tu ciudad es: " + ciudad);

        Console.WriteLine("Gracias por registrarte :) ");
        Console.WriteLine("Presiona una tecla cualquiera para salir");
        Console.ReadLine();
    }
}