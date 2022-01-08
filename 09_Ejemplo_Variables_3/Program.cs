/*
 * Ya que al utilizar una variable estamos utilizando el valor que hay
 * dentro de la variable, podemos utilizar variables cuando definimos
 * una variable nueva.
 */

using System;

namespace _09_Ejemplo_Variables_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int manzanas; // Creamos una variable de tipo numero entero llamado manzanas.
            manzanas = 2; // Damos el valor 2 a la variable manzanas.
            string frase; // Creamos una variable de tipo cadena de caracteres llamado frase.
            frase = "Tengo " + manzanas + " manzanas"; // Damos el valor "Tengo 2 manzanas" a la variable frase.
            Console.WriteLine(frase); // Mostramos en pantalla el contenido de la variable frase.

            manzanas = manzanas + 1; // Añadimos 1 al valor que hay dentro de la variable manzanas.
            frase = "Tengo " + manzanas + " manzanas"; // Damos a la variable frase un nuevo valor.
            Console.WriteLine(frase); // Mostramos en pantalla el valor de la variable frase
        }
    }
}
