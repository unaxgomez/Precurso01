/*
 * Dentro de cualquier programa, podemos marcar zonas con comentarios. El ordenador
 * ignorará lo que escribamos en estas zonas, pero serán útiles para cualquier
 * persona que los lea (o incluso para nosotros mismos). En este programa tienes
 * el ejemplo de los dos tipos de comentarios posibles. Y aunque puedas ver muchas
 * más cosas escritas que en el programa anterior, verás que al ejecutarlo
 * hace _exactamente_ lo mismo que el anterior. Recuerda cambiar el archivo a Iniciar
 * usando el menú desplegable.
 * 
 * Dentro del Visual Studio, veremos que estos comentarios son coloreados de un color
 * diferente del resto del código (verde por defecto).
 * 
 * Este es un tipo de comentario que se puede extender a lo largo de múltiples líneas,
 * y empieza cuando escribimos los símbolos /* y acaba cuando los escribimos en el orden
 * contrario:
 */

// Las dos barras marcan un comentario para el resto de la línea

using System;

namespace _02_Ejemplo_Comentarios
{
    class Program
    {
        /* Recordemos que todo programa de consola de C# debía incluir 
         * esto y que marca el principio del programa
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo con comentarios"); // Esta línea es la que hace que se escriba a pantalla la frase Hola Mundo con comentarios
            // Para pasar texto a WriteLine, tenemos que ponerlo entre comillas.
        }
    }
}
