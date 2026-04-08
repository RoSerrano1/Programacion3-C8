namespace Program04;
class Program
{
    static void Main (string [] args)
    {
        char inicialNombre = 'C';

        Console.WriteLine("Por favor ingrese un nombre con la inicial " + inicialNombre);
        string nombre = Console.ReadLine();

        Console.WriteLine("\nEl nombre ingresado es: " + nombre);
        Console.WriteLine("\nPresione ENTER para salir");
    }
}
