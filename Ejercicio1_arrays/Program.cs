namespace Ejercicio1_array;
class Program
{
    static void Main (string []args)
    {
        //-----------------------------------------------------------------------------------------------------------
        //Ejercicio 1_1
        Console.WriteLine("--- EJERCICIO 1: FUNDAMENTOS DE ARREGLOS ---");
        int [] numeros = new int [3];
        numeros[0]=15;
        numeros[1]=30;
        numeros[2]=45;

        Console.WriteLine("Valor en indice 0: " + numeros[0]);
        Console.WriteLine("Valor en indice 1: " + numeros[1]);
        Console.WriteLine("Valor en indice 2: " + numeros[2]);

        Console.WriteLine("\nPresione ENTER para continuar");
        Console.ReadLine();

        //--------------------------------------------------------------------
        //Ejercicio 1_2
        int [] numeros1 = new int [4];
        numeros1[0]= 2;
        numeros1[1]= 9;
        numeros1[2]= 6;
        numeros1[3]= 5;

        Console.WriteLine("Valor en indice 0: " + numeros1[0]);
        Console.WriteLine("Valor en indice 1: " + numeros1[1]);
        Console.WriteLine("Valor en indice 2: " + numeros1[2]);
        Console.WriteLine("Valor en indice 3: " + numeros1[3]);

        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //-----------------------------------------------------------------------------
        //Ejercicio 1_3
        int [] numeros2 = new int [5];
        numeros2 [0]= 12;
        numeros2 [1]= 15;
        numeros2 [2]= 20;
        numeros2 [3]= 25;
        numeros2 [4]= 34;
        
        Console.WriteLine("El valor en indice 0: " + numeros2[0]);
        Console.WriteLine("El valor en indice 1: " + numeros2[1]);
        Console.WriteLine("El valor en indice 2: " + numeros2[2]);
        Console.WriteLine("El valor en indice 3: " + numeros2[3]);
        Conaole.WriteLine("El valor en indice 4: " + numeros2[4]);

        Console.WriteLine("\nPresione ENTER para continuar");
        Console.ReadLine();
        
        //-----------------------------------------------------------------------------------
        //Ejercicio 1_4
        int [] numeros3 = new int [5];
        numeros3 [0] = 7;
        numeros3 [1] = 9;
        numeros3 [2] = 10;
        numeros3 [3] = 23;
        numeros3 [4] = 52;
        
        Console.WriteLine("El valor en el indice 0: " + numeros3[0]);
        Console.WriteLine("El valor en el indice 1: " + numeros3[1]);
        Console.WriteLine("El valor en el indice 2: " + numeros3[2]);
        Console.WriteLine("El valor en el indice 3: " + numeros3[3]);
        Console.WriteLine("El valor en el indice 4: " + numeros3[4]);

        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();

        //-----------------------------------------------------------------------------------------------------------------------------
        //Ejercicio 1_5
                int [] numeros3 = new int [6];
        numeros3 [0] = 86;
        numeros3 [1] = 45;
        numeros3 [2] = 39;
        numeros3 [3] = 52;
        numeros3 [4] = 91;
        numeros3 [5] = 67;
        
        Console.WriteLine("El valor en el indice 0: " + numeros3[0]);
        Console.WriteLine("El valor en el indice 1: " + numeros3[1]);
        Console.WriteLine("El valor en el indice 2: " + numeros3[2]);
        Console.WriteLine("El valor en el indice 3: " + numeros3[3]);
        Console.WriteLine("El valor en el indice 4: " + numeros3[4]);
        Console.WriteLine("El valor en el indice 5: " + numeros3[5]);

        Console.WriteLine("\nPresione ENTER para salir");
        Console.ReadLine();
    }
}
