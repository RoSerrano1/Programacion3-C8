namespace Ejercicio2_arrays;
class Program
{
    static void Main (string[]args)
    {
        //Ejercicio 2_1:

        Console.WriteLine("--- Ejercio 2: INICIALIZACION DIRECTA Y FOREACH");
        string [] frutas = {"Melón", "Frutilla", "Banana", "Tomate"};

        Console.WriteLine("Listado de frutas usando foreach");

        foreach (string fruta in frutas)
        {
            Console.WriteLine("- " + fruta);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //---------------------------------------------------------------------------
        //Ejercicio 2_2:
        string [] frutas1 = {"Pera", "Limon","Arandanos", "Uvas"};
        Console.WriteLine("Lista de frutas usando foreach");

        foreach (string fruta1 in frutas1)
        {
            Console.WriteLine("- " + fruta1);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //-------------------------------------------------------------------------------
        //Ejercicio 2_3:
        string [] frutas2 = {"Sandia", "Kiwi", "Durazno"};
        Console.WriteLine("Listado de frutas usando foreach");

        foreach( string fruta2 in frutas2)
        {
            Console.WriteLine("- " + fruta2);
        }
        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //-----------------------------------------------------------------------------------
        //Ejercicio 2_4:
        string [] frutas3 = {"Mandarina", "Pomelo", "Lima"};
        Console.WriteLine("Listado de frutas usando foreach");

        foreach(string fruta3 in frutas3)
        {
            Console.WriteLine("- " + fruta3);
        } 
        Console.WriteLine("\nPrecione ENTER para salir");
        Console.ReadLine();

        //------------------------------------------------------------------------------------
        //Ejercicio 2_5;
        string [] frutas4 = {"Piña", "Mango", "Anana", "Maracuya"};
        Console.WriteLine("Listado de frutas usando foreach");

        foreach (string fruta4 in frutas4)
        {
            Console.WriteLine("- " + fruta4);
        }
        Console.WriteLine("Presione ENTER para salir");
        Console.ReadLine();
    }
       
}
