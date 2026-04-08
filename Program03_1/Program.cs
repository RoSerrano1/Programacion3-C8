namespace Program03_1;
class Program
{
   static void Main (string [] args)
    {
        Console.WriteLine("Gestion de Ventas");
        decimal Aceite= 4.500m;
        decimal Arroz = 1.000m;
        decimal Leche = 1.500m;

        int cantidadAceite= 25;
        int cantidadArroz = 40;
        int cantidadLeche = 50;
        
        Console.WriteLine("\nStock Disponible");
        Console.WriteLine("Aceite: " +cantidadAceite);
        Console.WriteLine("Arroz: " +cantidadArroz);
        Console.WriteLine("Leche: " +cantidadLeche);

        decimal recaudoAceite = Aceite*cantidadAceite;
        Console.WriteLine("\nUna vez vendidos todos los productos, lo recaudado en aceites es :" + " $" + recaudoAceite);

        decimal recaudoArroz = Arroz*cantidadArroz;
        Console.WriteLine("\nUna vez vendidos todos los productos, lo recaudado en arroz es :" + " $" + recaudoArroz);

        decimal recaudoLeche = Leche*cantidadLeche;
        Console.WriteLine("\nUna vez vendidos todos los productos, lo recaudado en leche es :" + " $" + recaudoLeche);
        

    } 
}