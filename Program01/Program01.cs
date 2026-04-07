﻿namespace Program01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido/a, vamos a gestionar tu usuario");
        Console.WriteLine("Por favor ingresa tu nombre completo");
        string nombre= Console.ReadLine();

        Console.WriteLine("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el usuario deseado:");
        string usuario= Console.ReadLine();

        Console.WriteLine("Ingresa tu contraseña");
        string contraseña=Console.ReadLine();

        Console.WriteLine("----- Los datos cargados son: -----");
        Console.WriteLine("Nombre completo: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Usuario: " + usuario);
        Console.WriteLine("Contraseña: " + contraseña);

        Console.WriteLine("\n Sus datos quedan registrados, presione enter para salir");
    }
}