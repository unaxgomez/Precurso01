/*
 * Uno de los principales problemas de Console.ReadLine()
 * es el hecho de que siempre convierte lo que el usuario
 * escribe en string.
 * 
 * Imaginemos que en vez de preguntar el nombre preguntamos 
 * la edad del usuario. En ese caso, tendríamos:
 *      int edad;
 *      edad = Console.ReadLine();
 * pero hemos dicho que Console.ReadLine() crea un string,
 * y ya hemos visto que no podemos poner un valor de string
 * dentro de una variable de número entero (int).
 * 
 * La solución es exactamente la misma que para cualquier
 * otro tipo de string que queremos transformar en valor
 * numérico, es decir, usar Convert.ToInt32() . Hay que recordar 
 * que para el ordenador no hay diferencia entre un valor 
 * que nosotros hemos escrito directamente, como "25" o un 
 * valor que el usuario a escrito con su teclado y nosotros 
 * hemos introducido en el programa con Console.ReadLine()
 */

using System;

namespace _13_Ejemplo_Input_Numerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad"); // Escribimos en pantalla las instrucciones para el usuario
            string edadTexto; // Creamos una variable de tipo string
            edadTexto = Console.ReadLine(); // Lo que el usuario escriba en pantalla pasará a ser el valor de la variable edadTexto
            // Ahora que tenemos la edad en formato texto, pasemoslo a un entero
            int edad;
            edad = Convert.ToInt32(edadTexto);

            Console.WriteLine("Hola, tienes " + edad + " años"); // Mostramos en pantalla un saludo con el nombre que el usuario a introducido

        }
    }
}
