﻿namespace Program03;

class Program
{
    static void Main(string[] args)
    {
        //EJERCICIO 1:
        
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");
        Console.WriteLine("Bienvenidos al parque de diversiones");
        double alturaPermitida = 1.60;
        Console.WriteLine("Para ingresar al parque debe medir mas de 1,60 mts");
        Console.WriteLine("Por favor, ingrese su altura");
        double altura = double.Parse(Console.ReadLine());
        if (altura < alturaPermitida)
        {
            Console.WriteLine("No puede ingresar al parque, regrese en unos años.");
            Console.WriteLine("¡Hasta Luego!");
        }
        else
        {
            Console.WriteLine("¡Bienvenido al parque, que lo disfrute!");
        }

        
    }
}