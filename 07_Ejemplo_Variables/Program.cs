/*
 * Del mismo modo que hemos escrito el mensaje directamente
 * dentro de Console.WriteLine, podemos escribirlo en
 * lo que denominamos una variable, y después utilizar esa
 * variable dentro de WriteLine.
 */

using System;

namespace _07_Ejemplo_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * En el siguiente ejemplo podéis ver que 
             * el ordenador hace lo mismo que si escribieramos
             * Console.WriteLine("Hola Mundo con variables");
             * pero primero ponemos el mensaje en una variable
             * (decimos que es una variable tipo cadena de
             * caracteres - string) y la nombramos saludo.
             * Después a WriteLine le decimos que coja
             * el valor que hay dentro de la variable saludo
             */
            string saludo; // crea una variable tipo cadena de caracteres (string) llamada saludo
            saludo = "Hola Mundo con variables"; // Le damos a la variable saludo el valor "Hola Mundo con variables"
            Console.WriteLine(saludo); // Muestra en pantalla el valor de la variable saludo, es decir, "Hola Mundo con variables"

            /*
             * Hagamos lo mismo con una variable y valor de 
             * variable diferente. Una vez más, creamos una variable
             * diciendo que queremos una variable de tipo string
             * que se llama frase: 
             *     string frase;
             * Después podemos utilizar el nombre de la variable
             * para referirnos al valor que tiene dentro.
             */

            string frase; // Crea una variable tipo cadena de caracteres (string) llamada frase
            frase = "Tengo " + 2 + " manzanas"; // Le damos a la variable frase el valor "Tengo 2 manzanas"
            Console.WriteLine(frase); // Muestra en pantalla el valor de la variable frase, es decir, "Tengo 2 manzanas"

            /*
             * Ya que hemos creado la variable saludo antes, esta sigue 
             * existiendo y podemos reutilizarla para ver que su valor
             * sigue siendo el mismo.
             */
            Console.WriteLine(saludo); // Muestra en pantalla "Hola Mundo con variables"

        }
    }
}
