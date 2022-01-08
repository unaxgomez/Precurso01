using System;

namespace _18_Ejercicio_Repaso04
{
    class Program
    {
        static void Main(string[] args)
        {

            //creamos las variables de tipo int llamadas 'a' y 'b'
            int a, b;

            //creamos una tercera variable de tipo int llamada 'c' para poder realizar
            //el intercambio de valores
            int c;
            //pedimos al usuario que escriba un número y asignamos el valor a la 
            //variable 'a'
            Console.WriteLine("Escribe un número: ");
            a = Convert.ToInt32(Console.ReadLine());


            //asignamos el valor de la variable 'a' a la variable 'c'
            c = a;
            //pedimos al usuario que escriba otro número y asignamos su valor a la 
            //variable 'b'
            Console.WriteLine("Escribe un número");
            b = Convert.ToInt32(Console.ReadLine());

            //asignamos el valor de la variable 'b' a la variable 'a'
            a = b;
            //asignamos el valor de la variable 'c' a la variable 'b'
            b = c;
            //mostramos por pantalla los valores de las variables
            Console.WriteLine("a: " + a + " y b: " + b);
        }
    }
}
