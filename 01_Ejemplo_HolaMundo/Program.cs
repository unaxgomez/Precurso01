/*
 * Si ejecutas el programa (pulsando la tecla F5 o haciendo clic en el botón Iniciar) verás
 * que aparece una pantalla de consola en el cual puedes leer el mensaje "Hola, Mundo". Para
 * hacer que el programa acabe debes pulsar una tecla.
 * 
 * El inicio del programa en si es la línea System.Console.WriteLine("Hola, Mundo");
 * Como indica su nombre está escribiendo una línea (Write Line) con la frase Hola, Mundo.
 * Lo siguiente que hace el programa es esperar a que el usuario pulse una tecla y leer
 * esa tecla (Read Key). Después de leer la tecla el programa no tiene otra cosa que hacer
 * por lo que acaba. Si no tuvieramos la instrucción Console.ReadKey(); , el programa
 * abriría la pantalla de consola, mostraría Hola, Mundo y cerraría la pantalla inmediatamente
 * practicamente no dando tiempo ni a verlo.
 * 
 * En los programas de consola de C#, siempre tenemos un lugar donde aparece la frase 
 * static void Main(string[] args) , y ese es el lugar donde empieza el programa. Durante el 
 * Bootcamp veremos qué es lo que significa, de momento basta con que sepas que lo primero 
 * que el programa hará será lo que aparece inmediatamente después. Todo lo anterior
 * (using, namespace, class, ...) no hace falta que lo memorices ya que cuando crees un 
 * programa nuevo con el Visual Studio llenará eso automaticamente (una vez más, a lo largo
 * del Bootcamp aprenderemos qué es cada una de las cosas que aparecen antes del Main).
 */

using System;

namespace _01_Ejemplo_HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, Mundo");
        }
    }
}
