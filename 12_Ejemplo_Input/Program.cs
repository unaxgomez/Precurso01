/*
 * Hasta ahora, sólo hemos utilizado datos que habíamos
 * escrito en el propio programa, ahora empezaremos a
 * utilizar datos que nos darán los usuarios. Para ello,
 * haremos uso de la instrucción Console.ReadLine()
 * 
 * Console.ReadLine() "captura" lo que el usuario escribe
 * y lo convierte en un string, por lo que lo podemos
 * guardar en una variable de ese tipo.
 */

using System;

namespace _12_Ejemplo_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre"); // Escribimos en pantalla las instrucciones para el usuario
            string nombre; // Creamos una variable de tipo string
            nombre = Console.ReadLine(); // Lo que el usuario escriba en pantalla pasará a ser el valor de la variable nombre

            Console.WriteLine("Hola, " + nombre); // Mostramos en pantalla un saludo con el nombre que el usuario a introducido
        }
    }
}
