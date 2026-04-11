namespace Program02_4;
class Program
{
    static void Main (string[]args)
    {
        Console.WriteLine("Ingrese un numero");
        int numero1= int.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese un segundo numero");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("La multiplicacion entre ambos numeros es:" + (numero1*numero2));
        Console.WriteLine("Por favor, presione ENTER para salir");
        Console.ReadLine();
    }
}
