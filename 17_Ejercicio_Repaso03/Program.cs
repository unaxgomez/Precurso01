/*
 * Escribe un programa que pida tres números al usuario y que calcule y muestre su media.
 */
using System;

namespace _17_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número");
                       string numerouno;
            numerouno = Console.ReadLine();

            int numerouno1;
            numerouno1 = Convert.ToInt32(numerouno);

            Console.WriteLine("Escribe otro número");
            string numerodos;
            numerodos = Console.ReadLine();

            int numerodos2;
            numerodos2 = Convert.ToInt32(numerodos);

            Console.WriteLine("Escribe otro número");
            string numerotres;
            numerotres = Console.ReadLine();

            int numerotres3;
            numerotres3 = Convert.ToInt32(numerotres);

            Console.WriteLine("Media de los tres números = " + (numerouno1 + numerodos2 + numerotres3) / 3);

            //Introduce aquí tu código
        }
    }
}
