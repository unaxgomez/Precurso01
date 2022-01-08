/*
 * Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
 * Pistas:
 * 1. El resto de una división cuyo divisor es 10, 100, 1000... se corresponde con los decimales del resultado
 * 52/10 = 5,2
 * 52%10 = 2
 */
using System;

namespace _19_Ejercicio_Repaso05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número de 3 dígitos");

            int numero;
                numero = Convert.ToInt32(Console.ReadLine());

            int a;
            a = (numero /100) % 10;

            int b;
            b = (numero / 10) % 10;

            int c;
            c = numero % 10;

           Console.WriteLine("La suma de los 3 dígitos es " + (a+b+c));
            //Introduce aquí tu código
        }
    }
}
