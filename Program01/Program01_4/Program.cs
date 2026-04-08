namespace Program01_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido/a a la Veterinaria Huellitas");
        Console.WriteLine("Vamos a registrar una mascota");
        Console.WriteLine("\nIngresa nombre del dueño");
        string nombreDueño = Console.ReadLine();

        Console.WriteLine("\nIngresa nombre de la mascota");
        string nombreMascota = Console.ReadLine();
        Console.WriteLine("\nIngresa tipo de mascota");
        string tipoMascota = Console.ReadLine();
        Console.WriteLine("\nIngresa la edad de la mascota");
        int edad= int.Parse(Console.ReadLine());
        Console.WriteLine("\nIngresa el peso de la mascota");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("\nPerfecto los datos ingresados son: ");
        Console.WriteLine("El dueño se llama: " + nombreDueño);
        Console.WriteLine("El nombre de la mascota es: " + nombreMascota);
        Console.WriteLine("La mascota es un: " + tipoMascota);
        Console.WriteLine("La mascota tiene: " + edad + " años");
        Console.WriteLine("La mascota pesa: " + peso + "kg");

        Console.WriteLine("Buenisimo, los datos fueron ingresados");
        Console.WriteLine("Presione ENTER para salir");
        Console.ReadLine();

    }
}