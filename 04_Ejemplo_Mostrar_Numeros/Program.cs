/*
 * Aparte de mostrar texto, también podemos mostrar números.
 * No solo eso, también podemos incluir una suma, resta o  división
 * y veremos que el resultado aparece en pantalla
 */

using System;

namespace _04_Ejemplo_Mostrar_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5); // Muestra 5 en pantalla
            /*
             * Al estar escritros entre comillas, el programa
             * entiende que es un texto normal, no números que
             * sumar, por lo que simplemente imprime el texto
             */
            Console.WriteLine("5 + 2");  // Muestra 5 + 2 en pantalla
            // Sin comillas en cambio, podemos realizar diversas operaciones
            Console.WriteLine(5 + 2); // Muestra 7 en pantalla
            Console.WriteLine(10 - 2); // Muestra 8 en pantalla
            Console.WriteLine(6 * 3); // Muestra 18 en pantalla

            /* 
             * Los dos siguientes ejemplos son interesantes.
             * Si escribes 6/4 para dividir 6 entre 4, el
             * resultado no tiene en cuenta los decimales.
             * Para que los decimales de la división se
             * tengan en cuenta, uno de los números tiene
             * que tener decimales (aunque sea .0)
             */
            Console.WriteLine(6 / 4); // Muestra 1 en pantalla
            Console.WriteLine(6.0 / 4); // Muestra 1,5 en pantalla
            Console.WriteLine(6 % 4); //Muestra 2 en pantalla
            Console.WriteLine(4 % 2); //Muestra 0 en pantalla

            /*
             * Como se hace en matemáticas, para calcular
             * el resultado primero se multiplica y/o divide
             * y después se suma y/o resta. Por eso el siguiente
             * ejemplo muetra un 8 como resultado (primero multiplicamos
             * 3 por 2 y después le sumamos 2).
             */
            Console.WriteLine(2 + 3 * 2); // Muestra 8 en pantalla

            /*
             * Para cambiar el orden, agrupamos dentro de
             * paréntesis. En el siguiente ejemplo 2 y 3 se suman
             * primero y después se multiplica por 2
             */
            Console.WriteLine((2 + 3) * 2); // Muestra 10 en pantalla

        }
    }
}
