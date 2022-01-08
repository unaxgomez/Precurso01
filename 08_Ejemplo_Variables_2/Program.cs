/*
 * Igual que podemos crear variables de cadenas de caracteres (string),
 * también podemos crear variables de valores numéricos. Durante el
 * Bootcamp veremos varios tipos, de momento en el pre-curso veremos
 * el más básico, la variable de tipo número entero (un número positivo
 * o negativo, pero que no tenga decimales). Número entero en inglés
 * se denomina integer, por lo tanto cuando queremos decir que una
 * variable es de tipo entero, escribimos int nombre;
 */

using System;

namespace _08_Ejemplo_Variables_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; // Creamos una variable de tipo entero llamado numero
            numero = 2; // Le damos el valor 2 a la variable numero
            Console.WriteLine(numero); // Mostramos en pantalla el valor de la variable numero (2)

            numero = 4; // Podemos seguir utilizándo la misma variable, pero hacer que cambie el valor que tiene
            Console.WriteLine(numero); // Mostramos a pantalla para demostrar que hemos cambiado el valor

            numero = numero + 2; // Ahora lo que haremos sera darle a numero el valor que ya tenía, más dos
            Console.WriteLine(numero); // Mostramos a pantalla cómo numero tiene un valor 2 mayor que antes.

            numero = numero - 1; // Hacemos lo mismo pero restando 1.
            Console.WriteLine(numero); // Mostramos en pantalla

        }
    }
}
