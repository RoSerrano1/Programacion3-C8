namespace Program01_1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----BIENVENIDOS AL CAJERO-----");
        Console.WriteLine("Vamos a registrarte");
        Console.WriteLine("Por favor ingrese su usuario");
        string usuario= Console.ReadLine();

        Console.WriteLine("Ingrese la clave deseada");
        string clave = Console.ReadLine();

        Console.WriteLine("Verifiquemos los datos cargados: ");
        Console.WriteLine("Su usuario es: " + usuario);
        Console.WriteLine("Su clave es: " + clave);
        Console.WriteLine("Registro creado correctamente");
    }
}