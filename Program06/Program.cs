namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        //EJERCICIO 1:

        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string nombreJuego = "Counter Strike 2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + nombreJuego + " ===");
            Console.WriteLine("Cargando reglas del sistema...");

            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante nombreJuego = " + nombreJuego);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------------------------------
            //EJERCICIO 2:
            const string NOMBRE_APP = "FREE FIRE";
            const string VERSION = "v1.123";
            const int edadMinima = 13;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + edadMinima + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int edadCliente = 16;
            const bool puedeIngresar = edadCliente>= edadMinima; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + edadCliente + " años...");
            Console.WriteLine("Edad mínima: " + edadMinima);
            Console.WriteLine("Acceso permitido (valor bool constante): " + puedeIngresar);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------
            //EJERCICIO 3:
            Console.WriteLine("===VERIFICACION DE CONTRASEÑA===");
            const string nivelcontraseña = "Buena";
            const int caracteresCargados = 6;
            const int caracteresMin = 4;

            Console.WriteLine("El nivel de su contraseña es " + nivelcontraseña + "; caracteres ingresados " + caracteresCargados);
            Console.WriteLine("La cantidad de caracteres minimos aceptados es: " + caracteresMin);

            const bool contraseñaAceptada= caracteresCargados >= caracteresMin;
            Console.WriteLine("Su contraseña cumple los parametros: " + contraseñaAceptada);
            Console.WriteLine("Presion ENTER para salir");
            Console.ReadLine(); 

            //------------------------------------------------------------------------------------------------------------------------------
            //EJERCICIO 4
            Console.WriteLine("=== VALIDACION NIVEL DE JUEGO ===");

            const string NOMBREJUEGO = "Clash Royale";
            const string VERSIONJUEGO = "1.3.7";
            const int nivelMax = 15;
            const int nivelMed = 7;
            
            Console.WriteLine("=== Nombre del juego: " + NOMBREJUEGO + " Version " + VERSIONJUEGO +" ===");
            Console.WriteLine("Su nivel medio es " + nivelMed + " y su nivel maximo es " + nivelMax);
            //constatar que el nivel actual entre dentro del rango
            const int nivelActual =5;
            const bool nivelPlata = nivelActual>nivelMed && nivelActual<nivelMax;
            Console.WriteLine("El nivel actual del jugador es: " + nivelActual);
            Console.WriteLine("¿El jugador se encuentra denteo del nivel plata? " + nivelPlata);
            Console.WriteLine("\nPresione ENTER para salir");
            Console.ReadLine();

            //---------------------------------------------------------------------------------------------------------------
            //EJERCICIO 5
            Console.WriteLine("== Temperatura aire acondicionado permitida ==");
            const string aparato = "Aire Acondicionado";
            const int tempMin= 16;
            const int temMax= 25;

            Console.WriteLine("El " + aparato + " tiene una temperatura permitida entre " + tempMin + " y " + temMax +" grados");
            const int tempActual = 18;
            bool tempPermitida = tempActual > tempMin && tempActual<temMax;

            Console.WriteLine("La temperatura actualmente se encuentra en " + tempActual +"°");
            Console.WriteLine("¿La temperatura actual esta dentro de la permitida? " + tempPermitida);
            Console.WriteLine("Presione ENTER para salir");
            Console.ReadLine();
    }
}