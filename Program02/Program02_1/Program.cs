namespace Program02_1;

class Program
{
    static void Main (string [] args)
    {
        
        Console.WriteLine("--- Bloque 1: Libreria Anubis ---");
        int peliculasTerror = 10;
        int peliculasRomanticas = 30;
        int peliculasSuspenso = 15;

        int librosPoliciales = 8;
        int librosEspecies= 6;
        int librosRolon= 15;

        int totalPeliculas = peliculasTerror + peliculasRomanticas + peliculasSuspenso;
        int totalLibros = librosPoliciales + librosEspecies + librosRolon;

        Console.WriteLine("Cantidad de peliculas disponibles: " + totalPeliculas);
        Console.WriteLine("Hay un total de " + peliculasRomanticas + " peliculas romanticas disponibles");
        Console.WriteLine("Hay un total de " + peliculasTerror + " peliculas de terror disponibles");
        Console.WriteLine("Hay un total de " + peliculasSuspenso + " peliculas de suspenso disponibles");

        Console.WriteLine("\nCantidad de libros disponibles: " + totalLibros);
        Console.WriteLine("Hay un total de " + librosPoliciales + " libros policiales disponibles");
        Console.WriteLine("Hay un total de " + librosEspecies + " libros de especies disponibles");
        Console.WriteLine("Hay un total de " + librosRolon + " libros de rolon disponibles");

        Console.WriteLine("\nPresione ENTER para salir");

    }
}
