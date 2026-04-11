namespace Program03_3;
class Program
{
    static void Main (string[] args)
    {
        //EJERCICIO 4:
           
        decimal precio = 200m;
        decimal impuesto = 0.21m;
        decimal total = precio + (precio * impuesto);

        Console.WriteLine("Precio final con impuesto: $" + total);

        Console.ReadLine();
    }
}
