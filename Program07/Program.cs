﻿using System.Collections;

namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
            //------------------------------------------------------------------------------------------------------------
            
            //EJERCICIO 1:
            const char signo = '$';
            const decimal precioProducto = 1500.00m; 
            const int cantidad = 6;
            const bool MODO_PRUEBA = false; // Control de seguridad

            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);
            Console.WriteLine("\nDetalle de venta: ");

            Console.WriteLine("El precio del producto seleccionado vale: " + signo + precioProducto);
            Console.WriteLine("La cantidad seleccionada es: " + cantidad);
            Console.WriteLine("El total vendido es: " + signo +(cantidad*precioProducto));
            Console.WriteLine("Para salir presione ENTER");
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------------
            //EJERCICIO 2:
            const decimal descuento = 0.15m;
            decimal precio = 35000m;
            decimal totalDescuento = precio*descuento;
            decimal total= precio-totalDescuento;
            const bool MODO_PRUEBA = true; // Control de seguridad

            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);
            Console.WriteLine("El precio del producto es: "+ signo + precio);
            Console.WriteLine("Si usted paga en efectivo tiene un descuento de " + (descuento*100)+ "%");
            Console.WriteLine("Usando ese medio de pago le quedaria para abonar: " + signo + total);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------
            //EJERCICIO 3:
            const decimal aumento = 0.30m;
            decimal sueldo = 1000000;
            decimal totalAumento = sueldo*aumento;
            decimal sueldoNuevo = sueldo + totalAumento;
            const bool MODO_PRUEBA = true; // Control de seguridad

            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);
            Console.WriteLine("Su sueldo actualmente es de: " + signo + sueldo);
            Console.WriteLine("El aumento informado sera de un " + (aumento*100) + "%");
            Console.WriteLine("Lo que actualizaria su sueldo en el monto de "+ signo + sueldoNuevo);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------
            //EJERCICIO 4:
            const int precioMoto = 4500000;
            int aumentoMoto = 2500000;
            int ActualPrecio = precioMoto + aumentoMoto;
            const bool MODO_PRUEBA = true; // Control de seguridad

            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);
            Console.WriteLine("El precio de la motomel skua es de: " + precioMoto);
            Console.WriteLine("El aumento informado es de: " + aumentoMoto);
            Console.WriteLine("Al momento de actualizar el precio quedaria en: " + ActualPrecio);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            //-------------------------------------------------------------------------------------------------------
            //EJERCICIO 5:
            Console.WriteLine("Conversion de km a mts");
            const int metros = 1000;
            const int kilometros = 3;
            int conversion = metros * kilometros;
            Console.WriteLine("Un km son " + metros + " metros");
            Console.WriteLine(kilometros +" kilometros equivalen a "+ conversion + " metros" );
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine ();

    }
}