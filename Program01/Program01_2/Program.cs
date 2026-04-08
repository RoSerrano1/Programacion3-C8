namespace Program01_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine(" Bienvenidos a la veterinaria ");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Para iniciar por favor indica tu nombre completo");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingresa tu numero de documento");
        int documento = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa tu email");
        string email = Console.ReadLine();

        Console.WriteLine("Y por ultimo carga la clave deseada");
        string clave = Console.ReadLine();

        Console.WriteLine("Perfecto, sus datos ya quedaron registrados");
        Console.WriteLine("Presione cualquier tecla para salir");
        Console.ReadLine();
    }
}    
