/*
 * En este ejemplo veremos como podemos hacer que se combinen
 * distintas partes de texto, utilizando el símbolo + para
 * concatenar (unir) tanto distintos textos como textos con
 * números.
 */

using System;

namespace _05_Ejemplo_Mostrar_Numeros_Y_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Al unir cadenas de texto, el ordenador las une
             * sin añadir nada. Por lo tanto, en este ejemplo
             * las palabras aparecen sin espacio entre ellas.
             */
            Console.WriteLine("Hola" + "mundo");
            Console.WriteLine(); // Si no pasamos nada a WriteLine, añade una linea vacia a la pantalla.

            /*
             * Podemos añadir un espacio al final de la primera
             * palabra, o un epacio al final de la segunda,
             * o añadir una palabra que sea solo un espacio
             * entre las dos. Los próximos 3 ejemplos muestra
             * exactamente el mismo mensaje en pantalla
             */
            Console.WriteLine("Hola " + "mundo"); // Espacio al final de hola
            Console.WriteLine("Hola" + " mundo"); // Espacio antes de mundo
            Console.WriteLine("Hola" + " " + "mundo"); // Una cadena de carácteres de solo un espacio añadido entre hola y mundo.

            Console.WriteLine(); // Utilizado para separar en pantalla lo que aparece

            Console.WriteLine("Tengo" + 2 + "manzanas"); // Si añadimos un valor numérico WriteLine lo convierte en texto
            Console.WriteLine("Tengo " + 2 + " manzanas"); // Pero hay que seguir añadiendo los espacios del mismo modo que antes.

            /*
             * Al convertir valores numéricos a texto, estos se
             * utilizan como texto el resto dle tiempo.
             * Por esta razón en el siguiente ejemplo el 2 se
             * convierte en texto y el texto "Tengo 2" se une al
             * valor numérico 3. Como 2 se considera texto, el
             * resultado es "Tengo 23".
             * Para evitar que se haga en este orden y no sumemos
             * los valores numéricos (que en este caso queremos
             * hacer) utilizamos las paréntesis. En el segundo ejemplo
             * 2 y 3 son valores numéricos cuando se suman entre
             * ellos, y no se convierten en texto hasta una vez hecha
             * la suma
             */
            Console.WriteLine("Tengo " + 2 + 3 + " manzanas"); // Muestra Tengo 23 manzanas en pantalla
            Console.WriteLine("Tengo " + (2 + 3) + " manzanas"); // Muestra Tengo 5 manzanas en pantalla
        }
    }
}
